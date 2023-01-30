-- database: farm_example
-- farms first
select * from farm;
select * from farm;

insert into farm (name, annual_revenue) values ('Beech Ranch', 650000);
insert into farm (name, annual_revenue) values ('Morton Farms', 450000);
insert into farm (name, annual_revenue) values ('Beech Ranch', 750000);

--update farm set 

-- animals second
select * from animal;
insert into animal (type) values ('pigs');
insert into animal (type) values ('chickens');
insert into animal (type) values ('cows');
insert into animal (type) values ('goat');
insert into animal (type) values ('horses');

-- connection third
select * from farm_has_animal;
insert into farm_has_animal (farm_id, animal_id, count) values (1, 1, 6);
insert into farm_has_animal (farm_id, animal_id, count) values (1, 2, 10);
insert into farm_has_animal (farm_id, animal_id, count) values (1, 3, 3);
insert into farm_has_animal (farm_id, animal_id, count) values (2, 1, 11);
insert into farm_has_animal (farm_id, animal_id, count) values (2, 4, 4);
insert into farm_has_animal (farm_id, animal_id, count) values (2, 5, 2);
insert into farm_has_animal (farm_id, animal_id, count) values (3, 5, 22);

-- printing
select * from farm_has_animal; -- select all not helpful w/o join
select * from farm 
left join farm_has_animal on farm.id=farm_has_animal.farm_id 
left join animal on farm_has_animal.animal_id=animal.id; -- print all connections from farm

select * from animal
left join farm_has_animal on animal.id=farm_has_animal.animal_id
left join farm on farm_has_animal.farm_id=farm.id; -- print all connections from animal

select * from farm 
left join farm_has_animal on farm.id=farm_has_animal.farm_id 
left join animal on farm_has_animal.animal_id=animal.id where farm.id=1; -- print all connections for farm 1

select * from animal
left join farm_has_animal on animal.id=farm_has_animal.animal_id
left join farm on farm_has_animal.farm_id=farm.id where animal.type='horses'; -- print all connections from animal

-- delete
delete from farm_has_animal where id=2;