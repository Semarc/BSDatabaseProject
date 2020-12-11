DROP DATABASE IF EXISTS DnDUtilities;

CREATE DATABASE DnDUtilities;

USE DnDUtilities;

CREATE TABLE Voelker(
  Volkname  VARCHAR(30) PRIMARY KEY
);

CREATE TABLE Nachnamen(
  Volkname  VARCHAR(30),
  Name  VARCHAR(50),
  CONSTRAINT FK_VoelkerNachnamen
    FOREIGN KEY (Volkname) REFERENCES Voelker (Volkname)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

CREATE TABLE Vornamen(
  Volkname  VARCHAR(30),
  Name  VARCHAR(50),
  Geschlecht ENUM('M','W'),
  CONSTRAINT FK_VoelkerVornamen
    FOREIGN KEY (Volkname) REFERENCES Voelker (Volkname)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);