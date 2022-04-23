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

			Console.WriteLine("Food in the LinkedList:");

			foreach (string str in my_list)
			{
				Console.WriteLine(str);
			}

			Console.WriteLine("Removing my_list.First");

			my_list.Remove(my_list.First);


			Console.WriteLine("Checking if Carrots are in the LinkedList");
			if (my_list.Contains("Carrots") == true)
			{
				Console.WriteLine("Removing Carrots...!!");
				my_list.Remove("Carrots");
			}
			else
			{
				Console.WriteLine("Carrots Not found");
			}

			Console.WriteLine("Removing with RemoveFirst");

			my_list.RemoveFirst();
			
			Console.WriteLine("Removing with RemoveLast");

			my_list.RemoveLast();


			Console.WriteLine("What's left in the LinkedList: ");

			foreach (string str in my_list)
			{
				Console.WriteLine(str);
			
		    }
        }
    }
}