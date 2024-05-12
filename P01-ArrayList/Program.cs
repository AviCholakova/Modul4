namespace P01_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> list1 = new ArrayList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            //foreach (int element in list1)
            //{
            //    Console.WriteLine(element);
            //}
            Console.WriteLine("------------------------");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }
        }
    }
}