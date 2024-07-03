-- Create Event Stored Procedure
CREATE PROCEDURE CreateEvent
    @event_name VARCHAR(255),
    @event_date DATE,
    @event_time TIME,
    @location VARCHAR(255),
    @description TEXT,
    @organizer_id INT
AS
BEGIN
    INSERT INTO Events (event_name, event_date, event_time, location, description, organizer_id)
    VALUES (@event_name, @event_date, @event_time, @location, @description, @organizer_id);
END;
GO


-- Read Events Stored Procedure
CREATE PROCEDURE ReadEvents
AS
BEGIN
    SELECT * FROM Events;
END;
GO



-- Update Event Stored Procedure
CREATE PROCEDURE UpdateEvent
    @event_id INT,
    @event_name VARCHAR(255),
    @event_date DATE,
    @event_time TIME,
    @location VARCHAR(255),
    @description TEXT,
    @organizer_id INT
AS

BEGIN
    UPDATE Events
    SET event_name = @event_name,
        event_date = @event_date,
        event_time = @event_time,
        location = @location,
        description = @description,
        organizer_id = @organizer_id
    WHERE event_id = @event_id;
END;
GO




-- Delete Event Stored Procedure
CREATE PROCEDURE DeleteEvent
    @event_id INT
AS
BEGIN
    DELETE FROM Events
    WHERE event_id = @event_id;
END;
GO
