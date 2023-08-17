/*создание таблиц*/
create table products (
  id bigint primary key,
  name varchar not null unique
);

create table category (
  id bigint primary key,
  name varchar not null unique
);

create table products_category_tags (
  product_id bigint,
  category_id bigint,
  constraint fk_products_category_tags_product_id foreign key (product_id) references products (id),
  constraint fk_products_category_tags_category_id foreign key (category_id) references category (id)
);

/*наполнение данными*/
insert into products VALUES
(1,'ноутбук'),
(2, 'мышка'),
(3, 'монитор'),
(4,'кружка'),
(5, 'ложка'),
(6, 'подставка'),
(7,'ручка'),
(8,'блокнот'),
(9,'ластик'),
(10, 'карандаш'),
(11, 'мыло');

insert into category VALUES
(1,'Техника'),
(2, 'Мыльные принадлежности'),
(3,'Рабочее место');

insert into products_category_tags VALUES
(1,1),
(1, 3),
(2,1),
(2, 3),
(3,1),
(3, 3),
(11,2);

/*запрос к базе данных*/
select products.name, category.name
from products_category_tags right join products
on products.id = products_category_tags.product_id
left join category 
on category.id = products_category_tags.category_id
