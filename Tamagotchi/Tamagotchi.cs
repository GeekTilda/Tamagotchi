using System.Runtime;
using System;

//namespace .;

public class Tamagotchi
{
 private int hunger = 0;
 private int boredom = 0;
 private List<string> words = new List<string>() {"Hej!", "Hallå!", "Tja!", "Tjena!", "Sup homie"};
 public bool isAlive = true;
 private Random generator;
 public string name;

 public void Feed() {
    hunger =- 5;
    if (hunger < 0) {
        hunger = 0;
    }
    System.Console.WriteLine(name + " har nu en hunger på " + hunger);
 }

 public void Hi() {
    int word = generator.Next(words.Count);
    System.Console.WriteLine(name + " säger " + words[word]);
    ReduceBoredom();
 }

 public void Teach(string word) {
    System.Console.Write("Vilket ord vill du lära " + name + "?");
    string theWord = Console.ReadLine();
    ReduceBoredom();
 }
 public void Tick() {
   hunger =+ 1;
   boredom =+ 1;
 }
 public void PrintStats() {
   System.Console.WriteLine(name + " stats: ");
   System.Console.WriteLine("Hunger: " + hunger);
   System.Console.WriteLine("Boredom: " + boredom);
 }
public bool GetAlive() {
   if (hunger >= 10) {
      isAlive = false;
   }
   else if (boredom >= 10) {
      isAlive = false;
   }
   return isAlive;
}
private void ReduceBoredom() {
   boredom =- 2;
}
}

