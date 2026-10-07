using System;
using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data source=heroes_database.db");
connection.Open();
var insertCmd = connection.CreateCommand();

Console.WriteLine("=======================================");
Console.WriteLine("Hello welcome to complex character creation!");
Console.WriteLine("(made by AlexVoidhf v0.0)");
Console.WriteLine("=======================================");
Console.WriteLine("                     ");

Console.Write("Write your character Name: ");
string name = Console.ReadLine();

//race selection, last added: Golem

Console.WriteLine("                     ");
Console.WriteLine("=================");
Console.WriteLine("Choose your race");
Console.WriteLine("=================");
Console.WriteLine("                     ");
Console.WriteLine("=================");

Console.WriteLine("1. Human");
Console.WriteLine("2. Elf");
Console.WriteLine("3. Goblin");
Console.WriteLine("4. Golem");
Console.WriteLine("=================");
Console.WriteLine("                     ");



string RaceChoice = Console.ReadLine();
string race = "";

if (RaceChoice == "1")
{
    race = "Human";
}
else if (RaceChoice == "2")
{
    race = "Elf";
}
else if (RaceChoice == "3")
{
    race = "Goblin";
}
else if (RaceChoice == "4")
{
    race = "Golem";
}
else
{
    Console.WriteLine("please try again");
}

//class selection, Last added:

Console.WriteLine("                     ");
Console.WriteLine("=================");
Console.WriteLine("Choose your class");
Console.WriteLine("=================");
Console.WriteLine("                     ");
Console.WriteLine("=================");

Console.WriteLine("1. Warrior");
Console.WriteLine("2. Paladin");
Console.WriteLine("3. Mage");
Console.WriteLine("4. Rogue");
Console.WriteLine("                     ");

string ClassChoice = Console.ReadLine();
string Class = "";

if (ClassChoice == "1")
{
    Class = "Warrior";
}
else if (ClassChoice == "2")
{
    Class = "Paladin";
}
else if (ClassChoice == "3")
{
    Class = "Mage";
}
else if (ClassChoice == "4")
{
    Class = "Rogue";
}
else
{
    Console.WriteLine("please try again");
}
