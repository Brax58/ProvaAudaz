using ProvaAudaz.Controller;
using ProvaAudaz.Model;
using System;

namespace ProvaAudaz
{
    class Program
    {
        static void Main(string[] args)
        {
            int again;

            var controller = new FareController();

            do
            {
                Console.WriteLine("Informe o valor da tarifa a ser cadastrada:");
                var valorTarifa = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Informe o código da operadora para a tarifa:");
                Console.WriteLine("Exemplos: OP01, OP02, OP03...");
                var operatorCode = Console.ReadLine();

                var fareModel = new FareModel(operatorCode, valorTarifa);

                controller.CreateFare(fareModel);

                Console.WriteLine("Tarifa cadastrada com sucesso!");

                Console.WriteLine("Deseja continuar? (S/N)");
                var createAgain = Console.ReadLine();

                again = createAgain == "S" || createAgain == "s" ? 1 : 0;

                Console.Clear();

            } while (again == 1);

            Console.Read();
        }
    }
}
