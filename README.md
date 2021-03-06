# Содержание
1. [Введение](#1-Введение)  
1.1 [Назначение](#11-Назначение)  
1.2 [Область действия проекта](#12-Область-действия-проекта)  
2. [Общее описание](#2-Общее-описание)  
2.1 [Функционал продукта](#21-Функционал-продукта)  
2.2 [Классификация пользователей](#22-Классификация-пользователей)  
2.3 [Инструментарий проектирования](#23-Инструментарий-разработки)  
3. [Требования к интерфейсу](#3-Требования-к-интерфейсу)  
3.1 [Пользовательский интерфейс](#31-Пользовательский-интерфейс)  
4. [Функциональные особенности системы](#4-Функциональные-требования)  
5. [Нефункциональные особенности](#5-Нефункциональные-особенности)  
5.1 [Атрибуты качества](#51-Атрибуты-качества)  
# 1. Введение
## 1.1 Назначение 
В рамках данной спецификации требований программного обеспечения описывается назначение и область действия данного приложения. Также цель документа состоит в анализе и в получении глубокого понимания функционала игры BrainTeaser, сборке всех различных идей, определении системы, ее требований по отношению к потребителям. Также будут изложены концепции, которые будут разработаны позже, и будут документрироваться идеи, которые будут рассмотрены, но могут быть отброшены по мере развития продукта.
## 1.2 Область действия проекта
Данный проект является 3D игрой, идея которой заключается в выводе определённого блока из игрового поля.
# 2. Общее описание
## 2.1 Функционал продукта  
Данная игра позволит сдвигать блоки определённым образом, чтобы вывести основной блок из игрового поля. Игра предполагает прохождение уровней. С каждым уровнем сложность увеличивается.
## 2.2 Классификация пользователей 
Пользователи, которые любят головоломки. Игра подходит для игроков любого возраста.
## 2.3 Инструментарий разработки
Игровой движок: Unity 2020.3.27f1;  
Используемый язык программирования: C#.
# 3. Требования к интерфейсу
## 3.1 Пользовательский интерфейс  
Вход в игру
![](https://i.imgur.com/ZRktSnr.jpg)  
Игровое поле. Таким образом, нужно вывести из игрового поля розовый блок, двигая этот и другие блоки.
![](https://i.imgur.com/4mC0t1j.png)  
![](https://i.imgur.com/46ggWed.png)  
# 4. Функциональные требования 
 - Начать игру;  
 - Выйти из игры;  
 - Возможность двигать блоки (есть 5 видов блоков: розовый блок (блок, который нужно вывести за пределы поля; в зависимости от уровня может двигаться по горизонтали, вертикали или быть статичным), голубые блоки (двигаются по вертикали), светло-зелёные блоки (двигаются по горизонтали), белые блоки (статичны, на некорых уровнях можно двигать с помощью других блоков), жёлтые блоки с кнопкой (статичны, становятся прозрачными, если кнопка нажата));  
 - Возможность переходить на новые уровни (автоматически после прохождения уровня или с помощью кнопки "Q");  
 - Возможность начинать уровень сначала (кнопка "R").  
# 5. Нефункциональные особенности  
## 5.1 Атрибуты качества  
 - Возможность настроить управление.
