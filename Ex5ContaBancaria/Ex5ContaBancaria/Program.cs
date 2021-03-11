using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta,");
            Console.WriteLine("o nome do titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta."); 
            Console.WriteLine("Este valor de depósito inicial, entratanto, é opcional, ou seja: se o titular não tiver dinheiro a ");
            Console.WriteLine("depositar no momento de abrir sua conta, o depósito inicial não será feito e o saldo inicial da conta");
            Console.WriteLine("será, naturalmente, zero. Importanto: uma vez que a conta bancária foi aberta, o número da conta nunca");
            Console.WriteLine(" poderá ser alterado. Já o nome do titular pode ser alterado(pois uma pessoa pode mudar de nome por ocasião");
            Console.WriteLine(" do casamento, por exemplo). Por fim, o saldo da conta não pode ser alterado livremente.  É preciso haver");
            Console.WriteLine("um mecanismo para proteger isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques.");
            Console.WriteLine("Para cada saque realizado, o banco cobra uma taria de 5 reais.Nota: a conta pode ficar com saldo negativo.");
            Console.WriteLine("\nVocê deve fazer um programa que realize o cadastro de uma conta, dando a opção para que seja ou não informado");
            Console.WriteLine("o valor de depósito inicial.em seguida, realizar um depóito e depois um saque com tarifa de 5 reais,");
            Console.WriteLine("sempre mostrando os dados da conta após cada operação.");

            Cliente pessoa1;                //Criei meu objeto "pessoa1" do tipo Cliente, vou instancia-lo a seguir usando os os construtores

            Console.WriteLine(" ***Banco Digital ***");
            Console.Write("\nDigite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("\nDigite o numero da sua conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("\nDeseja fazer um depósito Inicial (s/n)?: ");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 's' || resp == 'S')
            {
                Console.Write("\nDigite o valor do depósito Inicial: R$ ");
                double depositoInicial = double.Parse(Console.ReadLine());

                pessoa1 = new Cliente(nome, conta, depositoInicial);       //passo minhas variáveis para preencher os parâmetros do meu segundo contrutor.

            }
            else
            {
                pessoa1 = new Cliente(nome, conta);         //passo apenas dois parâmetros, pois este é meu primeiro modelo de Construtor, para o caso de não setar um valor de "saldo" no começo.  
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(pessoa1);   //Como usei a fuñção toString na minha classe, organizando todas as informações de saída, aqui posso só imprimir o objeto.

            Console.WriteLine("Digite um valor de depósito: ");
            double deposito = double.Parse(Console.ReadLine());

            pessoa1.Deposito(deposito);

            Console.WriteLine("Digite um valor de saque: ");
            double saque = double.Parse(Console.ReadLine());

            pessoa1.Saque(saque);

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(pessoa1);   //Como usei a fuñção toString na minha classe, organizando todas as informações de saída, aqui posso só imprimir o objeto.


            Console.ReadKey();
        }
    }
}
