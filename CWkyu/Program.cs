// See https://aka.ms/new-console-template for more information
using CWkyu._5kyu;
using CWkyu._6kyu;

Console.WriteLine("Hello, World!");
int[] dice = new int[] { 4, 4, 4, 3, 3};
GreedIsGood rollDice = new GreedIsGood();



Console.WriteLine(rollDice.Score(dice));