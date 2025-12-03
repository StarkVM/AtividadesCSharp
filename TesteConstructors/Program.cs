public class Program
{
    static void Main(string[] args)
    {
        var teste1 = new Teste("Viktor");

        var teste2 = new Teste("Viktor",17);

        Console.WriteLine(teste1.Id);
        Console.WriteLine(teste2.Id);
        Console.ReadLine();

   }

    public class Teste
    {
        public string Name { get; private set; } = string.Empty;

        public int Age { get; private set; }

        public int Id { get; private set; }

        public Teste(string name, int age)
        {
            Id = 1;
        }

        public Teste(string name)
        {
            Id = 2;
        }
    }
}
