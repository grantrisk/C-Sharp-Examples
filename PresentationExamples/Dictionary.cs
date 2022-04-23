namespace MyNamespace
{
    class Dictionary
    {
        public static void initialize(){
            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            Console.WriteLine(cities["UK"]);
            Console.WriteLine(cities["USA"]);
        }
    }
}