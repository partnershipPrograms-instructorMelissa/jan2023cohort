-- Create a DB for the toys in a home.  Each child has their own set of toys.

Child table
- id
- name
- age

toys
- id
- name

![database pics](../pics/Screenshot_20230127_012507.png)

-- Show all the toys that are in the home
grab all toys from one child

-- Show all the toys that 1 child has


-- Show who owns 1 type of toy
select * from children
join toys on child_id = children.id
where toys.name = 'Wand';


-- Update the name to 1 child



-- delete a toy from a child



