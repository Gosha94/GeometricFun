-- Задача:
-- В базе данных MS SQL Server есть продукты и категории.
-- Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
-- Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
-- Если у продукта нет категорий, то его имя все равно должно выводиться.

-- Запустить код можно тут:
-- https://sqliteonline.com

declare @products table (id int, name  nvarchar(100), category_id int )
declare @categories table (id int, name  nvarchar(100) )

insert into
    @products
values
    (1, N'Product1', '1')
   ,(2, N'Product2', '1')
   ,(3, N'Product3', '4')
   ,(4, N'Product4', '2')
   ,(5, N'Product5', '2')

insert into
    @categories
values 
    (1, N'Category1')
   ,(2, N'Category2')
   ,(3, N'Category3')

select
    p.name,
    c.name
from
	@products p
left join
	@categories c on p.category_id = c.id