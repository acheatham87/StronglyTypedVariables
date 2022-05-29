using System;
using System.Collections.Generic;

// VARIABLES

string name = "Julio";
int num = 42;
List<bool> boolList = new List<bool>();
double percentage = 0.99;


// DICTIONARIES SIMILAR TO OBJECTS IN JS; KEY VALUE PAIRS

Dictionary<string, int> bowlingScores = new Dictionary<string, int>();

bowlingScores.Add("Marvin", 80);
bowlingScores.Add("Denise", 290);
bowlingScores.Add("Alef", 220);
bowlingScores.Add("Wilma", 200);


// CUSTOM TYPES BETTER KNOWN AS CLASSES
// The class, "Dog", is declared below...
Dog rusty = new Dog()
{
    Breed = "mut",
    Name = "Rusty",
    Age = 10,
    HasShots = true
};

System.Console.WriteLine(rusty.Name);

public class Dog
{
    public string Breed { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public bool HasShots { get; set; }
}
