namespace Aula09Calc
{
    public class Calculadora
    {
       public float num1 { get; set; }
       public float num2 { get; set; }
       public int num3 { get; set; }
       public int num4 { get; set; }
       public float resultado { get; set; }
       public string operador { get; set; }

       public void Somar(){
           resultado = 0;
           resultado = num1 + num2;
       }
       public void Subtrair(){
           resultado = 0;
           resultado = num1 - num2;
       }
       public void Multiplicar(){
           resultado = 0;
           resultado = num1 + num2;
       }
       public void Dividir(){
           resultado = 0;
           resultado = num1 / num2;
       }
       public void Potencia(){
           resultado = 0;
           resultado = num3 ^ num4;

       }










    }
}