--Предположения:
--1) Пусть у нас есть тдве таблицы:
----Categories - категории с целочисленным первичным ключoм "ID" и столбцом имен категорий "CategoryName" 
----Products - продукты с целочисленным ключом "ID", столбцом имен продуктов "ProductName" и внешним ключом "CategoryId"
--2) Категории связаны с продуктами отношением "один-ко-многим"
--3) Так как нужно получить полный набор пар (Имя категории, Имя продукта), воспользуемся полным объединением (объединением множеств в математическом смысле)
----Для этого воспользуемся "FULL JOIN".
--4) Проверяем результат.

SELECT CategoryName AS Category, ProductName AS Product FROM Categories
FULL JOIN Products
ON Categories.ID=Products.CategoryId
GO
