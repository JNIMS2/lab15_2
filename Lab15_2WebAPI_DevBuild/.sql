create database Movieapi;
use Movieapi;
# categories ACTION COMEDY ROMANCE SCIFI CHILDREN
create table movie(
id int not null auto_increment,
category varchar(20),
title varchar(50),
director varchar(35),
starring varchar(50),
primary key (id)
);

insert into movie( category, title, director, starring) values
('ACTION', 'THE BOOP GOES BORP', 'SMILEY JORGENSEN', 'ABE ZIGGY');
insert into movie( category, title, director, starring) values
('ACTION', 'THE BOOPLE BEEP', 'STEPHEN JAMAAL', 'DWAYNE ZEBSER');
insert into movie( category, title, director, starring) values
('COMEDY', 'A ZORP IN THE JEEP', 'KEREN PHILPS', 'STAR ZAPPA');
insert into movie( category, title, director, starring) values
('ROMANCE', 'NO FLIIPING WAY', 'DONALD DUCK', 'MOONLIGHT APPLE');
insert into movie( category, title, director, starring) values
('ROMANCE', 'YES WAY', 'DAISY GOOSE', 'STELLA ABRAHAM');
insert into movie( category, title, director, starring) values
('COMEDY', 'TOO MANY TRIBBLES', 'STARSHIP SMITHTERS', 'AFORREAL HUMAN');
insert into movie( category, title, director, starring) values
('SCIFI', 'AN ALIEN FOR CHRISTMAS', 'DUDE RODGERS', 'BUCK FORSEITH');
insert into movie( category, title, director, starring) values
('SCIFI', 'DEF NOT DOCTOR WHO', 'DUDE RODGERS', 'MOONLIGHT APPLE');
insert into movie( category, title, director, starring) values
('CHILDREN', 'BABY ELEPHANT FOR TEA', 'SMILEY JORGENSEN', 'STAR ZAPPA');
insert into movie( category, title, director, starring) values
('CHILDREN', 'CAREBEAR DRAMA 2.0', 'DONALD DUCK', 'STELLA ABRAHAM');