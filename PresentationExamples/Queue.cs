using System.Collections;

namespace MyNamespace
{
	class QueueExample
	{
		public static void QueueMethodExample()
		{

			Queue my_queue = new Queue();

			my_queue.Enqueue("CSC 434");
			my_queue.Enqueue(0);
			my_queue.Enqueue(42);
			my_queue.Enqueue(3.14);
			my_queue.Enqueue("I made it into the C# Queue!");

			foreach (var element in my_queue)
			{
				Console.WriteLine(element);
			}
			Console.WriteLine("\n");

			// Count total elements
			Console.WriteLine("Total elements in my_queue: {0}", my_queue.Count);

			Console.WriteLine("Dequeue the topmost element of my_queue: {0}", my_queue.Dequeue());

			Console.WriteLine("Peek at the topmost element of my_queue: {0}", my_queue.Peek());

			Console.WriteLine("Total elements in my_queue after dequeue: {0}", my_queue.Count);

			// Check if 'CSC 434' is in the Queue
			if (my_queue.Contains("CSC 434") == true)
			{
				Console.WriteLine("CSC 434 available");
			}
			else
			{
				Console.WriteLine("CSC 434 not available");
			}
		}

	}
}