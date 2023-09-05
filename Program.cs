namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem Vindo a Calculadora, Digite Pra Mim qual operação Deseja Executar? \n");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair Da Calculadora");
            Console.Write("\n\n>_ ");
            short res = short.Parse(Console.ReadLine());
            switch (res)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }
        static void Soma()
        {
            Console.Write("\nPrimeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("\nSegundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float res = v1 + v2;
            Console.Clear();
            Console.WriteLine($"Resultado da Soma entre: {v1} + {v2} = {res}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Write("\nPrimeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("\nSegundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float res = v1 - v2;
            Console.Clear();
            Console.WriteLine($"Resultado da Subtração entre: {v1} - {v2} = {res}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Write("\nPrimeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("\nSegundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float res = v1 * v2;
            Console.Clear();
            Console.WriteLine($"Resultado da Subtração entre: {v1} * {v2} = {res}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Write("\nPrimeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("\nSegundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float res = v1 / v2;
            Console.Clear();
            Console.WriteLine($"Resultado da Subtração entre: {v1} / {v2} = {res}");
            Console.ReadKey();
            Menu();
        }
    }
}