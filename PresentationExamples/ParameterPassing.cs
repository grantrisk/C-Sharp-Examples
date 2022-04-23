 namespace MyNamespace
 {
    class ParameterPassing {

    
        public static void staticPassing()
        {
            int arg;

            // Pasing by value.
            arg = 4;
            squareVal(arg);
            Console.WriteLine(arg);
            // Output: 4

            // Passing by reference.
            // The value of arg in staticPassing is changed.
            arg = 4;
            squareRef(ref arg);
            Console.WriteLine(arg);
            // Output: 16
        }

        static void squareVal(int valParameter){
            valParameter *= valParameter;
        }

        // Passing by reference
        static void squareRef(ref int refParameter){
            refParameter *= refParameter;
        }
}
 }
