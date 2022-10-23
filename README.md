# Задание:

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

- Юнит-тесты

- Легкость добавления других фигур

- Вычисление площади фигуры без знания типа фигуры в compile-time

- Проверку на то, является ли треугольник прямоугольным


# Задание 2
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

```SQL
CREATE TABLE Products(ID INT PRIMARY KEY, Name NVARCHAR(50) NULL);
CREATE TABLE Category(ID INT PRIMARY KEY, Name NVARCHAR(50) NULL);
CREATE TABLE CategoryProducts (Product_ID INT NOT NULL, Category_ID INT NOT NULL);
```

```SQL
INSERT INTO Products VALUES(1, 'Note 11 Pro'), (2, 'Lenovo Legion 5'), (3, 'Galaxy S7');
INSERT INTO Category VALUES(1, 'Phones'), (2, 'Laptops');
INSERT INTO CategoryProducts VALUES(1, 1), (2, 2), (3, 1);
```

```SQL
SELECT P.Name, C.Name
FROM Products P
LEFT JOIN CategoryProducts CP
	ON P.ID = CP.Product_ID
LEFT JOIN Category C
	ON CP.Category_ID = C.ID;
```
