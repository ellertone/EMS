-- Create Attendee Stored Procedure
CREATE PROCEDURE CreateAttendee
    @first_name VARCHAR(255),
    @last_name VARCHAR(255),
    @email VARCHAR(255),
    @phone VARCHAR(20),
    @registration_date DATE,
    @event_id INT
AS
BEGIN
    INSERT INTO Attendees (first_name, last_name, email, phone, registration_date, event_id)
    VALUES (@first_name, @last_name, @email, @phone, @registration_date, @event_id);
END;
GO




-- Read Attendees Stored Procedure
CREATE PROCEDURE ReadAttendees
AS
BEGIN
    SELECT * FROM Attendees;
END;
GO




-- Update Attendee Stored Procedure
CREATE PROCEDURE UpdateAttendee
    @attendee_id INT,
    @first_name VARCHAR(255),
    @last_name VARCHAR(255),
    @email VARCHAR(255),
    @phone VARCHAR(20),
    @registration_date DATE,
    @event_id INT
AS
BEGIN
    UPDATE Attendees
    SET first_name = @first_name,
        last_name = @last_name,
        email = @email,
        phone = @phone,
        registration_date = @registration_date,
        event_id = @event_id
    WHERE attendee_id = @attendee_id;
END;
GO




-- Delete Attendee Stored Procedure
CREATE PROCEDURE DeleteAttendee
    @attendee_id INT
AS
BEGIN
    DELETE FROM Attendees
    WHERE attendee_id = @attendee_id;
END;
GO
