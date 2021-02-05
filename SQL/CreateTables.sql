DROP DATABASE IF EXISTS DnDUtilities;

CREATE DATABASE DnDUtilities;

USE DnDUtilities;



CREATE TABLE Voelker(
  Volkname  VARCHAR(30) PRIMARY KEY
);

CREATE TABLE Nachnamen(
  Volkname  VARCHAR(30) ,
  Name      VARCHAR(50) ,
  CONSTRAINT FK_VoelkerNachnamen
    FOREIGN KEY (Volkname) REFERENCES Voelker (Volkname)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

CREATE TABLE Vornamen(
  Volkname   VARCHAR(30)   ,
  Geschlecht ENUM('M','W') ,
  Name       VARCHAR(50)   ,
  CONSTRAINT FK_VoelkerVornamen
    FOREIGN KEY (Volkname) REFERENCES Voelker (Volkname)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);



--CREATE TABLE Loot(
--  Item_Id    INTEGER AUTO_INCREMENT ,
--  Typ        VARCHAR(100)           ,
--  Seltenheit VARCHAR(50 )           ,
--  Werte      VARCHAR(100)           ,
--  Name       VARCHAR(150)           ,
--  CONSTRAINT PK_Loot
--    PRIMARY KEY (Item_Id)
--);



CREATE TABLE Gegner(
  Gegner_Id    INTEGER AUTO_INCREMENT ,
  Typ        VARCHAR(40)              ,
  Name       VARCHAR(50)              ,
  Enviroment VARCHAR(100)             ,
  CR         INTEGER                  ,
  CONSTRAINT PK_Gegner
    PRIMARY KEY (Gegner_Id)
);