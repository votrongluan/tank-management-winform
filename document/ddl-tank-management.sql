USE master
GO
DROP DATABASE IF EXISTS TM
GO
CREATE DATABASE TM
GO
USE TM
GO

CREATE TABLE [Tank] (
	id int identity primary key,
	modelId int NOT NULL,
	manufactoryId int NOT NULL,
	unitId int NOT NULL,
)
GO
CREATE TABLE [Manufactory] (
	id int identity primary key,
	name nvarchar(50) NOT NULL,
	locationId int NOT NULL,
)
GO
CREATE TABLE [Location] (
	id int identity primary key,
	name nvarchar(50) NOT NULL,
)
GO
CREATE TABLE [Model] (
	id int identity primary key,
	weight int NOT NULL,
	maxSpeed int NOT NULL,
	detail nvarchar(255) NOT NULL,
	maxNoDriver int NOT NULL,
	ammoId int NOT NULL,
	price int NOT NULL,
	name nvarchar NOT NULL,
	shootingRange int NOT NULL,
)
GO
CREATE TABLE [Ammo] (
	id int identity primary key,
	name nvarchar(50) NOT NULL,
	price int NOT NULL,
	weight int NOT NULL,
)
GO
CREATE TABLE [Unit] (
	id int identity primary key,
	name nvarchar(50) NOT NULL,
	location nvarchar(50) NOT NULL,
)
GO
CREATE TABLE [Driver] (
	id int identity primary key,
	idCard char(12),
	name nvarchar(50) NOT NULL,
	phone nvarchar(10) NOT NULL,
	unitId integer NOT NULL,
)
GO
CREATE TABLE [History] (
	id int identity primary key,
	fromUnitId int NOT NULL,
	toUnitId int NOT NULL,
	tankId int NOT NULL,
	date date NOT NULL,
)
GO
CREATE TABLE [TankDriver] (
	id int identity primary key,
	tankId int NOT NULL,
	driverId int NOT NULL,
)
GO
CREATE TABLE [Role] (
	id int identity primary key,
	description char(2) NOT NULL,
)
GO
CREATE TABLE [User] (
	id int identity primary key,
	username varchar(20) NOT NULL,
	password varchar(20) NOT NULL,
	roleId int NOT NULL,
)
GO
ALTER TABLE [Tank] WITH CHECK ADD CONSTRAINT [Tank_fk0] FOREIGN KEY ([modelId]) REFERENCES [Model]([id])
ALTER TABLE [Tank] CHECK CONSTRAINT [Tank_fk0]
ALTER TABLE [Tank] WITH CHECK ADD CONSTRAINT [Tank_fk1] FOREIGN KEY ([manufactoryId]) REFERENCES [Manufactory]([id])
ALTER TABLE [Tank] CHECK CONSTRAINT [Tank_fk1]
ALTER TABLE [Tank] WITH CHECK ADD CONSTRAINT [Tank_fk2] FOREIGN KEY ([unitId]) REFERENCES [Unit]([id])
ALTER TABLE [Tank] CHECK CONSTRAINT [Tank_fk2]
ALTER TABLE [Manufactory] WITH CHECK ADD CONSTRAINT [Manufactory_fk0] FOREIGN KEY ([locationId]) REFERENCES [Location]([id])
ALTER TABLE [Manufactory] CHECK CONSTRAINT [Manufactory_fk0]
ALTER TABLE [Model] WITH CHECK ADD CONSTRAINT [Model_fk0] FOREIGN KEY ([ammoId]) REFERENCES [Ammo]([id])
ALTER TABLE [Model] CHECK CONSTRAINT [Model_fk0]
ALTER TABLE [Driver] WITH CHECK ADD CONSTRAINT [Driver_fk0] FOREIGN KEY ([unitId]) REFERENCES [Unit]([id])
ALTER TABLE [Driver] CHECK CONSTRAINT [Driver_fk0]
ALTER TABLE [History] WITH CHECK ADD CONSTRAINT [History_fk0] FOREIGN KEY ([fromUnitId]) REFERENCES [Unit]([id])
ALTER TABLE [History] CHECK CONSTRAINT [History_fk0]
ALTER TABLE [History] WITH CHECK ADD CONSTRAINT [History_fk1] FOREIGN KEY ([toUnitId]) REFERENCES [Unit]([id])
ALTER TABLE [History] CHECK CONSTRAINT [History_fk1]
ALTER TABLE [History] WITH CHECK ADD CONSTRAINT [History_fk2] FOREIGN KEY ([tankId]) REFERENCES [Tank]([id])
ALTER TABLE [History] CHECK CONSTRAINT [History_fk2]
ALTER TABLE [TankDriver] WITH CHECK ADD CONSTRAINT [TankDriver_fk0] FOREIGN KEY ([tankId]) REFERENCES [Tank]([id])
ALTER TABLE [TankDriver] CHECK CONSTRAINT [TankDriver_fk0]
ALTER TABLE [TankDriver] WITH CHECK ADD CONSTRAINT [TankDriver_fk1] FOREIGN KEY ([driverId]) REFERENCES [Driver]([id])
ALTER TABLE [User] WITH CHECK ADD CONSTRAINT [User_fk0] FOREIGN KEY ([roleId]) REFERENCES [Role]([id])

