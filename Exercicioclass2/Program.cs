﻿using Exercicioclass2;
using System;
using System.Globalization;

Funcionario f1 = new Funcionario();
Funcionario f2 = new Funcionario();

Console.WriteLine("Dados do primeiro funcionario:");
Console.Write("Nome : ");
f1.Nome = Console.ReadLine();
Console.Write("Salario: ");
f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionario:");
Console.Write("Nome: ");
f2.Nome = Console.ReadLine();
Console.Write("Salario: ");
f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = (f1.Salario + f2.Salario) / 2.0;

Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));


