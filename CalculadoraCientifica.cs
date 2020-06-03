namespace Aula09Calc
{
    public class CalculadoraCientifica : Calculadora
    {
        private string [] valores { get; set;}

        private float soma { get; set; }

        public void CalcularMedia(string txtConsole){
                //SPLIT ---> Separa sentenças, números... Como: 20;15;10;5
                // valores[0] = 20
                // valores [1] = 15
                // valores [2] = 10
                // valores [3] = 5
                
            valores = txtConsole.Split(";");

            for (int i = 0; i < valores.Length; i++)
            {
                //Varredor de valores
                soma += float.Parse(valores[i]);
            }

            resultado = soma / valores.Length;
        }

        public void ControlarMetodos(string entradaUsuario){
                // 20 x 2
                // dados [0] = 20
                // dados [1] = x
                // dados [2] = 2
            string[] dados = entradaUsuario.Split(" ");

            operador = dados[1];
            num1 = float.Parse(dados[0]);
            num2 = float.Parse(dados[1]);
            num3 = int.Parse(dados[2]);
            num4 = int.Parse(dados[3]);

            switch (operador)
            {
                case "+":
                Somar();
                break;

                case "-":
                Subtrair();
                break;

                case "/":
                Dividir();
                break;
                
                case "*":
                Multiplicar();
                break;

                case "^":
                Potencia();
                break;


                default:
                Somar();
                break;
            }
        }
    }
}