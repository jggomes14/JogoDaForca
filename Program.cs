using System;


namespace JogoDaForca
{
    internal class Program
    {
        public int Length { get; }
        static void Main(string[] args)
        {
            string[] palavras = { "ABACATE", "ABACAXI", "ACEROLA", "AÇAÍ", "ARAÇA", "ABACATE", "BACABA", "BACURI", "BANANA", "CAJÁ", "CAJÚ", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MAÇÃ", "MANGABA", "MANGA", "MARACUJÁ", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };
            Random r = new Random();
            int posicao = r.Next(palavras.Length);
            string _palavras = palavras[posicao];

            char [] letrasDaForca = _palavras.ToCharArray();
            
            Console.WriteLine(_palavras);
            int lenght = _palavras.Length;
            Console.WriteLine(lenght);
            int tentativas = 0;
            
            

            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Insira uma letra:");
                char forca = Convert.ToChar(Console.ReadLine());
                
                for (int i = 0; i < lenght; i++)
                {
                   if (forca == letrasDaForca[i])
                    {
                        Console.Write(letrasDaForca[i] = forca);
                        
                        
                  
                        
                    }
                   else if (forca != letrasDaForca[i])
                    {
                        Console.Write("_");
                        
                    }
                  


                }
            } while (tentativas < 5) ;
        }
    }
}
