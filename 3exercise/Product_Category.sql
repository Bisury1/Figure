create database Product;
use Product;

create table Product(
	Id int primary key auto_increment,
    ProductName text
);
create table Category(
	Id int primary key auto_increment,
    CategoryName text	
);
create table Product_Category(
	ProductId int,
    CategoryId int,
    primary key(ProductId, CategoryId),
    foreign key (CategoryId) references Category(Id),
    foreign key (ProductId) references Product(Id)
);

insert into Product
values (1, "Корова"), (2, "Курица"), (3, "Стол"), (4, "Стиральная Машина"), (5, "Тетрадь");
insert into Category
values (1, "Животные"), (2, "Мебель"), (3, "Бытовая Техника"), (4, "Электронные устройства");
insert into Product_Category
values (1, 1), (2, 1), (3, 2), (4, 3), (4, 4); 


select p.ProductName, c.CategoryName
from product p
left join product_category pc
	on p.Id = pc.ProductId
left join category c
	on pc.CategoryId = c.Id;