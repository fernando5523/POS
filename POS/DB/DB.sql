USE RetailPOS;
GO

CREATE TABLE dbo.Users ( 
	Id                   int NOT NULL   IDENTITY,
	Name                 varchar(50) NOT NULL   ,
	Password             varchar(30) NOT NULL   ,
	Active               bit NOT NULL   ,
	UserID               int    ,
	CONSTRAINT Pk_User_Id PRIMARY KEY  ( Id ),
	CONSTRAINT Idx_Users_Name UNIQUE ( Name ) 
 );

CREATE  INDEX Idx_User_IdUser ON dbo.Users ( UserID );

ALTER TABLE dbo.Users ADD CONSTRAINT Fk_Users_Users FOREIGN KEY ( UserID ) REFERENCES dbo.Users( Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

CREATE TABLE dbo.Images ( 
	Id                   int NOT NULL   IDENTITY,
	Name                 varchar(100) NOT NULL   ,
	Chain                nvarchar(max) NOT NULL   ,
	CONSTRAINT Pk_Image_Id PRIMARY KEY  ( Id ),
	CONSTRAINT Idx_Images_Name UNIQUE ( Name ) 
 );

CREATE TABLE dbo.Controls ( 
	Id                   int NOT NULL   IDENTITY,
	Code                 varchar(20) NOT NULL   ,
	Name                 varchar(50) NOT NULL   ,
	Active               bit NOT NULL   ,
	CONSTRAINT Pk_Control_Id PRIMARY KEY  ( Id ),
	CONSTRAINT Idx_Controls_Code UNIQUE ( Code ) 
 );

CREATE TABLE dbo.Containers ( 
	Id                   int NOT NULL   IDENTITY,
	ContainerID          int    ,
	ImageID              int    ,
	ControlID            int    ,
	Code                 varchar(20) NOT NULL   ,
	Name                 varchar(50) NOT NULL   ,
	Description          varchar(200)    ,
	Level                int NOT NULL   ,
	Form                 varchar(max)    ,
	Sort                 int NOT NULL   ,
	IsView               bit NOT NULL   ,
	Active               bit NOT NULL   ,
	UserID               int NOT NULL   ,
	CONSTRAINT Pk_Container_Id PRIMARY KEY  ( Id ),
	CONSTRAINT Idx_Containers_Code UNIQUE ( Code ) 
 );

CREATE  INDEX Idx_Container_IdUser ON dbo.Containers ( UserID );

CREATE  INDEX Idx_Containers_IdContainer ON dbo.Containers ( ContainerID );

CREATE  INDEX Idx_Containers_IdImage ON dbo.Containers ( ImageID );

CREATE  INDEX Idx_Containers_IdControl ON dbo.Containers ( ControlID );

ALTER TABLE dbo.Containers ADD CONSTRAINT Fk_Container_User FOREIGN KEY ( UserID ) REFERENCES dbo.Users( Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE dbo.Containers ADD CONSTRAINT Fk_Containers_Containers FOREIGN KEY ( ContainerID ) REFERENCES dbo.Containers( Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE dbo.Containers ADD CONSTRAINT Fk_Containers_Image FOREIGN KEY ( ImageID ) REFERENCES dbo.Images( Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE dbo.Containers ADD CONSTRAINT Fk_Containers_Control FOREIGN KEY ( ControlID ) REFERENCES dbo.Controls( Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

CREATE TABLE dbo.Codings ( 
	Id                   int NOT NULL   IDENTITY,
	ContainerID          int NOT NULL   ,
	Text                 varchar(20)    ,
	Number               int NOT NULL   ,
	NumberLength         int NOT NULL   ,
	Active               bit NOT NULL   ,
	UserID               int NOT NULL   ,
	CONSTRAINT Pk_Coding_Id PRIMARY KEY  ( Id )
 );

CREATE  INDEX Idx_Coding_IdUser ON dbo.Codings ( UserID );

CREATE  INDEX Idx_Codings_Entity ON dbo.Codings ( ContainerID );

ALTER TABLE dbo.Codings ADD CONSTRAINT Fk_Coding_User FOREIGN KEY ( UserID ) REFERENCES dbo.Users( Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE dbo.Codings ADD CONSTRAINT Fk_Codings_Containers FOREIGN KEY ( ContainerID ) REFERENCES dbo.Containers( Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;
 
CREATE TABLE dbo.Consults ( 
	Id                   int NOT NULL   IDENTITY,
	ContainerID          int NOT NULL   ,
	Principal            bit NOT NULL   ,
	[Select]             nvarchar(max) NOT NULL   ,
	[From]               nvarchar(max) NOT NULL   ,
	[Where]              nvarchar(max)    ,
	GroupBy              nvarchar(max)    ,
	[Having]             nvarchar(max)    ,
	OrderBy              nvarchar(max)    ,
	UserID               int    ,
	CONSTRAINT Pk_Consult_Id PRIMARY KEY  ( Id )
 );

CREATE  INDEX Idx_Consult_IdContainer ON dbo.Consults ( ContainerID );

CREATE  INDEX Idx_Consult_IdUser ON dbo.Consults ( UserID );

ALTER TABLE dbo.Consults ADD CONSTRAINT Fk_Consult_Container FOREIGN KEY ( ContainerID ) REFERENCES dbo.Containers( Id ) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE dbo.Consults ADD CONSTRAINT Fk_Consult_User FOREIGN KEY ( UserID ) REFERENCES dbo.Users( Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

CREATE TABLE dbo.Filters ( 
	Id                   int NOT NULL   IDENTITY,
	UserID               int NOT NULL   ,
	ConsultID            int NOT NULL   ,
	Condition            varchar(max)    ,
	ConditionDev         varchar(max)    ,
	CONSTRAINT Pk_Filtro_Id PRIMARY KEY  ( Id ),
	CONSTRAINT Idx_Filter_IdUser UNIQUE ( UserID ) 
 );

CREATE  INDEX Idx_Filter_IdConsult ON dbo.Filters ( ConsultID );

ALTER TABLE dbo.Filters ADD CONSTRAINT Fk_Filter_Consult FOREIGN KEY ( ConsultID ) REFERENCES dbo.Consults( Id ) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE dbo.Filters ADD CONSTRAINT Fk_Filter_User FOREIGN KEY ( UserID ) REFERENCES dbo.Users( Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

CREATE TABLE dbo.Rols ( 
	Id                   int NOT NULL   IDENTITY,
	ContainerID          int NOT NULL   ,
	Name                 varchar(50) NOT NULL   ,
	Description          varchar(200) NOT NULL   ,
	[Create]             bit NOT NULL   ,
	[Read]               bit NOT NULL   ,
	[Update]             bit NOT NULL   ,
	[Delete]             bit NOT NULL   ,
	UserID               int NOT NULL   ,
	CONSTRAINT Pk_Rol_Id PRIMARY KEY  ( Id ),
	CONSTRAINT Idx_Rols_Name UNIQUE ( Name ) 
 );

CREATE  INDEX Idx_Rols_IdContainer ON dbo.Rols ( ContainerID );

CREATE  INDEX Idx_Rols_IdUser ON dbo.Rols ( UserID );

ALTER TABLE dbo.Rols ADD CONSTRAINT Fk_Rols_Containers FOREIGN KEY ( ContainerID ) REFERENCES dbo.Containers( Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE dbo.Rols ADD CONSTRAINT Fk_Rols_Users FOREIGN KEY ( UserID ) REFERENCES dbo.Users( Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

CREATE TABLE dbo.UsersRols ( 
	Id                   int NOT NULL   IDENTITY,
	UserID               int NOT NULL   ,
	RolID                int NOT NULL   ,
	CONSTRAINT Pk_UsersRols_Id PRIMARY KEY  ( Id )
 );

CREATE  INDEX Idx_UsersRols_IdUsers ON dbo.UsersRols ( UserID );

CREATE  INDEX Idx_UsersRols_IdRols ON dbo.UsersRols ( RolID );

ALTER TABLE dbo.UsersRols ADD CONSTRAINT Fk_UsersRols_Users FOREIGN KEY ( UserID ) REFERENCES dbo.Users( Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE dbo.UsersRols ADD CONSTRAINT Fk_UsersRols_Rols FOREIGN KEY ( RolID ) REFERENCES dbo.Rols( Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;