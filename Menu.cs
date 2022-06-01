using System;
namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;  //muda cor de fundo do terminal
            Console.ForegroundColor = ConsoleColor.Black;//define cor da fonte das letras no terminal
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
        }

        //Desenha tela para melor experiencia do usuário
        public static void DrawScreen()
        {
            // Início desenho da tela
            Console.Write("+");
            for (int i = 0; i <= 50; i++) //For com uma linha só ñ precisa {}
                Console.Write("-");
            Console.Write("+"); //Caracter final
            Console.Write("\n");

            // for para demarcação das linhas
            for (int firstline = 0; firstline <= 10; firstline++)
            {
                Console.Write("|");
                for (int i = 0; i <= 50; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }

            //Fechamento tela
            Console.Write("+");
            for (int i = 0; i <= 50; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");

        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1- Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2- Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0- Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Sua opção: ");

        }
    }


}