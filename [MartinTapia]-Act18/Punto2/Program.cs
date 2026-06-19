using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2.
    Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
    La clase CriaturaMarina debe tener como atributos privados: Especie (string),
    ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
    propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
    ● La profundidad óptima sea estrictamente mayor a cero (0).
    ● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
    asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
    La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
    de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
    criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
    a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
    nivel de salinidad para sobrevivir. 
    */

    internal class CriaturaMarina
    {
        private string especie;
        private int profundidadOptima;
        private int nivelSalinidad;

        public string Especie
        {
            set
            {
                especie = value;
            }
            get
            {
                return especie;
            }
        }

        public int ProfundidadOptima
        {
            set
            {
                if (value > 0)
                {
                    profundidadOptima = value;
                }
                else
                {
                    Console.WriteLine("La profundidad optima debe ser mayor a 0");
                }
            }
            get
            {
                return profundidadOptima;
            }
        }

        public int NivelSalinidad
        {
            set
            {
                if (value >= 0 || value <= 100)
                {
                    nivelSalinidad = value;
                }
                else
                {
                    nivelSalinidad = 35;
                }
            }
            get
            {
                return nivelSalinidad;
            }
        }

    }

    internal class HabitatAcuatico
    {
        private CriaturaMarina[] criatura = new CriaturaMarina[3];

        public HabitatAcuatico()
        {
            for (int i = 0; i < criatura.Length; i++)
            {
                criatura[i] = new CriaturaMarina();
            }

            for (int j = 0; j < criatura.Length; j++)
            {
                Console.WriteLine("Ingrese la especie: ");
                criatura[j].Especie = Console.ReadLine();
                Console.WriteLine("Ingrese la profundidad optima: ");
                criatura[j].ProfundidadOptima = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nivel de salinidad: ");
                criatura[j].NivelSalinidad = int.Parse(Console.ReadLine());
            }
        }

        public void Ordenar()
        {
            int aux = 0;
            string aux2;
            int aux3 = 0;
            for (int i = 0; i < criatura.Length - 1; i++)
            {
                for (int j = 1; j < criatura.Length; j++)
                {
                    if (criatura[i].ProfundidadOptima > criatura[j].ProfundidadOptima)
                    {
                        aux = criatura[i].ProfundidadOptima;
                        criatura[i].ProfundidadOptima = criatura[j].ProfundidadOptima;
                        criatura[j].ProfundidadOptima = aux;

                        aux2 = criatura[i].Especie;
                        criatura[i].Especie = criatura[j].Especie;
                        criatura[j].Especie = aux2;

                        aux3 = criatura[i].NivelSalinidad;
                        criatura[i].NivelSalinidad = criatura[j].NivelSalinidad;
                        criatura[j].NivelSalinidad = aux3;
                    }
                }
            }

            for (int y = 0; y < criatura.Length; y++)
            {
                Console.WriteLine("=-=-=-= Datos Criatura Maritima =-=-=-=");
                Console.WriteLine("Especie: " + criatura[y].Especie);
                Console.WriteLine("Profundidad Optima: " + criatura[y].ProfundidadOptima);
                Console.WriteLine("Nivel Salinidad: " + criatura[y].NivelSalinidad);
            }
        }

        public void MayorSanilidad()
        {
            int mayor = criatura[0].NivelSalinidad;
            int pos = 0;

            for (int i = 0; i < criatura.Length; i++)
            {
                if (criatura[i].NivelSalinidad > mayor)
                {
                    mayor = criatura[i].NivelSalinidad;
                    pos = i;
                }
            }

            Console.WriteLine("La especie " + criatura[pos].Especie + " requiere el mayor nivel de salinidad para sobrevivir con " + mayor);
        }


        static void Main(string[] args)
        {
            HabitatAcuatico ha2 = new HabitatAcuatico();
            ha2.Ordenar();
            ha2.MayorSanilidad();
            Console.ReadKey();
        }
    }
}
