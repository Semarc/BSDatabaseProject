DROP DATABASE DnDUtilities;

CREATE DATABASE DnDUtilities;

USE DnDUtilities;

CREATE TABLE Voelker(
  Volk_Id   INT auto_increment PRIMARY KEY,
  Volkname  VARCHAR(20)
);

CREATE TABLE Nachnamen(
  Volk_Id   INT,
  Name  VARCHAR(50),
  CONSTRAINT FK_VoelkerNachnamen
    FOREIGN KEY (Volk_Id) REFERENCES Voelker (Volk_Id)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

CREATE TABLE Vornamen(
  Volk_Id   INT,
  Name  VARCHAR(50),
  CONSTRAINT FK_VoelkerVornamen
    FOREIGN KEY (Volk_Id) REFERENCES Voelker (Volk_Id)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);