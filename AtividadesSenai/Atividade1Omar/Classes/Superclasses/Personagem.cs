namespace Atividade1Omar.Classes.Superclasses;

public abstract class Personagem
{
    public string Name { get; protected set; }
    public string Classe {get; protected set;}
    
    public int Forca {get; protected set;}
    
    public int Mana {get; protected set;}

    public Personagem(string name)
    {
        Name = name;
    }
    
    public abstract void Pular();
    public abstract void Abaixar();
    public abstract void Andar();
    public abstract void Correr();
    public abstract void Atacar();
    
}