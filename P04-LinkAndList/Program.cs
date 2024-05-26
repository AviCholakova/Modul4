namespace P04_LinkAndList
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomArrayList list = new CustomArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            //Console.WriteLine("Въведи търсено число: ");
            //string num = Console.ReadLine();
            //if (list.Contains(num))
            //{
            //    Console.WriteLine($"{num} се среща в списъка.");
            //}
            //else { Console.WriteLine($"{num} не се среща в списъка."); }
            //list.Clear();
            //Console.WriteLine(list.IndexOf(14));
            //list.Insert(0, 23);
            //list.Remove(0);
            foreach (var item in list) 
            {
                Console.WriteLine(item);
            }
           
        }
    }
}