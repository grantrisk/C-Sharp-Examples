namespace MyNamespace
{
	class LinkedListExample
	{
		public static void LinkedListMethodExample() {

			LinkedList<String> my_list = new LinkedList<String>();
			my_list.AddLast("Pizza");
			my_list.AddLast("Burger");
			my_list.AddLast("Salad");
			my_list.AddLast("Grilled Chicken");
			my_list.AddLast("Carrots");
			my_list.AddLast("Potatoes");

			Console.WriteLine("\nFood in the LinkedList:");

			foreach (string str in my_list)
			{
				Console.WriteLine(str);
			}

			Console.WriteLine("\nRemoving with Remove function = " + my_list.First());
			my_list.Remove(my_list.First());

			Console.WriteLine("Removing with RemoveFirst function = " + my_list.First());
			my_list.RemoveFirst();
			
			Console.WriteLine("Removing with RemoveLast function = " + my_list.Last());
			my_list.RemoveLast();

			Console.WriteLine("\nFood in the LinkedList after changes:");

			foreach (string str in my_list)
			{
				Console.WriteLine(str);
			
		    }
        }
    }
}