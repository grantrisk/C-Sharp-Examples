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

            Console.WriteLine("UK cities: " + cities["UK"]);
            Console.WriteLine("US cities: " + cities["USA"]);

            cities["UK"] = "London, Birmingham";

            Console.WriteLine("Modified UK cities: " + cities["UK"]);

        }
    }
}