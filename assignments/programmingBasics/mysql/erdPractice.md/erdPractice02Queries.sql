-- Show all the cars that have sold

SELECT * FROM cars.cars;

-- Show all the salespeople that have sold any cars
SELECT * FROM cars.salesperson;


-- Update a car to correct who sold INTO

UPDATE cars.salesperson set firstName = 'Liannys' where id = 2;

-- Fire a salesperson
DELETE FROM cars.salesperson where id = 3;  