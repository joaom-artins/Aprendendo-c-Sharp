using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_3  // Note: actual namespace depends on the project name.
{
    class Conta{

        public double saldo;
        public double valorPagar=0;
        public double valorReceber=0;
        public void pagar(double saida){
            saldo-=saida;
        }
        public void receber(double entrada){
            saldo+=entrada;
        }
        }

     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao seu controlador financeiro!");
            Conta c1=new Conta();
            Console.WriteLine("Informe o saldo atual:");
            c1.saldo=Convert.ToDouble(Console.ReadLine());
            int escolha;
            do{

            Console.WriteLine("1-Retirar\n2-Coloar\n3-Sair\n{0}",c1.saldo);
            escolha = Convert.ToInt32(Console.ReadLine());
            switch(escolha){
                case 1:
                double saida;
                Console.WriteLine("Digite o valor que irá retirar da sua conta:");
                saida = Convert.ToDouble(Console.ReadLine());
                c1.pagar(saida);
                break;
                case 2:
                double entrada;
                Console.WriteLine("Digite o valor que irá colocar da sua conta:");
                entrada = Convert.ToDouble(Console.ReadLine());
                c1.receber(entrada);
                break;
                case 3:
                Console.WriteLine("Saindo");
                break;
                default:
                Console.WriteLine("Valor inválido");
                break;
            }
            }while(escolha!=3);
        }
    }
}
