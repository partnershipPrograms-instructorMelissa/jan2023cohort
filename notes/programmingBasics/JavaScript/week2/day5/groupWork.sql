-- truncate table child; -- deletes and resets
-- ========= ERD Practice 1 =========
-- create data
insert into home (street, city, state, zipcode) 
values ('754 New Stripe St', 'Bremertion', 'WA', '98312'),
('9701 Robot Ln', 'Colorado Springs', 'CO', '80920'),
('1568 Jumper Rd', 'Argile', 'TX', '76226');

select * from home;

insert into parent (firstName, lastName, age, home_id) 
values ('Jane','Doe', 43, 1),
('John','Doe', 39, 1),
('Genna','Smith',  37, 2),
('Mike','Smith', 40, 2),
('Paula','Appleseed', 46, 3);

select * from parent;

insert into child (firstName, lastName, age, home_id, parent1_id, parent2_id)
values ('Suzzie', 'Doe', 12, 1, 1, 2),
('Jason', 'Doe', 8, 1, 1, 2),
('Jarred', 'Doe', 5, 1, 1, 2),
('Sally', 'Smith', 6, 2, 3, 4);

insert into child (firstName, lastName, age, home_id, parent1_id)
values ('Thomas', 'Appleseed', 11, 3, 5);

select * from child;

insert into toy (type) 
values ('Hot Wheels'),
('Paint Kit'),
('Puzzle'),
('Teddy Bear'),
('Doll'),
('Legos'),
('Doll House');

select * from toy;

insert into child_has_toy (child_id, toy_id)
values (5, 1), (5, 3), (6, 4), (6, 2),(6, 3), (7,1),(7,6),(8,5),(8,2),(9,5),(9,7),(9,2);

select * from child_has_toy;
-- Show all the toys that are in the home
select * from toy
left join child_has_toy on toy.id=child_has_toy.toy_id
left join child on child_has_toy.child_id=child.id
left join home on child.home_id=home.id
where home.id=1;

-- Show all the toys that 1 child has
select * from toy
left join child_has_toy on toy.id=child_has_toy.toy_id
left join child on child_has_toy.child_id=child.id
where child.id=9;


-- Show who owns 1 type of toy
select * from toy
left join child_has_toy on toy.id=child_has_toy.toy_id
left join child on child_has_toy.child_id=child.id
where toy.id=1;


-- Update the name to 1 child
update child 
set firstName='Tom' 
where child.id=5;


-- delete a toy from a child
delete from child_has_toy where child_id=6 and toy_id=3;

-- ========= ERD Practice 2 =========
