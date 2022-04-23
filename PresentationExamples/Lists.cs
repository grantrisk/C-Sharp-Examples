namespace MyNamespace
{
    class Lists
    {
        public static void initialize(){
            
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            Console.WriteLine("Accessing index 0: " + primeNumbers[0]);

        }
    }
}