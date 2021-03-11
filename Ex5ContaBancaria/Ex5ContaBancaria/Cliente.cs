using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5ContaBancaria
{
    class Cliente
    {
        //--------------------[PROP. AUTO IMPLEMENTADAS]
        public string NomeTitular { get; set; }     //Propriedades sempre com a 1ª Letra MAIÚSCULA.
        public double Saldo { get; private set; }   //Em C# double e int já iniciam valendo 0.0
        public int NumConta { get; private set; }   //usando Propriedades Auto Implementadas, posso usa-las como se fossem um atributo comum, respeitando as restrições de privacidade de cada propriedade.
        
        //--------------------[CONSTRUTORES]
        public Cliente(string nomeTitular, int numConta)
        {
            NomeTitular = nomeTitular;           
            NumConta = numConta;
        }

        public Cliente(string nomeTitular, int numConta, double saldo) : this(nomeTitular, numConta) //Usando a função this para herdar as informações do primeiro construtor aqui na sobrecarga.
        {
            Saldo = saldo;  //Como não havia o saldo para herde do primeiro construtor, "seto" ele aqui na sobrecarga.
        }

        //--------------------[MÉTODOS]
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        public override string ToString()   //Usar a função "override string ToString()" para imprimir dados na tela.
        {
            return "\n*Titular: " + NomeTitular + "\n*Nº Conta: " + NumConta + "\n*Saldo: R$ " + Saldo;
        }

    }
}
