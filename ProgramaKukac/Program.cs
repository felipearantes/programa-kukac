using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaKukac
{
    class Program
    {
        static void DadosUsuario ()
        {
            string nome, cep;
            double rendaMensal, numeroDependentes;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();
            if (nome == "")
            {
                nome = null;
            }
            Console.Write("Informe seu CEP: ");
            cep = Console.ReadLine();
            while (cep.Length != 8)
            {
                Console.WriteLine("CEP invalido!!!");
                Console.Write("Informe novamente seu CEP: ");
                cep = Console.ReadLine();
            }
            Console.Write("Informe a renda mensal da familia: R$ ");
            rendaMensal = Convert.ToDouble(Console.ReadLine());
            while (rendaMensal < 0)
            {
                Console.WriteLine("Renda mensal invalida!!!");
                Console.Write("Informe novamnete a renda mensal da familia: R$ ");
                rendaMensal = Convert.ToDouble(Console.ReadLine());

            }
            Console.Write("Informe o numero de dependentes: ");
            numeroDependentes = Convert.ToDouble(Console.ReadLine());

            RetornoAquisiçao(nome, cep, rendaMensal, numeroDependentes);
        }

        static void RetornoAquisiçao (string pNome, string pCep, double pRendaMensal, double NumeroDependentes)
        {
            double rendaPerCapita;

            rendaPerCapita = pRendaMensal / NumeroDependentes;
            Console.WriteLine("\n---------------------------------------------");
            if (pNome != null)
            {
                Console.WriteLine("Nome: {0}", pNome);
            }
            Console.WriteLine("O CEP é: {0}", pCep);
            Console.WriteLine("A renda per capita desta familia é: {0}", rendaPerCapita.ToString("C2"));
        }

        static void Main(string[] args)
        {
            DadosUsuario();
            Console.ReadKey();
        }
    }
}
