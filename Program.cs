using System;

namespace Exercicio_AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {

            double Base , Altura, resultado;


            Console.Write("-------Área de Um Triangulo Retangulo-------");
            Console.WriteLine(); 
            
            Console.Write("Digite a base: "); 
            Base = Convert.ToDouble(Console.ReadLine());
            
                Console.Write("Digite a Altura: ");
                Altura = Convert.ToDouble(Console.ReadLine());


                resultado = (Base*Altura)/2;
                Console.WriteLine($"Resultado da Área: {resultado}");


        }
    }       
}    
