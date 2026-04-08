using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeListObjectsForms
{
    public class Usuario
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }
        public string Login { get; private set; }

        public string Numero { get; private set; }

        public string Senha { get; private set; }
        public readonly bool IsAdmin;

        public Usuario(Guid id,string nome, string login, string senha, string numero, bool isAdmin)
        {
            Id = id;
            Login = login;
            Name = nome;
            Senha = senha;
            IsAdmin = isAdmin;
            Numero = numero;
        }
    }
}
