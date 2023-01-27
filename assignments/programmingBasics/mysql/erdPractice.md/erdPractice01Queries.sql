-- Show all the toys that are in the home
SELECT * FROM toys.toys;

-- Show all the toys that 1 child has
SELECT * FROM child join toys on child_id = child.id where toys.id = child_id;

-- Show who owns 1 type of toy
select * from children
join toys on child_id = children.id
where toys.name = 'Wand';


-- Update the name to 1 child



-- delete a toy from a child


