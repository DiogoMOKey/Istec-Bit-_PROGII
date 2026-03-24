using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Aula1
{
    internal class Viatura
    {
        internal static int total; // Variaveis com "STATIC" não passa para o object, ficam na class Exemplo: O Total vai mostrar o mesmo valor em todos os objetos desta classe
        //campos
        internal string modelo;
        internal string marca;
        internal int velocidade;
        internal int distancia = 0;

        //Metodos
        internal void acelera(int delta)
        {
            this.velocidade += delta;
            this.distancia += velocidade;
        }

        internal Viatura(string pmarca, string pmodelo, int pvelocidade = 0)
        {
            this.modelo = pmodelo;
            this.marca = pmarca;
            this.velocidade = pvelocidade;
            Viatura.total++;
        }



        internal void ver()
        {
            Console.WriteLine($"Marca: {this.marca} \nModelo: {modelo} \n{velocidade}km \nDistancia:{distancia} \nCarros em pista: {total}");
        }



    }
}
