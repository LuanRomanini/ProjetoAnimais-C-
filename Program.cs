using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace projeto_estimação
{
    internal class Program
    {
        static void Main(string[] args)
        {
 

            Console.WriteLine("############################");
            Console.WriteLine("Projeto Animais de Estimação");
            Console.WriteLine("############################");





            //Recebe os animais
            List<(string animal, double peso)> list = new List<(string animal, double peso)>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o Nome do animal: ");
                string animal = Console.ReadLine();


                Console.WriteLine("Digite o Peso Do Animal: ");
                double peso = double.Parse(Console.ReadLine());

                list.Add((animal, peso));
            }

            


            //Encontra o Peso Do Menor Animal
            (string animal, double peso) MenorPeso = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].peso < MenorPeso.peso)
                {
                    MenorPeso = list[i];
                }
            }

            Console.WriteLine($"Animal com o menor peso e: {MenorPeso.animal} tendo {MenorPeso.peso} kg");
            Console.WriteLine("--Digite ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
