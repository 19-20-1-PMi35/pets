use petsDB

create table "Type"
(
	id int primary key identity,
	"type" nvarchar(10) unique not null
);

create table Size
(
	id int primary key identity,
	size nvarchar(10) unique not null
);

create table Animal
(
	id int primary key identity,
	"name" nvarchar(40) default 'unknown',
	age numeric(2,1) check(age >= 0)  default 0,
	sex char not null,
	sizeId int,
	breed nvarchar(40) default 'unknown',
	"description" text,
	typeId int,
	foreign key(sizeId) references Size(id) on delete set default,
	foreign key(typeId) references "Type"(id) on delete set default
);

create table "Order"
(
	id int primary key identity,
	surname nvarchar(40) not null,
	phone char(10) unique not null,
	animalId int,
	foreign key(animalId) references Animal(id) on delete cascade
);

EXEC sp_rename 'Type', 'Types';

