using System;

namespace TesteOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //comentarios1
            /*comentario 2
            comentario 3
            comentario n*/

            Atribuicao();
            Aritmetico();
            AritmeticoAtrReduzida();
            Incrementais();
            Relacionais();
            Logicos();
            Ternarios();

            Console.ReadLine();
        }
        public static void Atribuicao()
        {
            String strImpressao = "Hello World";
            Console.WriteLine("Operador de Atribuicao: " + strImpressao);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");
        }


        public static void Aritmetico()
        {
            int adicao = 5 + 4;
            int subtracao = 9 - 2;
            int multiplicacao = 6 * 3;
            int divisao = 6 / 2;
            int modulo = 9 % 2;

            Console.WriteLine("Operador Artimético: ");
            Console.WriteLine("Adição: " + adicao);
            Console.WriteLine("Subtração: " + subtracao);
            Console.WriteLine("Multiplicacao: " + multiplicacao);
            Console.WriteLine("Divisão: " + divisao);
            Console.WriteLine("Modulo: " + modulo);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");


        }

        public static void AritmeticoAtrReduzida()
        {
            int Maisigual = 5;
            Maisigual += 4;

            int MenosIgual = 9;
            MenosIgual -= 2;

            int multiplicacaoigual = 6;
            multiplicacaoigual *= 3;

            int divisaoigual = 6;
            divisaoigual /= 2;

            int moduloigual = 9;
            moduloigual %= 2;

            Console.WriteLine(" Operador Aritméticos de atribuição reduzida: ");
            Console.WriteLine("+=: " + Maisigual);
            Console.WriteLine("-=: " + MenosIgual);
            Console.WriteLine("*=: " + multiplicacaoigual);
            Console.WriteLine("/=: " + divisaoigual);
            Console.WriteLine("%=: " + moduloigual);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");
        }

        public static void Incrementais()
        {
            int incremental = 10;
            incremental++;

            int decremental = 20;
            decremental--;


            Console.WriteLine("Operador Incremental ++");
            Console.WriteLine("++: " + incremental);
            Console.WriteLine("--: " + decremental);


            incremental = 10;
            ++incremental;

            decremental = 20;
            --decremental;


            Console.WriteLine("++ Operador Incremental");
            Console.WriteLine("++: " + incremental);
            Console.WriteLine("--: " + decremental);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");

        }

        public static void Relacionais()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Operadores relacionais");
            Console.WriteLine(" ");

            bool igualA = a == b;
            Console.WriteLine("== :" + igualA);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");


            bool diferenteA = a != b;
            Console.WriteLine("!= :" + diferenteA);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");

            bool maiorQue = a > b;
            Console.WriteLine("> :" + maiorQue);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");


            bool menorQue = a < b;
            Console.WriteLine("< :" + menorQue);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");

            bool maiorIgualA = a >= b;
            Console.WriteLine(">= :" + maiorIgualA);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");

            bool menorIgualA = a <= b;
            Console.WriteLine("<= :" + menorIgualA);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");

        }


        public static void Logicos()
        {
            int a = 10;
            int b = 20;
            int c = 30;
            int d = 40;
            Console.WriteLine("Operadores Lógicos");
            Console.WriteLine("");

            bool and = (a < b) && (c < d);
            Console.WriteLine("&& :" + and);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");


            bool or = (a < b) || (c < d);
            Console.WriteLine("|| :" + or);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");

            bool not = !(a == b);
            Console.WriteLine("! :" + not);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");

        }

        public static void Ternarios()
        {
            int a = 10;
            int b = 20;
            string resultadoTernario = a < b ? "Menor!" : "Maior";
            Console.WriteLine("Operador Ternário: " + resultadoTernario);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");
        }

    }
}
