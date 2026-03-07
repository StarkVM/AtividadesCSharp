//dotnet add package Microsoft.Data.Sqlite pacote para trabalhar com o SQlite

using System;
using Microsoft.Data.Sqlite;

public class Program
{
    static void Main(string[] args)
    {
        CreateDB();
        Menu();
    }

    static void Menu()
    {
        while (true)
        {
            Console.WriteLine("1-Adicionar\n2-Listar\n3-Sair: ");
            string chose = Console.ReadLine();

            if (chose == "1")
            {
                Console.Clear();
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                AddPeople(name);
                Console.Clear();
            }
            else if (chose == "2")
            {
                Console.Clear();
                ListPeoples();
            }
            else if (chose == "3")
            {
                return;
            }
            else
            {
                Console.Clear();
            }

        }
    }

    static void CreateDB()
    {
        using var conexao = new SqliteConnection("Data Source=peoples.db");
        conexao.Open();

        var comando = conexao.CreateCommand();

        comando.CommandText = @"
        CREATE TABLE IF NOT EXISTS peoples(
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        name varchar(60) NOT NULL
        );
        ";

        comando.ExecuteNonQuery();
    }

    static void AddPeople(string name)
    {
        using var conexao = new SqliteConnection("Data Source=peoples.db");
        conexao.Open();

        var comando = conexao.CreateCommand();

        comando.CommandText = @"
            INSERT INTO peoples (name) VALUES ($name);
        ";

        comando.Parameters.AddWithValue("$name", name);

        comando.ExecuteNonQuery();

        Console.Clear();

        Console.WriteLine("Sucesso");


    }

    static void ListPeoples()
    {
        using var conexao = new SqliteConnection("Data Source=peoples.db");
        conexao.Open();

        var comando = conexao.CreateCommand();

        comando.CommandText = @"SELECT * FROM peoples;";

        using var leitor = comando.ExecuteReader();

        int number = 0;
        Console.Clear();

        while (leitor.Read())
        {
            int id = leitor.GetInt32(0);
            string name = leitor.GetString(1);

            Console.WriteLine($"Nome: {name}\nId: {id}\n");
            number++;
        }

        if (number < 1)
        {
            Console.WriteLine("No Find!");
        }
    }

}


/*public class Pessoa{

    [PrimaryKey,AutoIncrement]
    public int Id {get;}
    public string Nome {get; private set;}

    public Pessoa(string nome){
        Nome = nome;
    }
}

public class Vnome{
    public bool NomeValido {get; private set;} = false;
    public string Nome {get; private set;} = "Invalido";

    public Vnome(string nome){
        int val = nome.Length;
        if(val < 15 && val > 0)
        {
            Nome = nome;
            NomeValido = true;
        }
    }
}*/
