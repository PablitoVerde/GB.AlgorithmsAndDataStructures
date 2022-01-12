# *Курс "Алгоритмы и структуры данных"*

## Решение домашних заданий основано на 3 проектах:

1. Проект меню;
2. Проект интерфейса решения задачи (ввиде dll-сборки для первого решения);
3. Проект с решением задач (ввиде dll-сборки для первого решения, имеет reference к 2 проекту).

### Выполненные задачи:

Выделено жирным.

#### *Урок 1*
**1. Напишите на C# функцию согласно блок-схеме**
**2. Посчитайте сложность функции**
**3. Реализуйте функцию вычисления числа Фибоначчи**

#### *Урок 2*
**1. Реализация типа двусвязного списка. И контрольный пример, демонстрирующий использование методов. Интерактивный режим (взаимодействие с пользователем) не требуется.**

#### *Урок 3*
**1. Создаем 2 типа: структура PointStructDouble, класс PointClassDouble. Создаем метод, возвращающий расстояние между парой точек каждого типа. Реализуем метод, создающий массив точек каждого типа и заполняющий его случайными значениями. Проводим замеры длительности выполнения методов на массивах разного размера. Вывод может иметь вид (соответственно x, y - время выполнения, Ratio - отношение времени):**
**Количество точек | PointStructDouble | PointClassDouble | Ratio**
**100000 | x1 | y1| y1/x1**
**200000 | x2 | y2 | y2/x2**

#### *Урок 4*
**1. Реализуйте класс двоичного дерева поиска с операциями вставки, удаления, поиска. Также напишите метод вывода в консоль дерева, чтобы увидеть, насколько корректно работает ваша реализация.**
2.(Опционально) Заполните массив и HashSet случайными строками, не менее 10 000 строк. Выполните замер производительности проверки наличия строки в массиве и HashSet. Выложите код и результат замеров.

#### *Урок 5*
**1. Реализуйте методы поиска в дереве "поиск в ширину" и "поиск в глубину" (класс дерева должен быть реализован в ДЗ урока 4) с выводом каждого шага в консоль.**

#### *Урок 6*
**1. Делать тем, кто сдал ДЗ по урокам 4 и 5 - алгоритмы на дереве.**
**2. Реализовать загрузку списка уроков из файла.**
*Примечание: алгоритмы реализованы на деревьях. ДЗ грузится из файла, для этого отдельный класс не создавался.*

#### *Урок 7*
**1. Реализовать алгоритм "задачи на количество вариантов" и вывод количества вариантов для последовательности [1..100]**
**2. Для тех, кто реализовал загрузку классов домашних заданий из файла (Урок 6) - вынести интерфейс домашнего задания в отдельную библиотеку и все домашние задания - в другую.**
*Примечание: задание 2 реализовано в логике самой программы.*

#### *Урок 8*
Итоговое практическое задание - сумма всех заданий в течение курса.
Требование: все работы должны быть выполнены в одном проекте. Должна быть предусмотрена возможность удобного - на усмотрение автора - вызова нужного примера/задания.

На настоящий момент в решении курса отсутствует (*TODO на будущее*):
1. Реализация логгирования выявленных ошибок.
2. Взаимодействие с пользователем (ввод пользовательских данных).
3. Выполнение домашних заданий 4.2.
4. Решение задачи о 8 ферзях.
5. Отделение функционала по взаимодействию с пользователем от кода самих ДЗ.
