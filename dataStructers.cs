namespace HW_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfList =0;
            int sumOfDict = 0;

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);    
            list.Add(3);
            list.Add(4);
            list.Add(5);

            var dictionary = new Dictionary<string, int>();
            dictionary.Add("a", 1);
            dictionary.Add("b", 2);
            dictionary.Add("c", 3);
            dictionary.Add("d", 4);
            dictionary.Add("e", 5);

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach (var item in list) 
            {
                Console.Write(item + " ");
                sumOfList += item; 
            }
            Console.WriteLine("\nThe sum of the list is: " + sumOfList);

            foreach (var item in dictionary) 
            { 
                sumOfDict += item.Value; 
            }
            Console.WriteLine("The sum of the dictionary is: " + sumOfDict);

            queue.Dequeue();
            queue.Dequeue();

            foreach (var item in queue) 
            { 
                Console.Write(item + " "); 
            }

            Console.WriteLine();

            stack.Pop();
            stack.Pop();

            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
        }
    }
}
