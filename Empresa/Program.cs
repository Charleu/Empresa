using System;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Informe a quantidade de funcionários: ");
            int quantidade = int.Parse(Console.ReadLine());

            Funcionario[] funcionarios = new Funcionario[quantidade];

            int i = 0;
            while (i < quantidade)
            {
                Console.Write("Funcionário próprio (p) ou terceirizado (t):");
                char tipo = char.Parse(Console.ReadLine());

                if (tipo == 'p')
                {
                    Console.Write("Funcionário Próprio\n");
                    Console.Write("Nome:\n");
                    string nome = Console.ReadLine();
                    Console.Write("Horas trabalhadas:\n");
                    int horas = int.Parse(Console.ReadLine());
                    Console.Write("Valor por hora:\n");
                    double valor = double.Parse(Console.ReadLine());
                    funcionarios[i] = new Funcionario(nome, horas, valor);
                }
                else if (tipo == 't')
                {
                    Console.WriteLine("Funcionário Terceirizado\n");
                    Console.Write("Nome:\n");
                    string nome = Console.ReadLine();
                    Console.Write("Horas trabalhadas:\n");
                    int horas = int.Parse(Console.ReadLine());
                    Console.Write("Valor por hora:\n");
                    double valor = double.Parse(Console.ReadLine());
                    Console.Write("Despesa adicional:\n");
                    double despesa = double.Parse(Console.ReadLine());
                    funcionarios[i] = new FuncionarioTerceirizado(nome, horas, valor, despesa);
                }
                i++;
            }

            Console.Clear();
            Console.WriteLine("\nPagamentos:\n");
            i = 0;
            while (i < quantidade)
            {
                Funcionario f = funcionarios[i];
                Console.WriteLine($"{f.Nome}:\n Pagamento: {f.Pagamento():F2}\n");
                i++;
            }

            Console.ReadKey();
        }
    }
}

