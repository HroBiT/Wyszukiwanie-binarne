namespace test
{
    internal class Program
    {
        static public int Sort(int[] vector, int search)
        {
            int left = 0;
            int right = vector.Length - 1;

            while (left <= right)
            {
                int currentPosition = left + (right - left) / 2;

                if (vector[currentPosition] == search)
                {
                    return currentPosition;
                }

                if (vector[currentPosition] < search)
                {
                    left = currentPosition + 1;
                }

                if (vector[currentPosition] > search)
                {
                    right = currentPosition - 1;
                }
            }

            return -1;
        }


        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("wpisz liczbe");
            int wyszukiwanie = Convert.ToInt32(Console.ReadLine());
            

            int v = Sort(ints, wyszukiwanie);
            Console.WriteLine("index liczby"); 
            Console.WriteLine(v);

            Console.WriteLine(v+1);

        }
    }
}