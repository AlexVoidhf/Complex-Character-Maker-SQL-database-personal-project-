
//main systemns and etc..

using System;
using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data source=heroes_database.db");
connection.Open();
var insertCmd = connection.CreateCommand();

var createTableCmd = connection.CreateCommand();
createTableCmd.CommandText = @"
    CREATE TABLE IF NOT EXISTS Characters (
        ID INTEGER PRIMARY KEY AUTOINCREMENT,
        Character_name TEXT NOT NULL,
        Race TEXT NOT NULL,
        Class TEXT NOT NULL,
        Main_weapon TEXT NOT NULL
    );
";
createTableCmd.ExecuteNonQuery();

//Main part of the program

Console.WriteLine("=======================================");
Console.WriteLine("Hello welcome to complex character creation!");
Console.WriteLine("(made by AlexVoidhf v0.1)");
Console.WriteLine("=======================================");
Console.WriteLine("                     ");

Console.Write("Write your character Name: ");
string name = Console.ReadLine();

//race selection, last added: Golem

string race = "";
while (race == "")

{
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
}


//class selection, Last added: Rogue

string Class = "";
while (Class == "")

{
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
}


//Main weapon selection, Last added: Bow

string MainWeapon = "";
while (MainWeapon == "")

{
    Console.WriteLine("                     ");
    Console.WriteLine("=================");
    Console.WriteLine("Choose your Main weapon");
    Console.WriteLine("=================");
    Console.WriteLine("                     ");
    Console.WriteLine("=================");

    Console.WriteLine("1. Sword");
    Console.WriteLine("2. Spear");
    Console.WriteLine("3. Axe");
    Console.WriteLine("4. Bow");
    Console.WriteLine("                     ");

    string MainWeaponChoice = Console.ReadLine();

    if (MainWeaponChoice == "1")
    {
        MainWeapon = "Sword";
    }
    else if (MainWeaponChoice == "2")
    {
        MainWeapon = "Spear";
    }
    else if (MainWeaponChoice == "3")
    {
        MainWeapon = "Axe";
    }
    else if (MainWeaponChoice == "4")
    {
        MainWeapon = "Bow";
    }
    else
    {
        Console.WriteLine("please try again");
    }
}


//SQL stuff

insertCmd.CommandText = @"
    INSERT INTO Characters (Character_name, Race, Class, Main_weapon)
    VALUES (@name, @race, @class, @weapon);";
insertCmd.Parameters.AddWithValue("@name", name);
insertCmd.Parameters.AddWithValue("@race", race);
insertCmd.Parameters.AddWithValue("@class", Class);
insertCmd.Parameters.AddWithValue("@weapon", MainWeapon);
insertCmd.ExecuteNonQuery();
Console.WriteLine($"\n[SUCCESS] Character '{name}' was created and saved to the database!");