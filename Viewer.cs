using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO DE VISUALIZAÇÃO");
            Console.WriteLine("--------------------");
            Replace(text);
            Console.WriteLine("--------------------");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            Console.Write(text);
            // função que substitui alguns caracteres especiais
            var strong = "<strong>";//new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            //var words = text.Split(Separator);
            var words = text.Split(' ');

            

            for (var i = 0; i < words.Length; i++)
            {
                
                if (words[i] == strong)
                {


                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write( words[i+1]);
                    Console.Write(" ");
                    words[i] = words[i++];

                    if (words[i++] == @"</strong>")
                    {
                        Console.Write(" Passei aqui ");
                        words[i++] = words[i+2];
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(words[i+2]);
                        Console.Write(" ");

                    }
                } else { //Se não der match em nada
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(words[i]);
                    Console.Write(" ");

                }
            }
        }
    }
}
