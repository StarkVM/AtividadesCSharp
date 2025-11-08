//dotnet add package Microsoft.EntityFrameworkCore.Sqlite

//dotnet add package Microsoft.EntityFrameworkCore.Tools

//dotnet add package Microsoft.Data.Sqlite

using System;
using System.Linq; //Permite usar o link
using System.Globalization; //para remover os acentos
using System.Threading.Tasks; //para usar async e await
using Microsoft.EntityFrameworkCore; // para trabalhar com o entity fraework
using System.Text; //para a funcao de remover acentos
public class Program
{
    static async Task Main(string[] args)
    {
        using var db = new MyDbContext();
        await db.Database.EnsureCreatedAsync();
        await MenuAsync();
    }

    static async Task MenuAsync()
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("1 - Inserir");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Deletar");
            Console.WriteLine("5 - Buscar por nome");
            Console.WriteLine("6 - Buscar por Id");
            Console.WriteLine("0 - Sair\n");
            Console.Write("Escolha: ");

            string opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1": InsertAsync(); break;
                case "2": ReadAsync(); break;
                case "3": UpdateAsync(); break;
                case "4": DeleteAsync(); break;
                case "5": ReadByNameAsync(); break;
                case "6": ReadByIdAsync(); break;
                case "0": Console.WriteLine("Encerrado."); return; break;
                default: Console.Clear(); break;
            }
        }
    }

    static async Task InsertAsync()
    {
        Console.Write("Nome: ");
        string name = Console.ReadLine();

        Console.Write("\n\nIdade: ");
        var idade = Console.ReadLine();

        Console.Clear();

        if (name.Length < 60 && int.TryParse(idade, out int year))
        {
            string escolha = "0";
            while (escolha != "1" && escolha != "2")
            {
                Console.WriteLine($"Realmente deseja cadatrar o Usuario {name} com a idade {year}?");
                Console.WriteLine("1- Sim 2- Nao : ");
                escolha = Console.ReadLine();
                Console.Clear();
            }
            if (escolha == "1")
            {
                try
                {
                    using var db = new MyDbContext();
                    await db.Peoples.AddAsync(new People(name, year));
                    await db.SaveChangesAsync();
                    Console.WriteLine("Pessoa inserida com sucesso!\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Desculpe, algo deu errado.\n");
                }

            }

        }
        else
        {
            Console.WriteLine("Nome e/ou Idade invalidos.\n");
        }

    }

    static async Task ReadAsync()
    {
        try
        {
            using var db = new MyDbContext();
            var peoples = await db.Peoples.ToListAsync();

            if (!peoples.Any())
            {
                Console.WriteLine("Nenhuma Pessoa cadastrada!");
                return;
            }

            foreach (var item in peoples)
            {
                Console.WriteLine($"ID: {item.Id}, Nome: {item.Name}, Idade: {item.Idade}");
            }

            Console.Write("\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Desculpe, algo deu errado!\n");
        }

    }

    static async Task UpdateAsync()
    {
        try
        {
            Console.Write("Digite o id da pessoa que deseja editar ou k para candelar\n: ");
            var input = Console.ReadLine();

            Console.Clear();

            if (int.TryParse(input, out int id))
            {
                using var db = new MyDbContext();
                var people = await db.Peoples.FindAsync(id);

                if (people == null)
                {
                    Console.WriteLine("Pessoa nao encontrada!\n");
                    return;
                }
                var people2 = new People(people.Name, people.Idade);

                Console.Write($"Novo nome do {people.Name}: ");
                people.Name = Console.ReadLine();

                Console.Clear();

                Console.Write($"Nova idade (Atual: {people.Idade}): ");
                var idade = Console.ReadLine();

                Console.Clear();
                int.TryParse(idade, out int i);

                if (int.TryParse(idade, out int year) == false || people.Name.Length > 60 || i < 0)
                {
                    Console.WriteLine("Nome e/ou idade invalidos!\n");
                    return;
                }

                string escolha = "0";
                while (escolha != "1" && escolha != "2")
                {
                    int.TryParse(idade, out int year2);

                    people.Idade = year2;

                    Console.WriteLine("Deseja Realmente fazer essas Alteracoes?");
                    Console.WriteLine($"{people2.Name} para {people.Name}");
                    Console.WriteLine($"{people2.Idade} para {people.Idade}");
                    Console.WriteLine("1- Sim 2- Nao: ");
                    escolha = Console.ReadLine();
                    Console.Clear();
                }

                if (escolha == "1")
                {
                    await db.SaveChangesAsync();

                }
                else
                {
                    return;
                }
            }
            else if (input.ToLower() == "K")
            {
                return;
            }
            else
            {
                Console.WriteLine("Id invalido!\n");
                return;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Desculpe, algo deu errado!\n");
        }
    }

    static async Task DeleteAsync()
    {
        Console.Write("Digite po Id da pessoa que deseja deletar ou k para cancelar\n: ");
        var input = Console.ReadLine();

        Console.Clear();

        if (int.TryParse(input, out int id))
        {
            try
            {
                using var db = new MyDbContext();
                var people = await db.Peoples.FindAsync(id);

                if (people == null)
                {
                    Console.WriteLine("Nenhum usuario encontrado com esse ID!\n");
                    return;
                }
                else
                {
                    string escolha = "0";
                    while (escolha != "1" && escolha != "2")
                    {
                        Console.WriteLine($"Realmente deseja excluir o usuario {people.Name} com o ID {people.Id}?");
                        Console.Write("1- Sim 2- Nao: ");
                        escolha = Console.ReadLine();
                        Console.Clear();
                    }

                    if (escolha == "1")
                    {
                        try
                        {
                            Console.WriteLine($"Usiario {people.Name} excluido com sucesso!\n");

                            db.Peoples.Remove(people);
                            await db.SaveChangesAsync();
                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        return;
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Desculpe, algo deu errado!\n");
                return;
            }
        }
        else if (input.ToLower() == "K")
        {
            return;
        }
        else
        {
            Console.WriteLine("Id invalido!\n");
        }


    }

    static string RemoveAcentos(string texto)
    {
        return string.Concat(
           texto.Normalize(NormalizationForm.FormD)
           .Where(x => CharUnicodeInfo.GetUnicodeCategory(x) != UnicodeCategory.NonSpacingMark)
        ).Normalize(NormalizationForm.FormC);
    }

    static async Task ReadByNameAsync()
    {
        Console.Write("DIgite o nick do usuario: ");
        string name = Console.ReadLine();

        Console.Clear();

        name = RemoveAcentos(name.ToLower());

        try
        {
            using var db = new MyDbContext();
            var peoples = await db.Peoples.ToListAsync();

            var result = peoples
            .Where(x => RemoveAcentos(x.Name.ToLower()).Contains(name))
            .ToList();

            if (!result.Any())
            {
                Console.WriteLine("Nenhum usuario encontrado.\n");
                return;
            }

            Console.WriteLine("Resultados: \n");

            foreach (var item in result)
            {
                Console.WriteLine($"Id: {item.Id}, Nome: {item.Name}, Idade: {item.Idade}\n");
            }

        }

        catch (Exception ex)
        {
            Console.WriteLine("Desculpe, algo deu errado.\n");
            return;
        }


    }

    static async Task ReadByIdAsync()
    {
        Console.WriteLine("Digite o Id que deseja buscar ou k para cancelar: ");
        var input = Console.ReadLine();

        Console.Clear();

        if (int.TryParse(input, out int id))
        {
            try
            {
                using var db = new MyDbContext();
                var people = await db.Peoples.FindAsync(id);

                if (people == null)
                {
                    Console.WriteLine($"Nenhum usuario encontrado com o Id: {id}.\n");
                    return;
                }

                Console.WriteLine("Resultado:");
                Console.WriteLine($"Id: {people.Id}, Nome: {people.Name}, Idade: {people.Idade}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Desculpe, algo deu errado.\n");
                return;
            }

        }
        else if (input == "K")
        {
            return;
        }
    }
}

public class MyDbContext : DbContext
{
    public DbSet<People> Peoples { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite("Data Source=peoples.db");

}

public class People
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Idade { get; set; }

    public People(string name, int idade)
    {
        Name = name;
        Idade = idade;
    }
}