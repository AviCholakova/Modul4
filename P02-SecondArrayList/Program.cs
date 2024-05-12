namespace P02_SecondArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> list1 = new ArrayList<int>();
            ArrayList<string> list2 = new ArrayList<string>();
            list2.Add("Ani");
            list2.Add("Bobi");
            list2.Add("Gosho");
            list2.Add("Pesho");
            list2.RemoveAt(3);
            foreach (string name in list2)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            foreach (int num in list1)
            {
                Console.Write(num + " ");
            }
        }
    }
}