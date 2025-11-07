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

Console.WriteLine(fruits.ElementAt(5));
