using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Viatura fiat = new Viatura("Fiat", "600");
            // fiat.marca = "Fiat";
            // fiat.modelo = "600";
            //fiat.velocidade = 0;
            fiat.acelera(120);
            fiat.ver();

            Viatura ford = new Viatura("Ford", "Fiesta", 100);
            fiat.ver();

            for (int v = 1; v <= 5; v++)
            {
                ford.acelera(r.Next(0, 50));
                ford.ver();
                Thread.Sleep(200);
                fiat.acelera(r.Next(0, 50));
                fiat.ver();
            }

            Console.WriteLine("Vencedor:");
            Viatura vencedor = (fiat.distancia > ford.distancia) ? fiat : (fiat.distancia == ford.distancia) ? null : ford;
            if (vencedor == null) Console.WriteLine("Empate!");
            else vencedor.ver();

        }
    }
}