CREATE TABLE subject (
  subject_id INT NOT NULL AUTO_INCREMENT,
  subject_name VARCHAR(255) NOT NULL,
  PRIMARY KEY (subject_id)
);

CREATE TABLE lecturer (
  lecturer_id INT NOT NULL AUTO_INCREMENT,
  lecturer_name VARCHAR(255) NOT NULL,
  PRIMARY KEY (lecturer_id)
);

CREATE TABLE room (
  room_id INT NOT NULL AUTO_INCREMENT,
  room_name VARCHAR(255) NOT NULL,
  PRIMARY KEY (room_id)
);