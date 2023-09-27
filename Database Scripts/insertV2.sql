INSERT INTO lecturer (lecturerID, firstName, lastName) VALUES
('LEC001', 'Alice', 'Smith'),
('LEC002', 'Bob', 'Jones'),
('LEC003', 'Charlie', 'Brown'),
('LEC004', 'Donna', 'Johnson'),
('LEC005', 'Eric', 'Williams'),
('LEC006', 'Fiona', 'Taylor'),
('LEC007', 'George', 'Johnson'),
('LEC008', 'Helen', 'Williams'),
('LEC009', 'Ian', 'Taylor'),
('LEC010', 'Jack', 'Johnson');

INSERT INTO room (roomID, roomName) VALUES
('Room 101', 'The Fridge'),
('Room 102', 'The Freezer'),
('Room 103', 'The Sauna');

INSERT INTO subject (subjectID, subjectName, room_roomID) VALUES
('UWB001', 'Underwater Basketweaving', 'Room 101'),
('UWB002', 'Underwater Basketweaving History', 'Room 102'),
('UWB003', 'Underwater Basketweaving Techniques', 'Room 103'),
('UWB004', 'Underwater Basketweaving Design', 'Room 101'),
('UWB005', 'Underwater Basketweaving Business', 'Room 102'),
('UWB006', 'Underwater Basketweaving Photography', 'Room 103'),
('UWB007', 'Underwater Basketweaving Marketing', 'Room 101'),
('UWB008', 'Underwater Basketweaving Sales', 'Room 102'),
('UWB009', 'Underwater Basketweaving Customer Service', 'Room 103'),
('UWB010', 'Underwater Basketweaving Emp Opportunities', 'Room 101');

INSERT INTO timeslot (day, time, subject_subjectID) VALUES
('Monday', '09:00', 'UWB001'),
('Monday', '12:00', 'UWB002'),
('Tuesday', '09:00', 'UWB003'),
('Tuesday', '12:00', 'UWB004'),
('Tuesday', '15:00', 'UWB005'),
('Wednesday', '09:00', 'UWB006'),
('Wednesday', '12:00', 'UWB007'),
('Wednesday', '15:00', 'UWB008'),
('Thursday', '09:00', 'UWB009'),
('Thursday', '12:00', 'UWB010');