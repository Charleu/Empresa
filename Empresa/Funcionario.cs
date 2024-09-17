using System;

namespace Empresa
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int HorasTrab {  get; set; }
        public double ValorHora { get; set; }

        public Funcionario(string nome, int horasTrab, double valorHora)
        {
            Nome = nome;
            HorasTrab = horasTrab;
            ValorHora = valorHora;
        }

        public virtual double Pagamento()
        {
            return HorasTrab * ValorHora;
        }
    }

}
