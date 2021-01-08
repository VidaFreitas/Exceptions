using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            try
            {
                for (var index = 0; index < 10; index++)
                {
                    Console.WriteLine(arr[index]);
                }

                Cadastrar("");
            }

            catch (MinhaExeption ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o indice na lista!");
            }

            catch (Exception)
            {
                // Console.WriteLine(ex.InnerException);
                // Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
        }
        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
        }

        public class MinhaExeption : Exception
        {
            public DateTime QuandoAconteceu { get; set; }
        }


    }
}
