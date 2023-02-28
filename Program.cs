/*Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em
seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o
salário do funcionário com base em uma porcentagem dada (somente o salário bruto é
afetado pela porcentagem) e mostrar novamente os dados do funcionário. Use a classe
projetada abaixo.
Nome: Joao Silva
Salário bruto: 6000.00
Imposto: 1000.00
Funcionário: Joao Silva, $ 5000.00
Digite a porcentagem para aumentar o salário: 10.0
Dados atualizados: Joao Silva, $ 5600.00  */

using Exercicio_POO_04_Funcionario;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Funcionario func = new Funcionario();

        Console.WriteLine("Digite os dados do funcionário: ");
        Console.Write("Nome: ");
        func.Nome = Console.ReadLine();
        Console.Write("Salario Bruto: ");
        func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine("Funcionário: " + func + "\n");

        Console.WriteLine("Digite a porcentagem para aumentar o salário do funcionário: " + func.Nome);
        double porcentagemDeAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        func.AumentarSalario(porcentagemDeAumento);
        Console.WriteLine();
        Console.WriteLine(func);
    }
}