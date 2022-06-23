using System;

namespace Arreglo6
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.- Ingresar 3 valores de los lados de un triangulo por consola, según los valores de sus lados indicar que tipo de Triangulo es ; Equilatero, Isosceles o Escaleno.
            
            int[] Medidas = new int[3];

            for (int i=0;i<Medidas.Length;i++)
            {
                Console.WriteLine("Lado " + i);
                Console.WriteLine("Ingrese el valor del lado");
                Medidas[i]=Convert.ToInt32(Console.ReadLine());
                //Medidas[i]=Convert.ToInt32(Console.ReadLine());

            }
            if (Medidas[0] == Medidas[1] && Medidas[0] == Medidas[2]){
                Console.WriteLine("TRIANGULO EQUILATERO");
            }else if(Medidas[0]==Medidas[1] || Medidas[0] == Medidas[2] || Medidas[2] == Medidas[1])
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }else if(Medidas[0]!=Medidas[1] || Medidas[1] != Medidas[2] || Medidas[2] != Medidas[0])
            {
                Console.WriteLine("TRIANGULO ESCANELO");
            }
        
            Console.ReadKey();

        }
    }
}
