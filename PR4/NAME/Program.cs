namespace PR4
{
    class Person
    {
        public string name = "Саня";
        public int age = 17;

        public void GetInfo()
        {
            System.Console.WriteLine($"name: {name} age: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            Person Alex = new Person();
            Alex.GetInfo();
            System.Console.ReadKey();

            Alex.name = "Александр";
            Alex.age = 17;
            Alex.GetInfo();
            System.Console.ReadKey();
        }
    }
}