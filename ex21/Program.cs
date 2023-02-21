﻿/***************************************************************************************

Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

***************************************************************************************/


int[] coordsA = new int[3];
int[] coordsB = new int[3];

Console.Write("Введите X точки A: ");
coordsA[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y точки A: ");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z точки A: ");
coordsA[2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

Console.Write("Введите X точки B: ");
coordsB[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y точки B: ");
coordsB[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z точки B: ");
coordsB[2] = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(coordsA[0] - coordsB[0], 2) + Math.Pow(coordsA[1] - coordsB[1], 2) + Math.Pow(coordsA[2] - coordsB[2], 2));

Console.WriteLine(Math.Round(result, 2));