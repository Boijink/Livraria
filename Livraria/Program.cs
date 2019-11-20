using System;

namespace Livraria {
    class Program {
        static void Main(string[] args) {
            int cod = 0, qtd = 0, totalItens = 0, totalSom = 0;

            Console.WriteLine("\n\nLivraria\n");
            Console.WriteLine("Cod 1 - Harry Potter e a pedra filosofal");
            Console.WriteLine("Cod 2 - Harry Potter e a câmara secreta");
            Console.WriteLine("Cod 3 - Harry Potter e o prisioneiro de azkaban");
            Console.WriteLine("Cod 4 - Harry Potter e o cálice de fogo");
            Console.WriteLine("Cod 5 - Harry Potter e a ordem da fênix");
            Console.WriteLine("Cod 6 - Harry Potter e o enigma do príncipe");
            Console.WriteLine("Cod 7 - Harry Potter e as relíquias da morte");
            Console.WriteLine("Tecle '999' para finalizar o pedido\n");

            do {
                Console.Write("\nDigite o código que desejar: ");
                cod = int.Parse(Console.ReadLine());
                if (cod != 999) {
                    Console.Write("Digite a quantidade de cópias: ");
                    qtd = int.Parse(Console.ReadLine());
                    totalItens += qtd;
                    totalSom ++;
                } else {
                    break;
                }
            } while (cod != 999);

            Console.Clear();

            if (totalItens == 2 || totalSom == 2) { //5%
                double valor = totalItens * 42.0;
                double totalComDesc = (valor - ((5.0 / 100.0) * valor));
                Console.WriteLine("Ganhou 5% de desconto, total de: R$  " + totalComDesc);
            } else if (totalItens == 3 || totalSom == 3) { //10%
                double valor = totalItens * 42.0;
                double totalComDesc = (valor - ((10.0 / 100.0) * valor));
                Console.WriteLine("Ganhou 10% de desconto, total de: R$  " + totalComDesc);
            } else if (totalItens == 4 || totalSom == 4) { //15%
                double valor = totalItens * 42.0;
                double totalComDesc = (valor - ((15.0 / 100.0) * valor));
                Console.WriteLine("Ganhou 15% de desconto, total de: R$  " + totalComDesc);
            } else if (totalItens >= 5 || totalSom == 5) { //20%  
                double valor = totalItens * 42.0;
                double totalComDesc = (valor - ((20.0 / 100.0) * valor));
                Console.WriteLine("Ganhou 20% de desconto, total de: R$ " + totalComDesc);
            }else if (totalItens == 1 || totalSom == 1) {
                double valor = totalItens * 42.0;
                Console.WriteLine("Sem desconto, total de: R$ " + valor);
            }
        }
    }
}