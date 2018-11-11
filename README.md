Day14
---
1.  Реализовать [метод-генератор последовательности чисел Фибоначчи](https://github.com/RomanGutovec/NET1.A.2018.Gutovec.14/blob/master/FibonacciLib/Fibonacci.cs). 
Разработать [unit-тесты](https://github.com/RomanGutovec/NET1.A.2018.Gutovec.14/blob/master/FibonacciLib.Tests/FibonacciLibTest.cs).
2.  Реализовать [обобщенный алгоритм бинарного поиска](https://github.com/RomanGutovec/NET1.A.2018.Gutovec.1/blob/master/Algorithms/BinarySearchAlgorithm.cs) (добавить в проект с методами сортировки). 
Методы сортировки преобразовать в обобщенные. Разработать [unit-тесты](https://github.com/RomanGutovec/NET1.A.2018.Gutovec.1/blob/master/NET1.A.2018.Gutovec.1.NUnitTests/BinarySearchAlgorithmTests.cs).
3.  Добавить в статический класс с обобщенными методами-трансформерами обобщенные [методы-фильтры](https://github.com/RomanGutovec/NET1.A.2018.Gutovec.4/blob/master/Algorithms/ExtensionTransformerCommon.cs) (реализовать как методы расширения) получения из набора данных типа TSource набора данных типа TSource, логику попадания в результирующий набор инкупсулировать в функции-предикате (рассмотреть два подхода - объектно-ориентированый и функциональный). В качестве тест-кейсов для метода-фильтра можно использовать, напимер,
    * [для строк](https://github.com/RomanGutovec/NET1.A.2018.Gutovec.4/blob/master/Algorithms.NUnit.Tests/Helpers/PredicatesForStrings.cs) - соответствие определенном шаблону, соответствие определенной длине и т.д.
    * [для целых чисел](https://github.com/RomanGutovec/NET1.A.2018.Gutovec.4/blob/master/Algorithms.NUnit.Tests/Helpers/PredicatesForDigits.cs) - наличие определенной цифры в числе, простота, четность и т.д.
4.  Добавить в класс-сервис для управления банковским счетом возможность логирования информации об исключениях, 
возникающих при выполнении основых операций с банковским счетом. Продумать возможность (при необходимости) замены одного фреймворка 
для логирования на другой, а также использования кастомных классов исключений.
