using System.Globalization;

namespace Exercicio_POO_04_Funcionario
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido() => SalarioBruto - Imposto;
        public void AumentarSalario(double porcentagem) => SalarioBruto += ((SalarioBruto * porcentagem) / 100);

        public override string ToString()
        {
            return "Dados Atualizados: " +
                Nome + ", " +
                "R$: " +
                SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
