using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    public static class Calculos
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
    }
    public class Produto
    {
        private int Id;

        public int Estoque { get; } // ou public readonly int Estoque;
        public string Descricao { get; set; }

        public Produto() //Construtor da classe
        {
            Estoque = 5;
        }

        public void ImprimirDescricao()
        {
            Console.WriteLine($"O ID do produto é:{GetId()} e o produto é: {Descricao}");
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }
    }

    public class Pessoa
    {
        public int Id { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Cep { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Codigo: " + Id);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("Cep: " + Cep);
        }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public void ImprimirCPF()
        {
            Console.WriteLine("CPF: " + CPF);
        }
    }

    public class Funcionario : PessoaFisica
    {
        public string Matricula { get; set; }
    }

    public sealed class Configuracao
    {
        public string Host { get; set; }
    }

    public abstract class Animal
    {
        public string Nome { get; set; }

        public abstract string GetInformacoes();

        public void ImprimirDados()
        {
            Console.WriteLine($"O nome do animal é: {Nome}");
            Console.WriteLine($"Informações: {GetInformacoes().ToString()}");
        }
    }
    public class Cachorro : Animal
    {
        public override string GetInformacoes()
        {
            return "Cachorro é um bom amigo";
        }
    }
}
