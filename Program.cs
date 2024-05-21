﻿using System;

class Program
{
    static void Main()
    {
        int op = 9;
        int num1;
        int num2;
        int raio;

        Console.WriteLine("---------  Calculadora  ---------\n");

        while (op != 0) {
            Console.WriteLine("1 - soma\n2 - subtração\n3 - multiplicação\n4 - divisão\n5 - área de círculo\n0 - sair\n");

            op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            switch (op) {
                case 1:
                    Console.WriteLine("Número 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Número 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("A soma dos números, " + num1 + " + " + num2 + "é: " + (num1 + num2) + "\n");
                break;

                case 2:
                    Console.WriteLine("Número 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Número 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("A subtração dos números, " + num1 + " - " + num2 + "é: " + (num1 - num2) + "\n");
                break;

                case 3:
                    Console.WriteLine("Número 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Número 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("A multiplicação dos números, " + num1 + " * " + num2 + "é: " + (num1 * num2) + "\n");
                break;

                case 4:
                    Console.WriteLine("Número 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Número 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("A divisão dos números, " + num1 + " / " + num2 + "é: " + (num1 / num2) + "\n");
                break;

                case 5:
                    Console.WriteLine("Insira o raio do círculo: ");
                    raio = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Área do círculo é: " + (System.Math.PI * System.Math.Pow(raio, 2)) + "\n");
                break;

                case 0:
                    Console.WriteLine("Desligando calculadora!\n");
                break;
                
                default:
                    Console.WriteLine("Operação não encontrada!\n");
                break;
            }
        }
    }
}