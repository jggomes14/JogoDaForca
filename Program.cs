using System;
using System.Drawing;

namespace Forca
{
    internal class Program
    {
        static void ArrumarPalavras(string _palavras, char[] respostas)
        {

            for (int i = 0; i < _palavras.Length; i++)
            {
                respostas[i] = '_';
            }
        }
        static void FuncionamentoDoJogo(int tentativas, int lenght, char[] letrasDaForca, char[] respostas)
        {
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Insira uma letra:");
                char forca = Convert.ToChar(Console.ReadLine());

                int encontrou = 0;

                for (int i = 0; i < lenght; i++)
                {
                    if (forca == letrasDaForca[i])
                    {
                        respostas[i] = forca;
                        encontrou = 1;
                    }
                }

                if (encontrou == 0)
                {
                    Console.WriteLine("Resposta Errada! Tente novamente");
                    tentativas = tentativas + 1;

                    switch (tentativas)
                    {
                        case 1:
                            Console.WriteLine("  _______     ");
                            Console.WriteLine(" |/      |    ");
                            Console.WriteLine(" |            ");
                            Console.WriteLine(" |            ");
                            Console.WriteLine(" |            ");
                            Console.WriteLine(" |            ");
                            Console.WriteLine("_|___         ");
                            break;
                        case 2:
                            Console.WriteLine("  _______     ");
                            Console.WriteLine(" |/      |    ");
                            Console.WriteLine(" |      (_)   ");
                            Console.WriteLine(" |            ");
                            Console.WriteLine(" |            ");
                            Console.WriteLine(" |            ");
                            Console.WriteLine("_|___         ");
                            break;
                        case 3:
                            Console.WriteLine("  _______     ");
                            Console.WriteLine(" |/      |    ");
                            Console.WriteLine(" |      (_)   ");
                            Console.WriteLine(" |       |    ");
                            Console.WriteLine(" |       |    ");
                            Console.WriteLine(" |            ");
                            Console.WriteLine("_|___         ");
                            break;
                        case 4:
                            Console.WriteLine("  _______     ");
                            Console.WriteLine(" |/      |    ");
                            Console.WriteLine(" |      (_)   ");
                            Console.WriteLine(" |      /|\\  ");
                            Console.WriteLine(" |       |    ");
                            Console.WriteLine(" |            ");
                            Console.WriteLine("_|___         ");
                            break;
                        case 5:
                            Console.WriteLine("  _______     ");
                            Console.WriteLine(" |/      |    ");
                            Console.WriteLine(" |      (_)   ");
                            Console.WriteLine(" |      /|\\  ");
                            Console.WriteLine(" |       |    ");
                            Console.WriteLine(" |      / \\  ");
                            Console.WriteLine("_|___         ");
                            break;
                    }
                }

                for (int i = 0; i < lenght; i++)
                {
                    Console.Write(respostas[i] + " ");
                }

                if (new string(letrasDaForca) == new string(respostas))
                {
                    Console.WriteLine("Parabéns! Você acertou a palavra!");
                    break;
                }
            } while (tentativas < 5);

            if (tentativas == 5)
            {
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você perdeu o jogo :(");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }
        }


        public int Length { get; }
        static void Main(string[] args)
        {
            string[] palavras = { "ABACATE", "ABACAXI", "ACEROLA", "AÇAÍ", "ARAÇA", "ABACATE", "BACABA", "BACURI", "BANANA", "CAJÁ", "CAJÚ", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MAÇÃ", "MANGABA", "MANGA", "MARACUJÁ", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };
            Random r = new Random();
            int posicao = r.Next(palavras.Length);
            string _palavras = palavras[posicao];
            char[] letrasDaForca = _palavras.ToCharArray();
            int lenght = _palavras.Length;
            int tentativas = 0;
            char[] respostas = new char[_palavras.Length];
            ArrumarPalavras(_palavras, respostas);
            FuncionamentoDoJogo(tentativas, lenght, letrasDaForca, respostas);
        }
    }
}
