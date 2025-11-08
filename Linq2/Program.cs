using System;
using System.Collections.Generic; 
using System.Linq;

var fruits = new List<string>();

fruits.Add("🍒");
fruits.Add("🍍");
fruits.Add("🍏");
fruits.Add("🍑");
fruits.Add("🫐");
fruits.Add("🥥");
fruits.Add("🍌");

//1- pegar o primeiro elemento

// Console.WriteLine(fruits.First());

// ou

// Console.WriteLine(fruits.FirstOrDefault("nao encontrado"));
//para exibir algo padrao se nao achar

//2- verificar se o elemento existe

//Console.WriteLine(fruits.Any(x => x == "🍒"));

//3- verifica se todos elementos de uma lista sao do mesmo tipo

//Console.WriteLine(fruits.All(x => x == "🍒"));

//4- contar quantos elementos tem na lista

//Console.WriteLine(fruits.Count);

//ou para contar quantos de um elemento especifico

//Console.WriteLine(fruits.Count(x=> x == "🍒"));

//5- para procurar por indice\

//Console.WriteLine(fruits.ElementAt(5));

/*6- para pegar uma determinada quantidade

//fruits.Take(3); //pegar os 3 primeiros

//fruits.Take(^3..); //pegar os 3 ultimos

//fruits.Take(0..3); //pegar do 1 ao 3

foreach (var frutas in fruits.Take(^3..).Reverse()) //exibe de tras pra frente
{
    Console.WriteLine(frutas);
}
*/

/*//7- Where

var frutas = fruits.Where(x => x == "🍒" || x == "🫐"  );

foreach (var fruta in frutas)
{
    Console.WriteLine(fruta);
}*/

//8- single //so funciona se tiver apenas um do elmento procurado

//Console.WriteLine(fruits.Single()); //erro

//Console.WriteLine(fruits.Single(x => x == "🍒")); //certo

//para usalo de forma segura, usar o try catch

//9- para pegar o ultimo elemento
//Console.WriteLine(fruits.Last());

//Console.WriteLine(fruits.Last(x=> x == "🍒"));

//10 - Skip, para pular itens

foreach (var fruit in fruits.Skip(3).Take(3)) //pula 3 e pega 3
{
    Console.WriteLine(fruit);
}