-- Stored Procedures for Organizers

CREATE PROCEDURE CreateOrganizer
    @OrganizerName VARCHAR(255),
    @ContactEmail VARCHAR(255),
    @ContactPhone VARCHAR(20)
AS
BEGIN
    INSERT INTO Organizers (OrganizerName, ContactEmail, ContactPhone)
    VALUES (@OrganizerName, @ContactEmail, @ContactPhone);
END;
GO

CREATE PROCEDURE ReadOrganizers
AS
BEGIN
    SELECT * FROM Organizers;
END;
GO

CREATE PROCEDURE UpdateOrganizer
    @OrganizerId INT,
    @OrganizerName VARCHAR(255),
    @ContactEmail VARCHAR(255),
    @ContactPhone VARCHAR(20)
AS
BEGIN
    UPDATE Organizers
    SET OrganizerName = @OrganizerName,
        ContactEmail = @ContactEmail,
        ContactPhone = @ContactPhone
    WHERE OrganizerId = @OrganizerId;
END;
GO

CREATE PROCEDURE DeleteOrganizer
    @OrganizerId INT
AS
BEGIN
    DELETE FROM Organizers
    WHERE OrganizerId = @OrganizerId;
END;
GO

-- Stored Procedures for Events

CREATE PROCEDURE CreateEvent
    @EventName VARCHAR(255),
    @EventDate DATE,
    @EventTime TIME,
    @Location VARCHAR(255),
    @Description TEXT,
    @OrganizerId INT
AS
BEGIN
    INSERT INTO Events (EventName, EventDate, EventTime, Location, Description, OrganizerId)
    VALUES (@EventName, @EventDate, @EventTime, @Location, @Description, @OrganizerId);
END;
GO

CREATE PROCEDURE ReadEvents
AS
BEGIN
    SELECT * FROM Events;
END;
GO

CREATE PROCEDURE UpdateEvent
    @EventId INT,
    @EventName VARCHAR(255),
    @EventDate DATE,
    @EventTime TIME,
    @Location VARCHAR(255),
    @Description TEXT,
    @OrganizerId INT
AS
BEGIN
    UPDATE Events
    SET EventName = @EventName,
        EventDate = @EventDate,
        EventTime = @EventTime,
        Location = @Location,
        Description = @Description,
        OrganizerId = @OrganizerId
    WHERE EventId = @EventId;
END;
GO

CREATE PROCEDURE DeleteEvent
    @EventId INT
AS
BEGIN
    DELETE FROM Events
    WHERE EventId = @EventId;
END;
GO

-- Stored Procedures for Attendees

CREATE PROCEDURE CreateAttendee
    @FirstName VARCHAR(255),
    @LastName VARCHAR(255),
    @Email VARCHAR(255),
    @Phone VARCHAR(20),
    @RegistrationDate DATE,
    @EventId INT
AS
BEGIN
    INSERT INTO Attendees (FirstName, LastName, Email, Phone, RegistrationDate, EventId)
    VALUES (@FirstName, @LastName, @Email, @Phone, @RegistrationDate, @EventId);
END;
GO

CREATE PROCEDURE ReadAttendees
AS
BEGIN
    SELECT * FROM Attendees;
END;
GO

CREATE PROCEDURE UpdateAttendee
    @AttendeeId INT,
    @FirstName VARCHAR(255),
    @LastName VARCHAR(255),
    @Email VARCHAR(255),
    @Phone VARCHAR(20),
    @RegistrationDate DATE,
    @EventId INT
AS
BEGIN
    UPDATE Attendees
    SET FirstName = @FirstName,
        LastName = @LastName,
        Email = @Email,
        Phone = @Phone,
        RegistrationDate = @RegistrationDate,
        EventId = @EventId
    WHERE AttendeeId = @AttendeeId;
END;
GO

CREATE PROCEDURE DeleteAttendee
    @AttendeeId INT
AS
BEGIN
    DELETE FROM Attendees
    WHERE AttendeeId = @AttendeeId;
END;
GO
