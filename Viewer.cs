using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Viewer
    {
         private const char Separator ='';

        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO DE VISUALIZAÇÃO");
            Replace(text);
            Console.WriteLine("--------------------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            // função que substitui alguns caracteres especiais
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(Separator);

            for (var i = 0; i <= words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    // Console.Write();
                }
            }
        }

        internal static void Show(Func<string> toString)
        {
            throw new NotImplementedException();
        }
    }
}