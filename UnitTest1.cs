using Loja;

namespace Testes;

public class UnitTest1
{
    private readonly F_TelaLogin _fLogin = new F_TelaLogin();
    
    [Fact]
    public void TeteHash()
    {
        string senha = "123";
        string senhaHash = senha.Hash();

        Assert.Equal(true, Hasher.Verify(senha, senhaHash));
    }

    [Fact]
    public void TesteLogin() 
    {
       var resultado =  _fLogin.Login("vitor123","123");

        Assert.Equal(true ,resultado);
    }
}

