using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Loja
{
    public static class Hasher
    {
        public static string Hash(this string senha) 
        {
            return BCrypt.Net.BCrypt.HashPassword(senha, workFactor: 12);
        }

        public static bool Verify(string password, string passwordHash) 
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
    }
}
