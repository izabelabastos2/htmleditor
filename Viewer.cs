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
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            //var words = text.Split(Separator);
            var words = text.Split(' ');


            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        //escrever o texto na cor azul, porém sem o strong ou /strong
                        words[i].Substring(// pede primeiro e último caracter
                            words[i].IndexOf('>') + 1 , //por se tratar de lista, adiciona-se mais um caracter
                            ( ( words[i].LastIndexOf('<') - 1 ) - words[i].IndexOf('>') )
                        ) 
                    );
                    Console.Write(" ");
                } else { //Se não der match em nada
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(words[i]);
                    Console.Write(" ");

                }
            }
        }
    }
}
