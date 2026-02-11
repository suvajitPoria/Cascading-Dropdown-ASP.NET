USE dbStudent;
SELECT * FROM tblCity;
SELECT * FROM tblState;
SELECT * FROM tblCountry;
CREATE PROC spReadCountry
AS
BEGIN
    SELECT c.CountryId, CountryName FROM tblCountry as c;
END

CREATE PROC spReadState 
    @CountryId INT
AS
BEGIN
    SELECT s.StateId, s.StateName FROM tblState as s
    where CountryId = @CountryId;
END

ALTER PROC spReadCity 
    @StateId INT
AS
BEGIN
    SELECT c.CityId, c.CityName FROM tblCity as c
    where c.StateId = @StateId;
END