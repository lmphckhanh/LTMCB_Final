CREATE Database CinemaManagement2
--DROP DATABASE CinemaManagement2
Go
Use CinemaManagement2
GO

CREATE TABLE Cinema
(
	CinemaID VARCHAR(5) PRIMARY KEY, --ex: LT001
	CinemaName NVARCHAR(20) NOT NULL,
	LocationCode varchar(3) NOT NULL,
	Address NVARCHAR(50) NOT NULL,
	Note nvarchar(Max) NOT NULL,
)
--INSERT INTO dbo.Cinema(CinemaID,CinemaName,LocationCode,Address,Note) VALUES ('LT001',N'Lập trình', 'HCM', N'12 đường Lê Thánh Tông','Coding...');
--INSERT INTO dbo.Cinema(CinemaID,CinemaName,LocationCode,Address,Note) VALUES ('CG001',N'Mạng máy tính', 'HCM', N'13 đường Trần Thánh Tông','Catching data segment...');
--SELECT * FROM dbo.Cinema;

CREATE TABLE RoomInCinema
(
	CinemaID VARCHAR(5) NOT NULL, --FK
	RoomID VARCHAR(6) NOT NULL, --FK
)

CREATE TABLE Room
(
	RoomID VARCHAR(6) PRIMARY KEY, --RLT001
	---RoomTypeID VARCHAR(6) NOT NULL, -- ForeignKey
	RoomName NVARCHAR(20) NOT NULL, --ex B10
	MaxSlot INT DEFAULT 0,
	Status NVARCHAR(10) NOT NULL, --Full, Avalable, Mantainance,...
)
--INSERT INTO dbo.Room (RoomID,RoomName,MaxSlot,Status) VALUES ('RLT001','Phòng Lotte 1',0,'Available');
--INSERT INTO dbo.Room (RoomID,RoomName,MaxSlot,Status) VALUES ('RLT002','Phòng Lotte 2',0,'Available');
--INSERT INTO dbo.Room (RoomID,RoomName,MaxSlot,Status) VALUES ('RLT003','Phòng Lotte 3',0,'Available');
--INSERT INTO dbo.Room (RoomID,RoomName,MaxSlot,Status) VALUES ('RCG001','Phòng CGV 1',0,'Available');
--INSERT INTO dbo.Room (RoomID,RoomName,MaxSlot,Status) VALUES ('RCG002','Phòng CGV 2',0,'Available');
--INSERT INTO dbo.Room (RoomID,RoomName,MaxSlot,Status) VALUES ('RCG003','Phòng CGV 3',0,'Available');
--SELECT * FROM dbo.Room;
--INSERT INTO dbo.RoomIncinema (CinemaID,RoomID) VALUES ('LT001','RLT001');
--INSERT INTO dbo.RoomIncinema (CinemaID,RoomID) VALUES ('LT001','RLT002');
--INSERT INTO dbo.RoomIncinema (CinemaID,RoomID) VALUES ('LT001','RLT003');
--INSERT INTO dbo.RoomIncinema (CinemaID,RoomID) VALUES ('CG001','RCG001');
--INSERT INTO dbo.RoomIncinema (CinemaID,RoomID) VALUES ('CG001','RCG002');
--INSERT INTO dbo.RoomIncinema (CinemaID,RoomID) VALUES ('CG001','RCG003');
--SELECT * FROM dbo.RoomInCinema;

--CREATE TABLE RoomType
--(
--	RoomTypeID VARCHAR(6) PRIMARY KEY,
--	RoomTypeName NVARCHAR(30) UNIQUE NOT NULL,
--}

CREATE TABLE Shifts
(
	ShiftID INT PRIMARY KEY,
	Time TIME UNIQUE NOT NULL,
)

--DECLARE @time TIME = '09:00:00';
--DECLARE @id INT = 1;
--WHILE @time <= '22:30:00'
--BEGIN
--    INSERT INTO dbo.Shifts VALUES (@id,@time);
--	SET @time = DATEADD(mi,15,@time);
--	SET @id = @id + 1;
--END
--SELECT * FROM dbo.Shifts;

CREATE TABLE ShowTimes --Sử dụng Procedure để nhập!
(
	ShowTimeID INT IDENTITY(1,1) PRIMARY KEY,
	MovieID VARCHAR(6) NOT NULL,
	ShiftID INT DEFAULT 1 NOT NULL,
	RoomID VARCHAR(6) NOT NULL,
	Date DATE NOT NULL,
	EndTime TIME,
)

CREATE TABLE MovieType
(
	MovieTypeID VARCHAR(2) PRIMARY KEY,
	MovieTypeName NVARCHAR(20) UNIQUE NOT NULL,
)
--INSERT INTO dbo.MovieType (MovieTypeID, MovieTypeName) VALUES ('2D', N'2D');
--INSERT INTO dbo.MovieType (MovieTypeID, MovieTypeName) VALUES ('3D', N'3D');
--INSERT INTO dbo.MovieType (MovieTypeID, MovieTypeName) VALUES ('LT', N'Lồng tiếng');
--INSERT INTO dbo.MovieType (MovieTypeID, MovieTypeName) VALUES ('TM', N'Thuyết minh');
--INSERT INTO dbo.MovieType (MovieTypeID, MovieTypeName) VALUES ('VS', N'VietSub');
--INSERT INTO dbo.MovieType (MovieTypeID, MovieTypeName) VALUES ('ES', N'EngSub');
--SELECT * FROM dbo.MovieType

CREATE TABLE Category
(
	CategoryID VARCHAR(4) PRIMARY KEY,
	CategoryName NVARCHAR(20) UNIQUE NOT NULL,
)
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Come', N'Hài kịch');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('SiFi', N'Khoa học viễn tưởng');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Horr', N'Kinh dị');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Acti', N'Hành động');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Wars', N'Chiến tranh');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Roma', N'Lãng mạng');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Musi', N'Ca nhạc');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Anim', N'Hoạt hình');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Crim', N'Tội phạm');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Hist', N'Lịch sử');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Spor', N'Thể thao');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('West', N'Viễn tây');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('His2', N'Cổ trang'); --Historical
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Wuxi', N'Kiếm hiệp'); --Muxia
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Adve', N'Phiêu lưu');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Myst', N'Bí ẩn');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Thri', N'Giật gân');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Fant', N'Kì ảo');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Dram', N'Drama');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Erot', N'Khiêu dâm'); --Erotic
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Docu', N'Tài liệu');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Scie', N'Khoa học');
--INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('Fami', N'Gia đình');
--SELECT * FROM dbo.Category;

CREATE TABLE Movie
(
	MovieID VARCHAR(6) PRIMARY KEY, --0
	Name NVARCHAR(50) NOT NULL, --1
	Director NVARCHAR(50) NOT NULL, --2
	Duration TIME NOT NULL, --3	
	ReleaseDay DATE NOT NULL, --4	
	Language NVARCHAR(20) NOT NULL, --5	
	MinAge INT NOT NULL, --6	 
	Rate NUMERIC(2,1) DEFAULT 0 NOT NULL, --0.0->5.0 --7
	Image NVARCHAR(MAX) NOT NULL, --8
	Status BIT DEFAULT 1 NOT NULL, --1: Trong thời gian công chiếu, 0: Không đc công chiếu --9
)

CREATE TABLE MovieOnType
(
	MovieID VARCHAR(6) NOT NULL,
	MovieTypeID VARCHAR(2) NOT NULL,
)
-----
CREATE TABLE MovieOnCat
(
	MovieID VARCHAR(6) NOT NULL,
	CategoryID VARCHAR(4) NOT NULL,
)

--CREATE TABLE TypicalActor
--(
--	MovieID VARCHAR(6) NOT NULL,
--	ActorName NVARCHAR(50) NOT NULL,
--)

CREATE TABLE SlotType
(
	SlotTypeID VARCHAR(3) PRIMARY KEY,
	SlotTypeName NVARCHAR(20) UNIQUE NOT NULL,
	Price NUMERIC(10,2) NOT NULL, --VND
)
--INSERT INTO dbo.SlotType (SlotTypeID, SlotTypeName, Price) VALUES ('NOR', N'Thường', 50000);
--INSERT INTO dbo.SlotType (SlotTypeID, SlotTypeName, Price) VALUES ('VIP', N'Vip', 100000);
--SELECT * FROM dbo.SlotType;


CREATE TABLE Slot
(
	SlotID VARCHAR(8) PRIMARY KEY,--RLT001A1
	SlotTypeID VARCHAR(3) NOT NULL,
	Row INT NOT NULL,
	Col CHAR(1) NOT NULL,
	Status INT NOT NULL, --1: Taken, 0: Empty, -1: Error
)
----RLT00X, RCG00X --X: 1->3
--DECLARE @x INT = 1;
--WHILE @x <= 3
--BEGIN
--    DECLARE @lt VARCHAR(6) = 'RLT00' + CONVERT(VARCHAR(1), @x);
--	DECLARE @cg VARCHAR(6) = 'RCG00' + CONVERT(VARCHAR(1), @x);
--	DECLARE @a INT = 65;
--	WHILE @a <= 70
--	BEGIN
--		DECLARE @i INT = 1;
--		DECLARE @Type VARCHAR(3);
--		WHILE @i <= 6
--		BEGIN
--			IF @i = 1
--			BEGIN
--				SET @Type = 'VIP'; 
--			END
--			ELSE
--			BEGIN
--			    SET @Type = 'NOR';
--			END
--		    INSERT INTO	dbo.Slot (SlotID,SlotTypeID,Row,Col,Status) VALUES (@lt + CHAR(@a) + CONVERT(VARCHAR(1),@i),@Type,@i, CHAR(@a), 0);
--			INSERT INTO	dbo.Slot (SlotID,SlotTypeID,Row,Col,Status) VALUES (@cg + CHAR(@a) + CONVERT(VARCHAR(1),@i),@Type,@i, CHAR(@a), 0);
--			INSERT INTO dbo.SlotInRoom (RoomID,SlotID) VALUES (@lt,@lt + CHAR(@a) + CONVERT(VARCHAR(1),@i));
--			INSERT INTO dbo.SlotInRoom (RoomID,SlotID) VALUES (@cg,@cg + CHAR(@a) + CONVERT(VARCHAR(1),@i));
--			SET @i = @i + 1;
--		END
--	SET @a = @a + 1
--	END
--	SET @x = @x + 1;
--END
--SELECT * FROM dbo.Slot;
--SELECT * FROM dbo.SlotInRoom;

CREATE TABLE SlotInRoom
(
	RoomID VARCHAR(6) NOT NULL,
	SlotID VARCHAR(8) NOT NULL,
)


CREATE TABLE Ticket
(
	TicketID VARCHAR(100) PRIMARY KEY,
	SlotID VARCHAR(8) NOT NULL,
	ShowTimeID INT NOT NULL,
)

CREATE TABLE Bill
(
	BillID VARCHAR(100) PRIMARY KEY, --orderId
	AccountID VARCHAR(100) NOT NULL,
	TotalPrice NUMERIC(10,2) DEFAULT 0 NOT NULL, --amount
	Date DATE NOT NULL,
	Time TIME NOT NULL,
	Status BIT NOT NULL, --1: Còn hiệu lực(chưa chiếu), 0: hết hiệu lực
	RequestID VARCHAR(100) UNIQUE NOT NULL, --requestId
	TransID VARCHAR(100) UNIQUE NOT NULL
)

CREATE TABLE TicketOnBill
(
	BillID VARCHAR(100) NOT NULL,
	TicketID VARCHAR(100) UNIQUE NOT NULL,
)

CREATE TABLE Role
(
	RoleID VARCHAR(2) PRIMARY KEY,
	RoleName NVARCHAR(20) NOT NULL,
	Priority INT NOT NULL, --Độ ưu tiên càng lớn quyền càng cao!
)
--INSERT INTO dbo.Role (RoleID, RoleName, Priority) VALUES ('KH', N'Khách hàng', 1);
--INSERT INTO dbo.Role (RoleID, RoleName, Priority) VALUES ('QL', N'Quản lý', 10);
--SELECT * FROM dbo.Role;


CREATE TABLE Account
(
	AccountID VARCHAR(100) PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50) UNIQUE NOT NULL,
	Phone NVARCHAR(11) UNIQUE NOT NULL,
	Password VARCHAR(MAX) NOT NULL,
	--Sex NVARCHAR(6) NOT NULL,--Male, Female, Other
	BirthDay DATE NOT NULL,
	RoleID VARCHAR(2) NOT NULL,
)

--CREATE	TABLE Comment
--(
--	CommentID VARCHAR(100) PRIMARY KEY,
--	AccountID VARCHAR(100) NOT NULL,
--	MovieID VARCHAR(6) NOT NULL,
--	Content NVARCHAR(MAX) NULL,
--	DateTime DATETIME DEFAULT GETDATE(),
--	Rate NUMERIC(2,1) NULL,
--)

GO
---------------------------------------------
---Constraint--
--Cinema
--RoomInCinema
ALTER TABLE dbo.RoomInCinema ADD CONSTRAINT FK_RoomInCinema_Cinema FOREIGN KEY (CinemaID) REFERENCES dbo.Cinema(CinemaID);
ALTER TABLE dbo.RoomInCinema ADD CONSTRAINT FK_RoomInCinema_Room FOREIGN KEY (RoomID) REFERENCES dbo.Room(RoomID);
ALTER TABLE dbo.RoomInCinema ADD CONSTRAINT PK_RoomInCinema	PRIMARY KEY (CinemaID,RoomID);
GO
--Room
--ALTER TABLE	dbo.Room ADD CONSTRAINT FK_Room_RoomType FOREIGN KEY (RoomTypeID) REFERENCES dbo.RoomType(RoomTypeID);
ALTER TABLE dbo.Room ADD CONSTRAINT Check_Status CHECK (Status IN ('Full', 'Available', 'Maintenance')); 
GO
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

	DECLARE @NewRoom NVARCHAR(6);
	SELECT @NewRoom = Inserted.RoomID FROM Inserted;

	DECLARE @Dur TIME; --Lấy thời lượng phim
	SELECT @Dur = Duration FROM dbo.Movie WHERE MovieID IN (SELECT MovieID FROM Inserted);

	DECLARE @Last_EndTime TIME; --EndTime trước đó
	SELECT TOP 1 @Last_EndTime = EndTime FROM dbo.ShowTimes WHERE Date = @NewDate AND RoomID = @NewRoom ORDER BY EndTime DESC;
	IF @Last_EndTime IS NULL
	BEGIN
	    SET @Last_EndTime = '08:00:00';
	END
	SET @Last_EndTime =  DATEADD(mi, 30, @Last_EndTime) --+30p để chuẩn bị phòng

	DECLARE @Shift INT; --Last Shift
	SELECT TOP 1 @Shift = ShiftID FROM dbo.ShowTimes WHERE Date = @NewDate AND RoomID = @NewRoom ORDER BY ShiftID DESC;

	DECLARE @ShiftTime TIME; --Time of @Shift
	SELECT @ShiftTime = Time FROM dbo.Shifts WHERE ShiftID = @Shift;


	IF @Last_EndTime > '22:30:00' --đảm bảo không chiếu quá trễ
	BEGIN
		PRINT N'Số lượng ca chiếu hôm nay đã đạt mức tối đa, vui lòng chuyển ca chiếu sang ngày hôm sau!'
		ROLLBACK TRAN
	END

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
	--END
END

--MovieType
--Category
--Movie
GO
ALTER TABLE dbo.Movie ADD CONSTRAINT Check_Rate CHECK (Rate BETWEEN 0.0 AND 5.0);
--MovieOnType
GO 
ALTER TABLE dbo.MovieOnType ADD CONSTRAINT FK_MovieOnType_Moive FOREIGN KEY (MovieID) REFERENCES Movie(MovieID);
ALTER TABLE dbo.MovieOnType ADD CONSTRAINT FK_MovieOnType_MovieType FOREIGN KEY (MovieTypeID) REFERENCES dbo.MovieType(MovieTypeID);
ALTER TABLE dbo.MovieOnType ADD	CONSTRAINT PK_MovieOnType PRIMARY KEY (MovieID,MovieTypeID);

--MovieOnCat
GO
ALTER TABLE dbo.MovieOnCat ADD CONSTRAINT FK_MovieOnCat_Moive FOREIGN KEY (MovieID) REFERENCES Movie(MovieID);
ALTER TABLE dbo.MovieOnCat ADD CONSTRAINT FK_MovieOnCat_Category FOREIGN KEY (CategoryID) REFERENCES dbo.Category(CategoryID);
ALTER TABLE dbo.MovieOnCat ADD CONSTRAINT PK_MovieOnCat PRIMARY KEY (MovieID,CategoryID);

----TypicalActor
--GO
--ALTER TABLE dbo.TypicalActor ADD CONSTRAINT FK_TypicalActor_Movie FOREIGN KEY (MovieID) REFERENCES dbo.Movie(MovieID);
--ALTER TABLE dbo.TypicalActor ADD CONSTRAINT PK_TypicalActor PRIMARY KEY (MovieID,ActorName);

--SlotType
--Slot
GO
ALTER TABLE dbo.Slot ADD CONSTRAINT FK_Slot_SlotType FOREIGN KEY (SlotTypeID) REFERENCES dbo.SlotType(SlotTypeID);

--SlotInRoom
GO
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
FOR DELETE
AS 
BEGIN
    DECLARE @maxSlot INT;
	SELECT @maxSlot = COUNT(SlotID) FROM dbo.SlotInRoom WHERE RoomID IN (SELECT RoomID FROM Deleted);
	UPDATE dbo.Room SET MaxSlot = @maxSlot WHERE RoomID IN (SELECT RoomID FROM Deleted);
END

--Ticket
GO
ALTER TABLE dbo.Ticket ADD CONSTRAINT FK_Ticket_Slot FOREIGN KEY (SlotID) REFERENCES dbo.Slot(SlotID);
ALTER TABLE dbo.Ticket ADD CONSTRAINT FK_Ticket_ShowTimes FOREIGN KEY (ShowTimeID) REFERENCES dbo.ShowTimes(ShowTimeID);

--Bill
GO
ALTER TABLE dbo.Bill ADD CONSTRAINT FK_Bill_Account FOREIGN KEY (AccountID) REFERENCES dbo.Account(AccountID);
ALTER TABLE dbo.Bill ADD CONSTRAINT Default_Date DEFAULT GETDATE() FOR Date;
ALTER TABLE dbo.Bill ADD CONSTRAINT Default_Time DEFAULT GETDATE() FOR Time;
ALTER TABLE dbo.Bill ADD CONSTRAINT Default_Status DEFAULT 1 FOR Status;


--TicketOnBill
GO
ALTER TABLE dbo.TicketOnBill ADD CONSTRAINT FK_TicketOnBill_Bill FOREIGN KEY (BillID) REFERENCES dbo.Bill(BillID);
ALTER TABLE dbo.TicketOnBill ADD CONSTRAINT FK_TicketOnBill_Ticket FOREIGN KEY (TicketID) REFERENCES dbo.Ticket(TicketID);

GO
CREATE TRIGGER Trig_TicketOnBill_Insert ON dbo.TicketOnBill
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @Total NUMERIC(10,2);

	SELECT @Total = SUM(SlotType.Price) FROM ((dbo.TicketOnBill TB JOIN dbo.Ticket T ON T.TicketID = TB.TicketID)
	JOIN dbo.Slot ON T.SlotID = Slot.SlotID) JOIN dbo.SlotType ON SlotType.SlotTypeID = Slot.SlotTypeID

	UPDATE dbo.Bill SET	TotalPrice = @Total WHERE BillID IN (SELECT BillID FROM Inserted);

END
GO
CREATE TRIGGER Trig_TicketOnBill_Delete ON dbo.TicketOnBill
FOR DELETE
AS
BEGIN
	DELETE FROM dbo.Ticket WHERE TicketID IN (SELECT TicketID FROM Deleted);

	DECLARE @Total NUMERIC(10,2);
	SELECT @Total = SUM(SlotType.Price) FROM ((dbo.TicketOnBill TB JOIN dbo.Ticket T ON T.TicketID = TB.TicketID)
	JOIN dbo.Slot ON t.SlotID = Slot.SlotID) JOIN dbo.SlotType ON SlotType.SlotTypeID = Slot.SlotTypeID
	WHERE TB.BillID IN (SELECT TOP 1 BillID FROM Deleted); 

	IF @Total IS NULL
	BEGIN
	    SET @Total = 0;
	END
	UPDATE dbo.Bill SET	TotalPrice = @Total WHERE BillID IN (SELECT BillID FROM Deleted);
END
--Role
--Account
GO
ALTER TABLE dbo.Account ADD CONSTRAINT FK_Account_Role FOREIGN KEY (RoleID) REFERENCES Role(RoleID);
--ALTER TABLE dbo.Account ADD CONSTRAINT Check_Sex CHECK (Sex IN('Male', 'Female', 'Other'));
ALTER TABLE dbo.Account ADD CONSTRAINT DefaultRole DEFAULT 'KH' FOR RoleID;

--Comment
GO
--ALTER TABLE dbo.Comment ADD CONSTRAINT FK_Comment_Account FOREIGN KEY (AccountID) REFERENCES dbo.Account(AccountID);
--ALTER TABLE dbo.Comment ADD CONSTRAINT FK_Comment_Movie FOREIGN KEY (MovieID) REFERENCES dbo.Movie(MovieID);
--ALTER TABLE dbo.Comment ADD CONSTRAINT Check_Comment_Rate CHECK (Rate BETWEEN 0.0 AND 5.0);
--GO
--CREATE TRIGGER Trig_Comment_Insert ON dbo.Comment
--FOR INSERT, UPDATE
--AS
--BEGIN
--    IF EXISTS
--	(SELECT * FROM Inserted WHERE ((Inserted.Content IS NULL) AND (Inserted.Rate IS NULL)))
--	BEGIN
--	    PRINT N'Bình luận không hợp lệ'
--		ROLLBACK TRAN;
--	END

--	DECLARE @avgRate NUMERIC(2,1);
--	SELECT @avgRate = AVG(Rate) FROM dbo.Comment WHERE MovieID IN (SELECT MovieID FROM Inserted);
--	UPDATE dbo.Movie SET Rate = @avgRate WHERE MovieID IN (SELECT MovieID FROM Inserted);
--END
--GO
--CREATE TRIGGER Trig_Comment_Delete ON dbo.Comment
--FOR DELETE
--AS
--BEGIN
--	DECLARE @avgRate NUMERIC(2,1);
--	SELECT @avgRate = AVG(Rate) FROM dbo.Comment WHERE MovieID IN (SELECT MovieID FROM Deleted);
--	UPDATE dbo.Movie SET Rate = @avgRate WHERE MovieID IN (SELECT MovieID FROM Deleted);
--END
--GO

-------DATA-----------
---Cinema---
INSERT INTO dbo.Cinema(CinemaID,CinemaName,LocationCode,Address,Note) VALUES ('LT001',N'Lập trình', 'HCM', N'12 đường Lê Thánh Tông','Coding...');
INSERT INTO dbo.Cinema(CinemaID,CinemaName,LocationCode,Address,Note) VALUES ('CG001',N'Mạng máy tính', 'HCM', N'13 đường Trần Thánh Tông','Catching data segment...');
SELECT * FROM dbo.Cinema;
GO	
---Shifts---
DECLARE @time TIME = '09:00:00';
DECLARE @id INT = 1;
WHILE @time <= '22:30:00'
BEGIN
    INSERT INTO dbo.Shifts VALUES (@id,@time);
	SET @time = DATEADD(mi,15,@time);
	SET @id = @id + 1;
END
SELECT * FROM dbo.Shifts;
GO	
---MovieType---
INSERT INTO dbo.MovieType (MovieTypeID, MovieTypeName) VALUES ('2D', N'2D');
INSERT INTO dbo.MovieType (MovieTypeID, MovieTypeName) VALUES ('3D', N'3D');
INSERT INTO dbo.MovieType (MovieTypeID, MovieTypeName) VALUES ('LT', N'Lồng tiếng');
INSERT INTO dbo.MovieType (MovieTypeID, MovieTypeName) VALUES ('TM', N'Thuyết minh');
INSERT INTO dbo.MovieType (MovieTypeID, MovieTypeName) VALUES ('VS', N'VietSub');
INSERT INTO dbo.MovieType (MovieTypeID, MovieTypeName) VALUES ('ES', N'EngSub');
SELECT * FROM dbo.MovieType
GO	
---Category---
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('COME', N'Hài kịch');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('SIFI', N'Khoa học viễn tưởng');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('HORR', N'Kinh dị');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('ACTI', N'Hành động');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('WARS', N'Chiến tranh');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('ROMA', N'Lãng mạng');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('MUSI', N'Ca nhạc');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('ANIM', N'Hoạt hình');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('CRIM', N'Tội phạm');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('HIST', N'Lịch sử');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('SPOR', N'Thể thao');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('WEST', N'Viễn tây');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('HIS2', N'Cổ trang'); --Historical
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('WUXI', N'Kiếm hiệp'); --Muxia
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('ADVE', N'Phiêu lưu');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('MYST', N'Bí ẩn');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('THRI', N'Giật gân');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('FANT', N'Kì ảo');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('DRAM', N'Drama');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('EROT', N'Khiêu dâm'); --Erotic
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('DOCU', N'Tài liệu');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('SCIE', N'Khoa học');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('FAMI', N'Gia đình');
INSERT INTO dbo.Category (CategoryID, CategoryName) VALUES ('PSYC', N'Tâm lý');
SELECT * FROM dbo.Category;
GO	
---Role---
INSERT INTO dbo.Role (RoleID, RoleName, Priority) VALUES ('KH', N'Khách hàng', 1);
INSERT INTO dbo.Role (RoleID, RoleName, Priority) VALUES ('QL', N'Quản lý', 10);
SELECT * FROM dbo.Role;
GO	
---SlotType---
INSERT INTO dbo.SlotType (SlotTypeID, SlotTypeName, Price) VALUES ('NOR', N'Thường', 50000);
INSERT INTO dbo.SlotType (SlotTypeID, SlotTypeName, Price) VALUES ('VIP', N'Vip', 100000);
SELECT * FROM dbo.SlotType;
GO	
---Room + RoomInCinema---
INSERT INTO dbo.Room (RoomID,RoomName,Status) VALUES ('RLT001','Phòng Lotte 1','Available');
INSERT INTO dbo.Room (RoomID,RoomName,Status) VALUES ('RLT002','Phòng Lotte 2','Available');
INSERT INTO dbo.Room (RoomID,RoomName,Status) VALUES ('RLT003','Phòng Lotte 3','Available');
INSERT INTO dbo.Room (RoomID,RoomName,Status) VALUES ('RCG001','Phòng CGV 1','Available');
INSERT INTO dbo.Room (RoomID,RoomName,Status) VALUES ('RCG002','Phòng CGV 2','Available');
INSERT INTO dbo.Room (RoomID,RoomName,Status) VALUES ('RCG003','Phòng CGV 3','Available');
SELECT * FROM dbo.Room;
INSERT INTO dbo.RoomIncinema (CinemaID,RoomID) VALUES ('LT001','RLT001');
INSERT INTO dbo.RoomIncinema (CinemaID,RoomID) VALUES ('LT001','RLT002');
INSERT INTO dbo.RoomIncinema (CinemaID,RoomID) VALUES ('LT001','RLT003');
INSERT INTO dbo.RoomIncinema (CinemaID,RoomID) VALUES ('CG001','RCG001');
INSERT INTO dbo.RoomIncinema (CinemaID,RoomID) VALUES ('CG001','RCG002');
INSERT INTO dbo.RoomIncinema (CinemaID,RoomID) VALUES ('CG001','RCG003');
SELECT * FROM dbo.RoomInCinema;
GO	
---Slot + SlotInRoom---
    --RLT00X, RCG00X --X: 1->3
DECLARE @x INT = 1;
WHILE @x <= 3
BEGIN
    DECLARE @lt VARCHAR(6) = 'RLT00' + CONVERT(VARCHAR(1), @x);
	DECLARE @cg VARCHAR(6) = 'RCG00' + CONVERT(VARCHAR(1), @x);
	DECLARE @a INT = 65;
	WHILE @a <= 70
	BEGIN
		DECLARE @i INT = 1;
		DECLARE @Type VARCHAR(3);
		WHILE @i <= 6
		BEGIN
			IF @i = 1
			BEGIN
				SET @Type = 'VIP'; 
			END
			ELSE
			BEGIN
			    SET @Type = 'NOR';
			END
		    INSERT INTO	dbo.Slot (SlotID,SlotTypeID,Row,Col,Status) VALUES (@lt + CHAR(@a) + CONVERT(VARCHAR(1),@i),@Type,@i, CHAR(@a), 0);
			INSERT INTO	dbo.Slot (SlotID,SlotTypeID,Row,Col,Status) VALUES (@cg + CHAR(@a) + CONVERT(VARCHAR(1),@i),@Type,@i, CHAR(@a), 0);
			INSERT INTO dbo.SlotInRoom (RoomID,SlotID) VALUES (@lt,@lt + CHAR(@a) + CONVERT(VARCHAR(1),@i));
			INSERT INTO dbo.SlotInRoom (RoomID,SlotID) VALUES (@cg,@cg + CHAR(@a) + CONVERT(VARCHAR(1),@i));
			SET @i = @i + 1;
		END
	SET @a = @a + 1
	END
	SET @x = @x + 1;
END
SELECT * FROM dbo.Slot;
SELECT * FROM dbo.SlotInRoom;
GO
--Movie
INSERT INTO dbo.Movie (MovieID, Name, Director, Duration, ReleaseDay, Language, MinAge, Rate, Image, Status) VALUES ('404CND',N'404 – Chạy ngay đi','Pichaya Jarusboonpracha','1:44:00','2024-12-27',N'Tiếng Thái',16,0,'https://iguov8nhvyobj.vcdn.cloud/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/3/5/350x495-404.jpg',1);
INSERT INTO dbo.Movie (MovieID, Name, Director, Duration, ReleaseDay, Language, MinAge, Rate, Image, Status) VALUES ('SONIC3',N'Nhím Sonic 3','Jeff Fowler','1:50:00','2024-12-27',N'Tiếng Anh',0,0,'https://iguov8nhvyobj.vcdn.cloud/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/s/t/sth3_poster_470x700.jpg',1);
INSERT INTO dbo.Movie (MovieID, Name, Director, Duration, ReleaseDay, Language, MinAge, Rate, Image, Status) VALUES ('VUAST',N'MUFASA: Vua sử tử','Barry Jenkins','1:58:00','2024-12-18',N'Tiếng Anh',0,0,'https://iguov8nhvyobj.vcdn.cloud/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/c/g/cgv_350x495_1_.jpg',1);
INSERT INTO dbo.Movie (MovieID, Name, Director, Duration, ReleaseDay, Language, MinAge, Rate, Image, Status) VALUES ('LDBCPS',N'LÂU ĐÀI BAY CỦA PHÁP SƯ HOWL','Hayao Miyazaki','2:00:00','2024-12-27',N'Tiếng Nhật',0,0,'https://iguov8nhvyobj.vcdn.cloud/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/h/o/howls-moving-castle---poster-01_1_.jpg',1);
INSERT INTO dbo.Movie (MovieID, Name, Director, Duration, ReleaseDay, Language, MinAge, Rate, Image, Status) VALUES ('CNBX',N'CHUYỆN NHÀ BÁNH XẾP','YANG Woo-seok','1:46:00','2024-12-27',N'Tiếng Hàn',0,0,'https://iguov8nhvyobj.vcdn.cloud/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/3/5/350x495-aboutfamily.jpg',1);
INSERT INTO dbo.Movie (MovieID, Name, Director, Duration, ReleaseDay, Language, MinAge, Rate, Image, Status) VALUES ('BDTH',N'BIỆT ĐỘI TÍ HON','Ute von Münchow-Pohl','1:16:00','2024-12-24',N'Lồng Tiếng Việt',0,0,'https://iguov8nhvyobj.vcdn.cloud/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/b/i/bi_t_i_t_hon-payoff_poster-kc_24.12.2024.jpg',1);
INSERT INTO dbo.Movie (MovieID, Name, Director, Duration, ReleaseDay, Language, MinAge, Rate, Image, Status) VALUES ('MOANA2',N'HÀNH TRÌNH CỦA MOANA 2','David G. Derrick Jr.','1:39:00','2024-12-4',N'Tiếng Anh',0,0,'https://iguov8nhvyobj.vcdn.cloud/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/c/g/cgv_1200x1800.jpg',1);
INSERT INTO dbo.Movie (MovieID, Name, Director, Duration, ReleaseDay, Language, MinAge, Rate, Image, Status) VALUES ('KVH',N'KÍNH VẠN HOA',N'Võ Thanh Hòa','2:07:00','2024-12-24',N'Tiếng Việt',0,0,'https://iguov8nhvyobj.vcdn.cloud/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/3/5/350x495-kvh.jpg',1);
INSERT INTO dbo.Movie (MovieID, Name, Director, Duration, ReleaseDay, Language, MinAge, Rate, Image, Status) VALUES ('CTBL',N'CÔNG TỬ BẠC LIÊU',N'Lý Minh Thắng','1:53:00','2024-12-6',N'Tiếng Việt',0,0,'https://iguov8nhvyobj.vcdn.cloud/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/c/_/c_ng_t_b_c_li_u_-_payoff_poster_-_kc_06.12.2024_1_.jpg',1);
INSERT INTO dbo.Movie (MovieID, Name, Director, Duration, ReleaseDay, Language, MinAge, Rate, Image, Status) VALUES ('LM',N'LINH MIÊU',N'Lưu Thành Luân','1:49:00','2024-11-22',N'Tiếng Việt',0,0,'https://iguov8nhvyobj.vcdn.cloud/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/3/5/350x495-linhmieu.jpg',1);
INSERT INTO dbo.Movie (MovieID, Name, Director, Duration, ReleaseDay, Language, MinAge, Rate, Image, Status) VALUES ('KRAVEN',N'KRAVEN - THỢ SĂN THỦ LĨNH','J. C. Chandor','2:07:00','2024-12-13',N'Tiếng Anh',0,0,'https://iguov8nhvyobj.vcdn.cloud/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/3/5/350x495-kraven.jpg',1);
SELECT * FROM dbo.Movie;
---MovieOnCat---
INSERT INTO dbo.MovieOnCat (MovieID, CategoryID) VALUES ('404CND', 'HORR');
INSERT INTO dbo.MovieOnCat (MovieID, CategoryID) VALUES ('SONIC3', 'ACTI');
INSERT INTO dbo.MovieOnCat (MovieID, CategoryID) VALUES ('VUAST', 'ANIM');
INSERT INTO dbo.MovieOnCat (MovieID, CategoryID) VALUES ('LDBCPS', 'ANIM');
INSERT INTO dbo.MovieOnCat (MovieID, CategoryID) VALUES ('CNBX', 'COME');
INSERT INTO dbo.MovieOnCat (MovieID, CategoryID) VALUES ('BDTH', 'ANIM');
INSERT INTO dbo.MovieOnCat (MovieID, CategoryID) VALUES ('MOANA2', 'ANIM');
INSERT INTO dbo.MovieOnCat (MovieID, CategoryID) VALUES ('KVH', 'ADVE');
INSERT INTO dbo.MovieOnCat (MovieID, CategoryID) VALUES ('CTBL', 'PSYC');
INSERT INTO dbo.MovieOnCat (MovieID, CategoryID) VALUES ('LM', 'HORR');
INSERT INTO dbo.MovieOnCat (MovieID, CategoryID) VALUES ('KRAVEN', 'ACTI');
SELECT * FROM dbo.MovieOnCat;

---MovieOntype---
INSERT INTO dbo.MovieOnType (MovieID, MovieTypeID) VALUES ('CHIDAU','VS');
INSERT INTO dbo.MovieOnType (MovieID, MovieTypeID) VALUES ('404CND','TM');
INSERT INTO dbo.MovieOnType (MovieID, MovieTypeID) VALUES ('SONIC3','VS');
INSERT INTO dbo.MovieOnType (MovieID, MovieTypeID) VALUES ('VUAST','VS');
INSERT INTO dbo.MovieOnType (MovieID, MovieTypeID) VALUES ('LDBCPS','VS');
INSERT INTO dbo.MovieOnType (MovieID, MovieTypeID) VALUES ('CNBX','VS');
INSERT INTO dbo.MovieOnType (MovieID, MovieTypeID) VALUES ('BDTH','LT');
INSERT INTO dbo.MovieOnType (MovieID, MovieTypeID) VALUES ('MOANA2','LT');
INSERT INTO dbo.MovieOnType (MovieID, MovieTypeID) VALUES ('KVH','2D');
SELECT * FROM dbo.MovieOnType;

GO
-------------------------------------------------------------------------------------------------------------
CREATE PROC Pro_Purchase
@Bill VARCHAR(100), @RequestID VARCHAR(100),@TransID VARCHAR(100), @Ticket VARCHAR(100), @Account VARCHAR(100)
AS
BEGIN
	BEGIN TRANSACTION
	SAVE TRANSACTION CP0
	BEGIN TRY
		IF NOT EXISTS 
		(SELECT TOP 1 BillID FROM dbo.Bill WHERE BillID = @Bill)
		BEGIN
		    INSERT INTO dbo.Bill (BillID,AccountID,TotalPrice,Date,Time,Status,RequestID, TransID) VALUES 
			(@Bill, @Account, DEFAULT, DEFAULT, DEFAULT, DEFAULT,  @RequestID, @TransID);
		END
		INSERT INTO dbo.TicketOnBill (BillID, TicketID) VALUES (@Bill, @Ticket);
		COMMIT TRANSACTION;
		RETURN;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		BEGIN TRY
		DELETE FROM dbo.Ticket WHERE TicketID = @Ticket;
		END TRY
		BEGIN CATCH
		END CATCH
		RETURN;
	END CATCH
END

GO
CREATE PROC Proc_DeleleBill
@BillID VARCHAR(100)
AS
BEGIN
  BEGIN TRANSACTION
  SAVE TRANSACTION CP0
  BEGIN TRY
	 DELETE FROM dbo.TicketOnBill WHERE BillID = @BillID;
	 DELETE FROM dbo.Bill WHERE BillID = @BillID;
	 COMMIT TRANSACTION CP0;
	 RETURN;
  END TRY
  BEGIN CATCH
	ROLLBACK TRANSACTION CP0;
	RETURN;
  END CATCH
END

GO
--------------------------------------------------------------------------------------------------

