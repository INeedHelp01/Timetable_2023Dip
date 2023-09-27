CREATE TABLE subject (
  subjectID VARCHAR(10) NOT NULL,
  subjectName VARCHAR(45) NOT NULL,
  PRIMARY KEY (subjectID)
);

CREATE TABLE lecturer (
  lecturerID VARCHAR(10) NOT NULL,
  firstName VARCHAR(45) NOT NULL,
  lastName VARCHAR(45) NOT NULL,
  PRIMARY KEY (lecturerID)
);

CREATE TABLE room (
  roomID VARCHAR(10) NOT NULL,
  roomName VARCHAR(45) NOT NULL,
  PRIMARY KEY (roomID)
);