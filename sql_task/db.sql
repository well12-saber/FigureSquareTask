create table product (
	id int,
    name varchar(255)
);

create table productCategory (
	productId int ,
    categoryId int 
);

create table category (
	id int ,
    name varchar(255) 
);

insert into product (id,name) values	
(1,'meat'),
(2,'tea'),
(3,'water'),
(4,'chocolate'),
(5,'bag');

insert into category (id,name) values	
(1,'A'),
(2,'B'),
(3,'C');

insert into productCategory (productId,categoryId) values	
(1,1),
(2,3),
(3,3),
(4,2);
	


