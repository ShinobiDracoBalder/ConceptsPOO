// See https://aka.ms/new-console-template for more information
using App.ConceptsPOO.Models;

Console.WriteLine("POO Concepts!");
Console.WriteLine("!!!!!!!!!!!!!");

try
{
    Console.WriteLine(new Date(2022, 2, 28));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(2022, 12, 01));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}
