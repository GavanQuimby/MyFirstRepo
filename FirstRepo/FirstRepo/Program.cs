using System;


namespace FirstRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int i, j;
            Console.WriteLine("First 1000 Prime Nums:");
            for(i=2; i<=7925;i++){
                for (j = 2; j <=7925; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write("\t"+i);
                }

                isPrime = true;
            }

            
        }
    }
}