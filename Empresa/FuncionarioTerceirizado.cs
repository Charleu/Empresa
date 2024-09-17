namespace Empresa
{
    public class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional { get; set; }

        public FuncionarioTerceirizado(string nome, int horasTrab, double valorHora, double despesaAdicional)
            : base(nome, horasTrab, valorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DespesaAdicional;
        }
    }
}
