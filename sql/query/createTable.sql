CREATE TABLE People (
    ID int NOT NULL IDENTITY,
    FirstName varchar(20),
    LastName varchar(20),
    Age int,
    CurrentLocation varchar(20),
    FavoriteFood varchar(50),
    PRIMARY KEY (ID)
); 

CREATE TABLE Places (
    PlaceName varchar(20),
    PlaceLocation varchar(20)
)