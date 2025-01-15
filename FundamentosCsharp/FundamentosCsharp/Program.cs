using System;
using System.Diagnostics;

namespace Application
{
    public class Program
    {

        static void Main(string[] args)
        {
            //AulaPropSomenteLeitura();
            //AulaHeranca();
            //AulaClasseSelada();
            AulaClasseAbstrada();
        }

        private static void AulaClasseAbstrada()
        {
            var animal = new Produtos.Cachorro();
            animal.Nome = "Cão";
            animal.ImprimirDados();

        }
        private static void AulaClasseSelada()
        {
            //var configuracao = new Produtos.Configuracao();
            //configuracao.Host = "localhost";
            var config = new Produtos.Configuracao
            {
                Host = "localhost"
            };

            Console.WriteLine(config.Host);

        }

        private static void AulaHeranca()
        {
            /*var pessoaFisica = new Produtos.PessoaFisica();
            pessoaFisica.Id = 1;
            pessoaFisica.Endereco = "Rua Calados";
            pessoaFisica.Cep = "05736100";
            pessoaFisica.Cidade = "São Paulo";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCPF();*/

            var funcionario = new Produtos.Funcionario();
            funcionario.Id = 10;
            funcionario.Endereco = "Rua Calados";
            funcionario.Cep = "05736100";
            funcionario.Cidade = "São Paulo";
            funcionario.CPF = "12345678920";

            funcionario.ImprimirDados();
            funcionario.ImprimirCPF();
        }

        private static void AulaClasses()
        {
            var resultado = Produtos.Calculos.Somar(1, 2);
            Console.WriteLine(resultado);

            //var produto = new Produtos.Produto();

            //produto.SetId(1);
            //produto.Descricao = "Teclado";
            //produto.ImprimirDescricao();
        }

        private static void AulaPropSomenteLeitura()
        {
            var produto = new Produtos.Produto();
            produto.Descricao = "Mouse";
            //produto.Estoque = 1; não posso atribuir valor pois essa é uma prop de somente de leitura, e só posso passar valor pelo construtor dentro da classe
            Console.WriteLine($"O produto é: {produto.Descricao} e a quantidade em estoque é: {produto.Estoque}");
        }
    }
}