public class Program
{
    public class MyClass
    {
        public bool IsOnGraph(int a, int b, int x, int y)
        {
            if (a * x * b == y) return true;
            else return false;
        }
    }

    private static void Main(string[] args)
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Введите x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Введите y: ");
        int y = int.Parse(Console.ReadLine());

        MyClass myClass = new MyClass();

        Console.WriteLine(myClass.IsOnGraph(a, b, x, y));
    }
}