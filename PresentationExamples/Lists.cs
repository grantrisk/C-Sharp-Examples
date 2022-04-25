namespace MyNamespace
{
    class Lists
    {
        public static void initialize(){
            
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(4);

            printArray(primeNumbers);
            Console.WriteLine("Accessing index 0: " + primeNumbers[0]);

            primeNumbers.Insert(1, 66);
            printArray(primeNumbers);

        }

        static void printArray(List<int> arr)
        {
            int n = arr.Count();
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}