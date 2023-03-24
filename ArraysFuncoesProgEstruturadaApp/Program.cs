using System.Reflection.Metadata.Ecma335;

namespace ArraysFuncoesProgEstruturadaApp
{
    internal class Program
    {
        static int[] valores = new int[] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };
        static int maiorValor, menorValor , valorMedio, valoresNegativos, mostrarNaTela, opcao, excluirValor;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                GerarMenu();

                switch (opcao)
                {
                    case 1:
                        GerarMaiorValor();
                        break;
                    case 2:
                        GerarMenorValor();
                        break;
                    case 3:
                        GerarMediaValores();
                        break;
                    case 4:
                        GerarTresMaioresValores();
                        break;
                    case 5:
                        GerarValoresNegativos();
                        break;
                    case 6:
                        GerarTodosOsValores();
                        break;
                    case 7:
                        ExcluirNumeroArray();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
                continue;
            } while (true);

        }

        static void GerarMenu()
        {
            Console.WriteLine("Digite 1 para encontrar  o maior valor.");
            Console.WriteLine("Digite 2 para encontrar o menor valor.");
            Console.WriteLine("Digite 3 para encontrar o valor médio da sequência.");
            Console.WriteLine("Digite 4 para encontrar os três maiores valores.");
            Console.WriteLine("Digite 5 para encontrar os valores negativos da sequência.");
            Console.WriteLine("Digite 6 para mostrar na tela os valores da sequência.");
            Console.WriteLine("Digite 7 para excluir um valor.");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
        static void GerarMaiorValor()
        {
            foreach (int valor in valores)
            {
                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }
            }
            Console.WriteLine(maiorValor);
            Console.ReadLine();
        }

        static void GerarMenorValor()
        {
            foreach (int valor in valores)
            {
                if (valor < menorValor)
                {
                    menorValor = valor;
                }
            }
            Console.WriteLine(menorValor);
            Console.ReadLine();
        }

        static void GerarMediaValores()
        {
            int soma = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }
            int resultadoMedia = soma / valores.Length;
            Console.WriteLine(resultadoMedia);
            Console.ReadLine();
        }

        static void GerarTresMaioresValores()
        {   //Perguntar sobre este trecho de código.
            int[] arrayTresMaiores = new int[3];

            int[] arrayCopia = new int [valores.Length];

            for (int i = 0; i < valores.Length; i++)
            {
                arrayCopia[i] = valores[i];
            }

            for (int i = 0; i < 3; i++)
            {
                maiorValor = 0;

                foreach (var item in arrayCopia)
                {
                    if (item > maiorValor)
                    {
                        maiorValor = item;
                        arrayTresMaiores[i] = maiorValor;
                    }
                }
                int index = Array.IndexOf(arrayCopia, maiorValor);
                Array.Clear(arrayCopia, index, 1);
            }
            foreach (var item in arrayTresMaiores)
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();
        }

        static void GerarValoresNegativos()
        {
            int[] valoresNegativos = new int[3];

            int[] arrayCopia = new int[valores.Length];

            for (int i = 0; i < valores.Length; i++)
            {
                arrayCopia[i] = valores[i];
            }

            for (int i = 0; i < 3; i++)
            {
                int negativos = 0;

                foreach (var item in arrayCopia)
                {
                    if (item < negativos)
                    {
                        negativos = item;
                        valoresNegativos[i] = negativos;
                    }
                }
                int index = Array.IndexOf(arrayCopia, negativos);
                Array.Clear(arrayCopia, index, 1);
            }
            foreach (var item in valoresNegativos)
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();
        }

        static void GerarTodosOsValores()
        {
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write(valores[i] + "  ");
            }
            Console.ReadLine();
        }

        static void ExcluirNumeroArray()
        {
            foreach (int valor in valores)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Qual número você quer excluir?");
            excluirValor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < valores.Length; i++)
            {
                if (excluirValor == valores[i])
                {
                    valores[i] = 0;
                }
            }

            foreach (int valor in valores)
            {
                Console.Write(valor + " ");
            }
            Console.ReadLine();
            //int[] arrayCopia = new int[valores.Length];

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    arrayCopia[1] = valores[i];
            //}

            //for (int i = 0;  i < valores.Length; i++)
            //{
            //    for (int i = 0; valores.Length; i++)
            //    {
            //        foreach (var item in arrayCopia)
            //        {

            //        }
            //    }
            //}
        }
    }
}