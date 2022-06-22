namespace Exercicio3
{
    public class Calculadora
    {
        public double Resultado = 0;

        public Calculadora()
        {
                    
            int continuar = 1;
            while (continuar == 1)
            {
                Menu();
                Console.Write("\nDigite 1 para continuar e 2 para sair: ");
                continuar = int.Parse(Console.ReadLine());
            }
        }

        private void Menu()

        {
            
            Console.WriteLine("\n| Calculadora |");
            Console.WriteLine("\n----\nMENU\n----\n1-Somar\n2-Subtrair\n3-Dividir\n4-Multiplicar\n");
            Console.Write("Escolha a operação: ");
            
            int escolha = int.Parse(Console.ReadLine());

            if (escolha >= 1 && escolha <= 4)
            {
                Console.Write("\nDigite o 1º valor: ");
                string Valor1 = Console.ReadLine();

                Console.Write("\nDigite o 2º valor: ");
                string Valor2 = Console.ReadLine();

                double ValorInserido1;
                double ValorInserido2;
                bool Converter1 = double.TryParse(Valor1, out ValorInserido1);
                bool Converter2 = double.TryParse(Valor2, out ValorInserido2);

                try
                {
                    if (Converter1 == false || Converter2 == false)
                    {
                        throw new Exception("\nERRO! Insira apenas números");                        
                    }
                    else
                    {
                        ValorInserido1 = Convert.ToDouble(Valor1);
                        ValorInserido2 = Convert.ToDouble(Valor2);
                    }
                }
                catch (Exception Error)
                {
                    Console.WriteLine(Error.Message);
                }

                switch (escolha)
                {
                    case 1:
                        Somar(ValorInserido1, ValorInserido2);
                        break;
                    case 2:
                        Subtrair(ValorInserido1, ValorInserido2);
                        break;
                    case 3:
                        Dividir(ValorInserido1, ValorInserido2);
                        break;
                    case 4:
                        Multiplicar(ValorInserido1, ValorInserido2);
                        break;
                    default:
                        Menu();
                        break;
                }
                
            }
            else
            {
                Console.WriteLine("Opção Inválida! Tente novamente.");
                
            }
        }
                   

        private void Somar(double Valor1, double Valor2)
        {
            Resultado = Valor1 + Valor2;
            Console.Write($"\nTOTAL: {Resultado}\n");

        }

        private void Subtrair(double Valor1, double Valor2)
        {
            Resultado = Valor1 - Valor2;
            Console.Write($"\nTOTAL: {Resultado}\n");
        }

        private void Dividir(double Valor1, double Valor2)
        {
            try
            {
                if (Valor2 == 0)
                {
                    throw new Exception("\nERRO! Não é possível dividir por 0");
                                 }
                else
                {
                    Resultado = Valor1 / Valor2;
                    Console.Write($"\nTOTAL: {Resultado}\n");
                }

            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.Message);
            }
        }

        private void Multiplicar(double Valor1, double Valor2)
        {
            Resultado = Valor1 * Valor2;
            Console.Write($"\nTOTAL: {Resultado}\n");
        }
    }
}
