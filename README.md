# Отклик Ивана на вакансию ООО Mindbox
#### https://hh.ru/resume/bab5be45ff032a5fb40039ed1f335a4147665a
#### https://hh.ru/vacancy/100472094?hhtmFrom=vacancy_response
## Первая задачка:
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
Юнит-тесты
Легкость добавления других фигур
Вычисление площади фигуры без знания типа фигуры в compile-time
Проверку на то, является ли треугольник прямоугольным

Задача решена:
проект MindboxHeadHunterTask, dll+nuget package (чтобы где то во вне удобно использовать, импортировав)
## Вторая задачка
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
### Решение
Что ж... в простом варианте, пусть будет табличка продукты
Products. {(uniq)id | name}
и табличка категорий
Categories. {(uniq)id | name}
и.. где то должна лежать табличка связь между Products и Categories.. links {id | id}??

SELECT 
    p.name,
    c.name
FROM 
    Products p
LEFT JOIN 
    Links l ON p.id = l.id
LEFT JOIN 
    Categories c ON l.id = c.id;

