//dotnet add package Microsoft.Data.Sqlite

using System;
using System.Collections.Generic; 
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

public class Program
{
    static async Task Main(string[] args)
    {
        var escolha = await CreateDbAsync();
        if (escolha == true)
        {
            await MenuAsync();
        }
    }

    static async Task MenuAsync()
    {
        Console.Clear();
        while (true)
        {
            Console.Write("1-Add\n2-Remove\n3-List\n4-Sair\n\nEscolha: ");
            string chose = Console.ReadLine();

            switch (chose)
            {
                case "1":
                    Console.Clear();
                    Console.Write("Digite o nome Que deseja cadastrar: ");
                    string name = Console.ReadLine();

                    Console.Clear();

                    string chose2 = "0";

                    while (chose2 != "1" && chose2 != "2")
                    {
                        Console.WriteLine($"Realmente deseja cadastrar o usuario {name}? 1-Sim 2-Nao:");
                        chose2 = Console.ReadLine();
                        Console.Clear();
                    }

                    if (chose2 == "1")
                    {
                        await AddPeopleAsync(name);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                    }


                    break;
                case "2":
                    Console.Clear();

                    Console.Write("Digite o Id ou K para cancelar: ");
                    var input = Console.ReadLine();

                    if (int.TryParse(input, out int id))
                    {
                        await DelPeopleAsync(id);
                    }
                    else if (input.ToLower() == "k")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("ID invalido!\n");
                    }

                    break;
                case "3":
                    Console.Clear();
                    await ListPeoplesAsync();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Encerrado.");
                    return;
                    break;
                default:
                    Console.Clear();
                    break;
            }

        }
    }

    static async Task<bool> CreateDbAsync()
    {
        try
        {
            using var conexao = new SqliteConnection("Data Source=peoples.db");
            await conexao.OpenAsync();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"
            CREATE TABLE IF NOT EXISTS peoples(
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            name varchar(60) not null
            );
            ";

            await comando.ExecuteNonQueryAsync();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Banco de dados nao conectado!");
            return false;
        }
        
    }

    static async Task AddPeopleAsync(string name)
    {
        Console.Clear();
        try
        {
            using var conexao = new SqliteConnection("Data Source=peoples.db");
            await conexao.OpenAsync();
            var comando = conexao.CreateCommand();
            
            comando.CommandText = @"
            INSERT INTO peoples (name) VALUES ($name);
             ";

            comando.Parameters.AddWithValue("$name", name);

            await comando.ExecuteNonQueryAsync();

            Console.WriteLine($"Usuario {name} cadastrado com sucesso!\n");

        }
        catch (Exception ex)
        {
            Console.Clear();
            Console.WriteLine("Algo deu errado, tente novamente!\n");
        }

    }

    static async Task DelPeopleAsync(int id)
    {
        Console.Clear();
        try
        {

            using var conexao = new SqliteConnection("Data Source=peoples.db");
            await conexao.OpenAsync();

            var comandoSelect = conexao.CreateCommand();

            comandoSelect.CommandText = @"
            SELECT * from peoples WHERE id = $id;
            ";

            comandoSelect.Parameters.AddWithValue("$id", id);

            var leitor = await comandoSelect.ExecuteReaderAsync();

            if (await leitor.ReadAsync())
            {
                string name = leitor.GetString(1);
                leitor.Close();

                var comando = conexao.CreateCommand();

                comando.CommandText = @"
                DELETE FROM peoples WHERE id = $id;
                ";

                comando.Parameters.AddWithValue("$id", id);

                await comando.ExecuteNonQueryAsync();

                Console.WriteLine($"Usuario {name} deletado com sucesso!\n");
            }
            else
            {
                Console.WriteLine($"Nenhum Usuario encontrado com o ID: {id}\n");
            }
            

        }
        catch (Exception ex)
        {
            Console.WriteLine("Algo deu errado, tente novamente!\n");
        }
    }

    static async Task ListPeoplesAsync()
    {
        try
        {
            using var conexao = new SqliteConnection("Data Source=peoples.db");
            await conexao.OpenAsync();

            var comandoSelect = conexao.CreateCommand();

            comandoSelect.CommandText = @"
                SELECT * FROM peoples;
            ";

            var leitor = await comandoSelect.ExecuteReaderAsync();
            int number = 0;

            while (await leitor.ReadAsync())
            {
                int id = leitor.GetInt32(0);
                string name = leitor.GetString(1);

                Console.WriteLine($"ID: {id}, Nome: {name}\n");
                number++;
            }
            
            if (number < 1)
            {
                Console.WriteLine("Nenhum usuario encontrado!\n");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Algo deu errado, tente novamente!\n");
        }
    }

}