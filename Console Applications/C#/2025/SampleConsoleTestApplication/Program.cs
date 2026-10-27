class Parent
{
    public  void PrintMethod()
    {
        Console.WriteLine("Parent.");
    }
}
class Child : Parent
{
    public void PrintMethod()
    {
        Console.WriteLine("Child.");
    }
}

class Program
{
    public static void Main()
    {

        int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine(num[2]);
  //      Child c = new Child();
//        ((Parent)c).PrintMethod();
    }
}