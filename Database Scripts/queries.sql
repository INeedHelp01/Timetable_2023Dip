/* Search all subjects */
SELECT * FROM subject;

/* Search for a subject */
SELECT * 
FROM 
	subject 
WHERE 
	subjectID = 'UWB001';

/* Search for a lecturer */
SELECT
    CONCAT(lecturer.firstName, ' ' , lecturer.lastName) as lecturerName
FROM 
    lecturer 
WHERE 
    firstName = 'Alice';
    
/* UI DISPLAY SQL QUERIES */
SELECT
	timeslot.time,
	CONCAT(lecturer.firstName, ' ' , lecturer.lastName) as lecturerName,
	room.roomID
FROM timeslot
	INNER JOIN
    

