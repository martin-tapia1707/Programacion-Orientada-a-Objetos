using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            2. Realizar un programa que lea los lados de n triángulos, e informar:
            a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
            iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
            b) Cantidad de triángulos de cada tipo.
            c) Tipo de triángulo que posee menor cantidad. 
            */

            int n, lado1, lado2, lado3, cantEquil, cantIsos, cantEscal, menor;
            string valor;

            cantEquil = 0;
            cantEscal = 0;
            cantIsos = 0;


                Console.WriteLine("Cuantos triangulos va a insertar?: ");
                valor = Console.ReadLine();
                n = int.Parse(valor);

            for (int i = 0; i < n; i++) {

                Console.Write("Inserta el primer lado: ");
                valor = Console.ReadLine();
                lado1 = int.Parse(valor);

                Console.Write("Inserta el segundo lado: ");
                valor = Console.ReadLine();
                lado2 = int.Parse(valor);

                Console.Write("Inserta el tercer lado: ");
                valor = Console.ReadLine();
                lado3 = int.Parse(valor);

                if (lado1 == lado2 && lado2 == lado3) {

                    Console.WriteLine("El triangulo ingresado es Equilatero");
                    cantEquil++;
                } 
                
                else if ( lado1 == lado2 || lado2 == lado3 || lado1 == lado3) {

                    Console.WriteLine("El triangulo ingresado es Isosceles");
                    cantIsos++;

                }

                else {

                    Console.WriteLine("El triangulo es Escaleno");
                    cantEscal++;

                }

                Console.WriteLine("INSERTAR SIGUIENTE TRIANGULO");

            }

            Console.WriteLine("Cantidad final de triangulos Equilateros: " + cantEquil);
            Console.WriteLine("Cantidad final de triangulos Isosceles: " + cantIsos);
            Console.WriteLine("Cantidad final de triangulos Escalenos: " + cantEscal);

            if (cantEquil < cantIsos && cantEquil < cantEscal) {

                menor = cantEquil;
                Console.Write("El triangulo que posee menor cantidad es el Equilatero con " + menor);

            }

            if (cantIsos < cantEquil && cantIsos < cantEscal) {

                menor = cantIsos;
                Console.Write("El triangulo que posee menor cantidad es el Isosceles con " + menor);

            }

            if (cantEscal < cantIsos && cantEscal < cantEquil) {

                menor = cantEscal;
                Console.Write("El triangulo que posee menor cantidad es el Escaleno con " + menor);

            }

            Console.ReadKey();

        }
    }
}
