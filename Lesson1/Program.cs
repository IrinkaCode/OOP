﻿using Lesson1;

//Console.Write("Введите первое число: ");
//int x =int.Parse(Console.ReadLine()!);
//Console.Write("Введите второе число: ");
//int y = int.Parse(Console.ReadLine()!);

//Pair p1 = new Pair(x, y);
//p1.Print();
//p1.setA(10);
//p1.setB(18);
//p1.Print();
//Console.WriteLine(p1.Sum());
//Console.WriteLine(p1.Max());

//NewPair p2 = new NewPair {A = x,B = y};
//p2.Print();
//Console.WriteLine($"A равно {p2.A}, B равно {p2.B}");
//p2.A = 30;
//p2.B = 40;
//p2.Print();

//Console.WriteLine(p2.Sum());
//Console.WriteLine(p2.Max());


Counter c1 = new Counter();
Console.WriteLine(c1.Count);
c1.inc();
c1.inc();
c1.inc();
c1.inc();
Console.WriteLine(c1.Count);
c1.dec();
Console.WriteLine(c1.Count);

Random random = new Random();

Counter c2 = new Counter(random.Next(-10, 10), -10, 10);
Console.WriteLine(c2.Count);

c2.inc();
Console.WriteLine(c2.Count);

c2.dec();
Console.WriteLine(c2.Count);

