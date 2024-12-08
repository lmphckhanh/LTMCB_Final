Create Database CinemaManagement
Go
Use CinemaManagement
Go

CREATE TABLE Cinema
(
	CinemaID VARCHAR(6) PRIMARY KEY,
	CinemaName NVARCHAR(20) NOT NULL,
	LocationCode varchar(3) NOT NULL,
	Address NVARCHAR(50) NOT NULL,
	Note nvarchar(Max) NOT NULL,
)

CREATE TABLE RoomInCinema
(
	CinemaID VARCHAR(6) NOT NULL, --FK
	RoomID VARCHAR(6) NOT NULL, --FK
)

CREATE TABLE Room
(
	RoomID VARCHAR(6) PRIMARY KEY,
	RoomTypeID VARCHAR(6) NOT NULL, -- ForeignKey
	RoomName NVARCHAR(20) NOT NULL, --ex B10
	MaxSlot INT NOT NULL,
	Status NVARCHAR(10) NOT NULL, --Full, Avalable, Mantainance,...
)

CREATE TABLE RoomType
(
	RoomTypeID VARCHAR(6) PRIMARY KEY,
	RoomTypeName NVARCHAR(30) UNIQUE NOT NULL,
)

CREATE TABLE Shifts
(
	ShiftID INT PRIMARY KEY,
	Time TIME UNIQUE NOT NULL,
)

CREATE TABLE ShowTimes --Sử dụng Procedure để nhập!
(
	ShowTimeID VARCHAR(6) PRIMARY KEY,
	MovieID VARCHAR(6) NOT NULL,
	ShiftID INT,
	RoomID VARCHAR(6) NOT NULL,
	Date DATE NOT NULL,
	EndTime TIME,
)

CREATE TABLE MovieType
(
	MovieTypeID VARCHAR(6) PRIMARY KEY,
	MovieTypeName NVARCHAR(20) UNIQUE NOT NULL,
)

CREATE TABLE Category
(
	CategoryID VARCHAR(6) PRIMARY KEY,
	CategoryName NVARCHAR(20) UNIQUE NOT NULL,
)

CREATE TABLE Movie
(
	MovieID VARCHAR(6) PRIMARY KEY,
	CategoryID VARCHAR(6) NOT NULL,
	Name NVARCHAR(50) NOT NULL,
	Director NVARCHAR(50) NOT NULL,
	Duration TIME NOT NULL,
	ReleaseDay DATE NOT NULL,
	Language NVARCHAR(20) NOT NULL,
	MinAge INT NOT NULL,
	Rate NUMERIC(2,1) NOT NULL, --0.0->5.0
	Image NVARCHAR(MAX) NOT NULL,
	Status BIT NOT NULL, --1: Trong thời gian công chiếu, 0: Không đc công chiếu
)

CREATE TABLE MovieOnType
(
	MovieID VARCHAR(6) NOT NULL,
	MovieTypeID VARCHAR(6) NOT NULL,
)

CREATE TABLE MovieOnCat
(
	MovieID VARCHAR(6) NOT NULL,
	CategoryID VARCHAR(6) NOT NULL,
)

CREATE TABLE TypicalActor
(
	MovieID VARCHAR(6) NOT NULL,
	ActorName NVARCHAR(50) NOT NULL,
)

CREATE TABLE SlotType
(
	SlotTypeID VARCHAR(6) PRIMARY KEY,
	SlotTypeName NVARCHAR(20) UNIQUE NOT NULL,
	Price NUMERIC(10,2) NOT NULL, --VND
)

CREATE TABLE Slot
(
	SlotID VARCHAR(6) PRIMARY KEY,
	SlotTypeID VARCHAR(6) NOT NULL,
	Row INT NOT NULL,
	Col CHAR(1) NOT NULL,
	Status INT NOT NULL, --1: Taken, 0: Empty, -1: Error
)

CREATE TABLE SlotInRoom
(
	RoomID VARCHAR(6) NOT NULL,
	SlotID VARCHAR(6) NOT NULL,
)


CREATE TABLE Ticket
(
	TicketID VARCHAR(100) PRIMARY KEY,
	SlotID VARCHAR(6) NOT NULL,
	ShowTimeID VARCHAR(6) NOT NULL,
)

CREATE TABLE Bill
(
	BillID VARCHAR(100) PRIMARY KEY, --orderId
	AccountID VARCHAR(100) NOT NULL,
	TotalPrice NUMERIC(10,2) NOT NULL, --amount
	Date DATE NOT NULL,
	Time TIME NOT NULL,
	Status BIT NOT NULL, --1: Còn hiệu lực(chưa chiếu), 0: hết hiệu lực
	RequestID VARCHAR(100) UNIQUE NOT NULL, --requestId
)

CREATE TABLE TicketOnBill
(
	BillID VARCHAR(100) NOT NULL,
	TicketID VARCHAR(100) NOT NULL,
)

CREATE TABLE Role
(
	RoleID VARCHAR(6) PRIMARY KEY,
	RoleName NVARCHAR(20) NOT NULL,
	Priority INT NOT NULL, --Độ ưu tiên càng lớn quyền càng cao!
)

CREATE TABLE Account
(
	AccountID VARCHAR(100) PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	Phone NVARCHAR(11) NOT NULL,
	Password VARCHAR(MAX) NOT NULL,
	Sex NVARCHAR(6) NOT NULL,--Male, Female, Other
	BirthDay DATE NOT NULL,
	RoleID VARCHAR(6) NOT NULL,
)

CREATE	TABLE Comment
(
	CommentID VARCHAR(100) PRIMARY KEY,
	AccountID VARCHAR(MAX) NOT NULL,
	MovieID VARCHAR(6) NOT NULL,
	Content NVARCHAR(MAX) NULL,
	DateTime DATETIME DEFAULT GETDATE(),
	Rate NUMERIC(2,1) NULL,
)

GO
---------------------------------------------
---Constraint--
--Cinema
--RoomInCinema
ALTER TABLE dbo.RoomInCinema ADD CONSTRAINT FK_RoomInCinema_Cinema FOREIGN KEY (CinemaID) REFERENCES dbo.Cinema(CinemaID);
ALTER TABLE dbo.RoomInCinema ADD CONSTRAINT FK_RoomInCinema_Room FOREIGN KEY (RoomID) REFERENCES dbo.Room(RoomID);
ALTER TABLE dbo.RoomInCinema ADD CONSTRAINT PK_RoomInCinema	PRIMARY KEY (CinemaID,RoomID);

--Room
ALTER TABLE	dbo.Room ADD CONSTRAINT FK_Room_RoomType FOREIGN KEY (RoomTypeID) REFERENCES dbo.RoomType(RoomTypeID);
ALTER TABLE dbo.Room ADD CONSTRAINT Check_Status CHECK (Status IN ('Full', 'Available', 'Maintenance')); 

--RoomType

--Shifts

--ShowTimes
ALTER TABLE dbo.ShowTimes ADD CONSTRAINT FK_ShowTimes_Movie FOREIGN KEY (MovieID) REFERENCES dbo.Movie(MovieID);
ALTER TABLE dbo.ShowTimes ADD CONSTRAINT FK_ShowTimes_Shifts FOREIGN KEY (ShiftID) REFERENCES dbo.Shifts(ShiftID);
ALTER TABLE dbo.ShowTimes ADD CONSTRAINT FK_ShowTimes_Room FOREIGN KEY (RoomID) REFERENCES dbo.Room(RoomID);
GO	
CREATE TRIGGER Trig_ShowTimes_Time ON dbo.ShowTimes
FOR INSERT, UPDATE
AS
BEGIN
	IF EXISTS 
	(SELECT * FROM Inserted JOIN dbo.Movie ON Inserted.MovieID = Movie.MovieID WHERE Inserted.Date < Movie.ReleaseDay)
	BEGIN
	    PRINT N'Ngày chiếu không phù hợp!'
		ROLLBACK TRAN
	END

	DECLARE @NewDate DATE; --Ngày của showtime mới
	SELECT @NewDate = Date FROM Inserted;

	DECLARE @Dur TIME; --Lấy thời lượng phim
	SELECT @Dur = Duration FROM dbo.Movie WHERE MovieID IN (SELECT MovieID FROM Inserted);

	DECLARE @ShiftTime TIME; --Time of @Shift

	IF NOT EXISTS --Trường hợp record mới là ca chiếu đầu tiên
	(SELECT * FROM dbo.ShowTimes WHERE Date = @NewDate)
	BEGIN
	    UPDATE dbo.ShowTimes SET ShiftID = 1 WHERE ShowTimeID IN (SELECT ShowTimeID FROM Inserted);

		SELECT @ShiftTime = Time FROM dbo.Shifts WHERE ShiftID = 1;

		--Cập nhật endtime của record
		UPDATE dbo.ShowTimes SET EndTime = CONVERT(TIME,CONVERT(DATETIME,@ShiftTime) + CONVERT(DATETIME,@Dur))
		WHERE ShowTimeID IN (SELECT ShowTimeID FROM Inserted);
	END
	ELSE
    BEGIN
		DECLARE @Last_EndTime TIME; --EndTime trước đó
		SELECT TOP 1 @Last_EndTime = EndTime FROM dbo.ShowTimes WHERE dbo.ShowTimes.Date = @NewDate	ORDER BY EndTime DESC;
		SET @Last_EndTime =  DATEADD(mi, 30, @Last_EndTime) --+30p để chuẩn bị phòng

		IF @Last_EndTime > '22:45:00' --đảm bảo không chiếu quá trễ
		BEGIN
			PRINT N'Số lượng ca chiếu hôm nay đã đạt mức tối đa, vui lòng chuyển ca chiếu sang ngày hôm sau!'
			ROLLBACK TRAN
		END

		DECLARE @Shift INT; --Last Shift
		SELECT TOP 1 @Shift = ShiftID FROM dbo.ShowTimes WHERE Date = @NewDate ORDER BY ShiftID DESC;

		SELECT @ShiftTime = Time FROM dbo.Shifts WHERE ShiftID = @Shift;

		WHILE @ShiftTime < @Last_EndTime  --Cộng dồn ShiftID 
		BEGIN
			SET @Shift = @Shift + 1;
			SELECT @ShiftTime = Time FROM dbo.Shifts WHERE ShiftID = @Shift;
		END

		--Cập nhật lại ShiftID của record mới thêm vào
		UPDATE dbo.ShowTimes SET ShiftID = @Shift WHERE ShowTimeID IN (SELECT ShowTimeID FROM Inserted);

		--Cập nhật endtime của record
		UPDATE dbo.ShowTimes SET EndTime = CONVERT(TIME,CONVERT(DATETIME,@ShiftTime) + CONVERT(DATETIME,@Dur))
		WHERE ShowTimeID IN (SELECT ShowTimeID FROM Inserted);
	END
END

--MovieType
--Category
--Movie
ALTER TABLE dbo.Movie ADD CONSTRAINT Check_Rate CHECK (Rate BETWEEN 0.0 AND 5.0);
--MovieOnType
ALTER TABLE dbo.MovieOnType ADD CONSTRAINT FK_MovieOnType_Moive FOREIGN KEY (MovieID) REFERENCES Movie(MovieID);
ALTER TABLE dbo.MovieOnType ADD CONSTRAINT FK_MovieOnType_MovieType FOREIGN KEY (MovieTypeID) REFERENCES dbo.MovieType(MovieTypeID);
ALTER TABLE dbo.MovieOnType ADD	CONSTRAINT PK_MovieOnType PRIMARY KEY (MovieID,MovieTypeID);

--MovieOnCat
ALTER TABLE dbo.MovieOnCat ADD CONSTRAINT FK_MovieOnCat_Moive FOREIGN KEY (MovieID) REFERENCES Movie(MovieID);
ALTER TABLE dbo.MovieOnCat ADD CONSTRAINT FK_MovieOnCat_Category FOREIGN KEY (CategoryID) REFERENCES dbo.Category(CategoryID);
ALTER TABLE dbo.MovieOnCat ADD CONSTRAINT PK_MovieOnCat PRIMARY KEY (MovieID,CategoryID);

--TypicalActor
ALTER TABLE dbo.TypicalActor ADD CONSTRAINT FK_TypicalActor_Movie FOREIGN KEY (MovieID) REFERENCES dbo.Movie(MovieID);
ALTER TABLE dbo.TypicalActor ADD CONSTRAINT PK_TypicalActor PRIMARY KEY (MovieID,ActorName);

--SlotType
--Slot
ALTER TABLE dbo.Slot ADD CONSTRAINT FK_Slot_SlotType FOREIGN KEY (SlotTypeID) REFERENCES dbo.SlotType(SlotTypeID);

--SlotInRoom
ALTER TABLE dbo.SlotInRoom ADD CONSTRAINT FK_SlotInRoom_Room FOREIGN KEY (RoomID) REFERENCES dbo.Room(RoomID);
ALTER TABLE dbo.SlotInRoom ADD CONSTRAINT FK_SlotInRoom_Slot FOREIGN KEY (SlotID) REFERENCES dbo.Slot(SlotID);
ALTER TABLE dbo.SlotInRoom ADD CONSTRAINT PK_SlotInRoom PRIMARY KEY (RoomID,SlotID);

GO
CREATE TRIGGER Trig_SlotInRoom_Insert ON dbo.SlotInRoom
FOR INSERT, UPDATE
AS 
BEGIN
    DECLARE @maxSlot INT;
	SELECT @maxSlot = COUNT(SlotID) FROM dbo.SlotInRoom WHERE RoomID IN (SELECT RoomID FROM Inserted);
	UPDATE dbo.Room SET MaxSlot = @maxSlot WHERE RoomID IN (SELECT RoomID FROM Inserted);
END
GO
CREATE TRIGGER Trig_SlotInRoom_Delete ON dbo.SlotInRoom
FOR INSERT, UPDATE
AS 
BEGIN
    DECLARE @maxSlot INT;
	SELECT @maxSlot = COUNT(SlotID) FROM dbo.SlotInRoom WHERE RoomID IN (SELECT RoomID FROM Deleted);
	UPDATE dbo.Room SET MaxSlot = @maxSlot WHERE RoomID IN (SELECT RoomID FROM Deleted);
END

--Ticket
ALTER TABLE dbo.Ticket ADD CONSTRAINT FK_Ticket_Slot FOREIGN KEY (SlotID) REFERENCES dbo.Slot(SlotID);
ALTER TABLE dbo.Ticket ADD CONSTRAINT FK_Ticket_ShowTimes FOREIGN KEY (ShowTimeID) REFERENCES dbo.ShowTimes(ShowTimeID);

--Bill
ALTER TABLE dbo.Bill ADD CONSTRAINT FK_Bill_Account FOREIGN KEY (AccountID) REFERENCES dbo.Account(AccountID);
ALTER TABLE dbo.Bill ADD CONSTRAINT Default_Date DEFAULT GETDATE() FOR Date;
ALTER TABLE dbo.Bill ADD CONSTRAINT Default_Time DEFAULT GETDATE() FOR Time;
ALTER TABLE dbo.Bill ADD CONSTRAINT Default_Status DEFAULT 1 FOR Status;


--TicketOnBill
ALTER TABLE dbo.Bill ADD CONSTRAINT FK_TicketOnBill_Bill FOREIGN KEY (BillID) REFERENCES dbo.Bill(BillID);
ALTER TABLE dbo.Bill ADD CONSTRAINT FK_TicketOnBill_Ticket FOREIGN KEY (TicketID) REFERENCES dbo.Ticket(TicketID);

GO
CREATE TRIGGER Trig_TicketOnBill_Insert ON dbo.TicketOnBill
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @Total NUMERIC(10,2);
	SELECT @Total = SUM(SlotType.Price) FROM ((dbo.TicketOnBill TB JOIN dbo.Ticket T ON T.TicketID = TB.TicketID)
	JOIN dbo.Slot ON t.SlotID = Slot.SlotID) JOIN dbo.SlotType ON SlotType.SlotTypeID = Slot.SlotTypeID
	WHERE TB.BillID IN (SELECT TB.BillID FROM Inserted); 

	UPDATE dbo.Bill SET	TotalPrice = @Total WHERE BillID IN (SELECT BillID FROM Inserted);
END
GO
CREATE TRIGGER Trig_TicketOnBill_Delete ON dbo.TicketOnBill
FOR DELETE
AS
BEGIN
	DECLARE @Total NUMERIC(10,2);
	SELECT @Total = SUM(SlotType.Price) FROM ((dbo.TicketOnBill TB JOIN dbo.Ticket T ON T.TicketID = TB.TicketID)
	JOIN dbo.Slot ON t.SlotID = Slot.SlotID) JOIN dbo.SlotType ON SlotType.SlotTypeID = Slot.SlotTypeID
	WHERE TB.BillID IN (SELECT TB.BillID FROM Deleted); 

	UPDATE dbo.Bill SET	TotalPrice = @Total WHERE BillID IN (SELECT BillID FROM Deleted);
END
--Role
--Account
ALTER TABLE dbo.Account ADD CONSTRAINT FK_Account_Role FOREIGN KEY (RoleID) REFERENCES Role(RoleID);
ALTER TABLE dbo.Account ADD CONSTRAINT Check_Sex CHECK (Sex IN('Male', 'Female', 'Other'));

--Comment
ALTER TABLE dbo.Comment ADD CONSTRAINT FK_Comment_Account FOREIGN KEY (AccountID) REFERENCES dbo.Account(AccountID);
ALTER TABLE dbo.Comment ADD CONSTRAINT FK_Comment_Movie FOREIGN KEY (MovieID) REFERENCES dbo.Movie(MovieID);
ALTER TABLE dbo.Comment ADD CONSTRAINT PK_Comment PRIMARY KEY (CommentID,AccountID,MovieID);
ALTER TABLE dbo.Comment ADD CONSTRAINT Check_Rate CHECK (Rate BETWEEN 0.0 AND 5.0);
GO
CREATE TRIGGER Trig_Comment_Insert ON dbo.Comment
FOR INSERT, UPDATE
AS
BEGIN
    IF EXISTS
	(SELECT * FROM Inserted WHERE ((Inserted.Content IS NULL) AND (Inserted.Rate IS NULL)))
	BEGIN
	    PRINT N'Bình luận không hợp lệ'
		ROLLBACK TRAN;
	END

	DECLARE @avgRate NUMERIC(2,1);
	SELECT @avgRate = AVG(Rate) FROM dbo.Comment WHERE MovieID IN (SELECT MovieID FROM Inserted);
	UPDATE dbo.Movie SET Rate = @avgRate WHERE MovieID IN (SELECT MovieID FROM Inserted);
END
GO
CREATE TRIGGER Trig_Comment_Delete ON dbo.Comment
FOR DELETE
AS
BEGIN
	DECLARE @avgRate NUMERIC(2,1);
	SELECT @avgRate = AVG(Rate) FROM dbo.Comment WHERE MovieID IN (SELECT MovieID FROM Deleted);
	UPDATE dbo.Movie SET Rate = @avgRate WHERE MovieID IN (SELECT MovieID FROM Deleted);
END
