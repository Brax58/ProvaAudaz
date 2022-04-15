using ProvaAudaz.Controller;
using System;
using TestePleno.Models;

namespace TestePleno
{
    class Program
    {
        private int ControllerInstance = 0;

        static void Main(string[] args)
        {
            int again = 0;

            var controller = new FareController();

            do
            {
                Console.WriteLine("Informe o valor da tarifa a ser cadastrada:");
                var valorTarifa = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Informe o código da operadora para a tarifa:");
                Console.WriteLine("Exemplos: OP01, OP02, OP03...");
                var operatorCodeInput = Console.ReadLine();

                var fareModel = new FareModel(operatorCodeInput, valorTarifa);

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
