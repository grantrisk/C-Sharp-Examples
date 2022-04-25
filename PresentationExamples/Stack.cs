namespace MyNamespace
{
    class StackExample
    {
        public static void StackMethodExample(){
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.WriteLine("\nCreated stack:");
            foreach (var item in myStack){
                Console.Write(item + " "); 
            }

            myStack.Pop();
            Console.WriteLine("\nStack after popping element off stack:");
            foreach (var item in myStack){
                Console.Write(item + " "); 
            }
        }
    }
}