using System;

namespace random_password
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            Console.Write("Введите длину пароля: ");
            length = Convert.ToInt32(Console.ReadLine());

            int kolvo_letter = 0;
            Console.Write("Введите кол-во маленьких букв: ");
            kolvo_letter = Convert.ToInt32(Console.ReadLine());

            int kolvo_big_letter = 0;
            Console.Write("Введите кол-во заглавных букв: ");
            kolvo_big_letter = Convert.ToInt32(Console.ReadLine());

            int kolvo_numeral = 0;
            Console.Write("Введите кол-во цифр: ");
            kolvo_numeral = Convert.ToInt32(Console.ReadLine());

            int kolvo_sym = length - kolvo_numeral - kolvo_letter - kolvo_big_letter;

            if (kolvo_sym >= 0)
            {
                Random random = new Random();
                string letter = "qwertyuiopasdfghjklzxcvbnm";
                string big_letter = "qwertyuiopasdfghjklzxcvbnm".ToUpper();
                string numeral = "1234567890";
                string symbol = "<>?/.,\\!@#$%^&*()_+\"№;:?*-=";


                string rand_let = "", rand_big_let = "", rand_num = "", rand_sym = "";

                Console.WriteLine("\nВаш пароль состоит из {0} символов, в который входят: ", length);

                string s1 = "", s2 = "", s3 = "", s4 = "";

                Console.Write("\nВаши цифры: ");
                for (int i = 0; i < kolvo_numeral; i++)
                {
                    rand_num = Convert.ToString(numeral[random.Next(numeral.Length - 1)]);
                    Console.Write(rand_num.ToString());
                    s1 += rand_num;
                }

                Console.Write("\nВаши большие буквы: ");
                for (int i = 0; i < kolvo_big_letter; i++)
                {
                    rand_big_let = Convert.ToString(big_letter[random.Next(big_letter.Length - 1)]);
                    Console.Write(rand_big_let.ToUpper());
                    s2 += rand_big_let;
                }

                Console.Write("\nВаши ваши маленькие буквы: ");
                for (int j = 0; j < kolvo_letter; j++)
                {
                    rand_let = Convert.ToString(letter[random.Next(letter.Length - 1)]);
                    Console.Write(rand_let.ToString());
                    s3 += rand_let;
                }

                Console.Write("\nВаши символы: ");
                for (int j = 0; j < kolvo_sym; j++)
                {
                    rand_sym = Convert.ToString(symbol[random.Next(symbol.Length - 1)]);
                    Console.Write(rand_sym.ToString());
                    s4 += rand_sym;
                }


                string rand = "";

                rand = s1 + s2 + s3 + s4;
                Console.Write("\n\nВаш пароль: ");


                char[] array = rand.ToCharArray();
                Random rng = new Random();
                int n = array.Length;
                while (n + 1 > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    var value = array[k];
                    array[k] = array[n];
                    array[n] = value;

                    Console.Write(array[n].ToString());
                }
            }
            else
                Console.WriteLine("Кол-во введенных символов не совпадают с итоговой длиной пароля");

            Console.ReadKey();
        }
    }
}
