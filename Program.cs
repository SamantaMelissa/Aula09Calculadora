using System;

namespace Aula09Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCientifica calc = new CalculadoraCientifica();
            Console.WriteLine("Digite uma das 5 operações (soma, multiplicação, subtração, divisão e potência). No seguinte formato: 20 x 2");
            calc.ControlarMetodos( Console.ReadLine() );
            Console.WriteLine("Resultado:"+calc.resultado);

            Console.WriteLine("Digite números separados por ponto e vírgula (;) para calcular a mídia");
            calc.CalcularMedia(Console.ReadLine());
             Console.WriteLine("Resultado da média:"+calc.resultado);

            

  
  
         }
    }
}
