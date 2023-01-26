-- Get all entries from the customers table - returns array
SELECT * FROM Customers; 
-- Get all entries with specified city
select * from Customers where City="London";
-- Get all entries with specified city and Postal Code (wildcard - starts with)
select * from Customers where City="London" AND like PostalCode like 'W%';

-- Uses: user/pswd check
-- CusomterIDs: start at 1, once deleted - can no longer be used, ONLY thing guaranteed to be different
select * from Customers where CustomerID=4; -- pulls only one

-- ***Join statements*** - Read complications
--  3 kinds of relationships
--      1:1 one-to-one      (ssn, husband-wife)
--      1:M one-to-many     (1 owner of many pets, 
--                            those pets have 1 owner)
--      M:M many-to-many    (students have many classes,
--                            classes have many students)

-- creates a new temp table to pull all images from the favorite table that user 2 creates
SELECT * FROM app_user LEFT JOIN app_favorite ON app_user.id=app_favorite.user_id WHERE app_user.id = 2;

-- Types of joins (venn diagram)
--  Inner Join : A && B ( (x) )
--  Left Join : All A including A&&B (x(x) )
--  Right Join : All B including A&&B ( (x)x)
--  Cross Join: A || B (x(x)x)

-- creaates a new temp table where it combines and matched info from both tables
SELECT * FROM app_user LEFT JOIN app_favorite ON app_user.id=app_favorite.user_id;