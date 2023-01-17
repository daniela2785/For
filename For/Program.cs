using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // for nada mais é do que uma forma reduzida do WHILE, EXEMPLO:
            *WHILE*
            
            int contador = 0;
            while (contador < 20)
            {
                Console.WriteLine("Rodando o while!");
                contador++;
            }
            Console.WriteLine("FIM DA LINHA");
            */

            //FOR 
            /*for(int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine(contador);
                Console.WriteLine("FOR RODANDO");
            }
            Console.WriteLine("FIM DA LINHA");
            Console.ReadLine();
           

             for(int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine(contador);
                Console.WriteLine("FOR RODANDO");
            }
            Console.WriteLine("FIM DA LINHA");
            Console.ReadLine();
            */

            //FOR E ARRAY - CRESCENTE
            string[] palavras = { "Daniela", "Marques", "Guia do programador", "Formação", "Node", "Curso de C#", "Udemy" };
            for (int contador = 0; contador < palavras.Length; contador++) //length = comprimento // basicamente o que ela diz é o tamanho do array
            {
                Console.WriteLine(contador);
                Console.WriteLine(palavras[contador]);
            }
           
            Console.WriteLine("======================");

            //FOR E ARRAY - DECRESCENTE

            for (int contador2 = palavras.Length-1; contador2 >= 0; contador2--) 
            {
                Console.WriteLine(contador2);
                Console.WriteLine(palavras[contador2]);
            }
            Console.WriteLine("FIM DE LINHA");
            Console.ReadLine();


        }
    }
}