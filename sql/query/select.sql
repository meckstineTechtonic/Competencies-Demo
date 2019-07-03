SELECT * FROM People;

SELECT * FROM Places;

SELECT FirstName, LastName FROM People;

SELECT FirstName, FavoriteFood FROM People;

SELECT * FROM People
WHERE LastName IS NULL;

SELECT * FROM People
WHERE Age >= 100;

-- joins
SELECT People.FirstName, People.Age, Places.PlaceName
FROM Orders
INNER JOIN Customers ON People.CurrentLocation=Places.PlaceName;