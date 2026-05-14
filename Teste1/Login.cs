using System;
using System.Collections.Generic;
using System.Text;

namespace Teste1;

public class Login
{
	public List<(string username, string password)> ListaUsuarios;

	public Login()
	{
		ListaUsuarios = new List<(string username, string password)>{
		("adm","adm"),
		("123","123"),
		("222","222")
		};
	}
	public bool Logar(string username, string password, bool capcha)
	{
		if (!capcha || username is null || password is null) 
		{
			return false;
		}

		foreach (var u in ListaUsuarios) 
		{
			if (u.username == username && u.password == password) 
			{
				return true;
			}
		}

		return false;
	}
}

