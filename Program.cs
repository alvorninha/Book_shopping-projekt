using System;

namespace BookShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string exit;
            string user_input;
            while (true)
            {
                user_input = Console.ReadLine();
                showspecific(user_input);

                exit = System.Console.ReadLine();


                if (exit == "EXIT")
                {
                    break;
                }
            }
        }


        static void showspecific(string search)
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file =
            new System.IO.StreamReader(@"I:\spiegel-bestseller.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(search))
                {
                    System.Console.WriteLine(line);
                }
                counter++;
            }

            file.Close();


        }



    }
}
