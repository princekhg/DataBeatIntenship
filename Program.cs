using System;   
using System.Linq;
// Including Linq
public class LINQ
{
    string str=" ";
    // method to read the string 
    public void read()
    {
        Console.WriteLine("Input String  ---- ");
        str = Console.ReadLine();   
    }
    // MEthod to Count and display the output of each string 
    public void CountDisplay()
    {
        // Since upper or lower case doesn't change the character.
        // I've converted the value to UpperCase for ease.
        //Can be a choice but better to for user understanding
        str = str.ToUpper();
        //Creating LINQ query by grouping each character in string
        //and then into a variable vari and then selecting vari as the final
        //value to be added to countFreq variable.
        var countFreq = from s in str
                        group s by s into vari
                        select vari;
        //Since the Groupby provides a key we can use key to print values and aggregate 
        //function Count can add all the values to show total count
        Console.WriteLine("The Frquency of Each Character in the given String is --- ");
        foreach (var c in countFreq)
        {
            //White space character can be intercepted inside name
            // So if will check and avoid that key and loop can resume to next iteration
            // This is easy..
            if (Char.IsWhiteSpace(c.Key))
                continue;
            Console.WriteLine("Character " + c.Key + " has frequency of - " + c.Count());
        }
    }
    public static void Main(string[] args)
    {
        // Creating object of class
        LINQ linq=new LINQ();
        // calling read method 
        linq.read();
        //Calling CountDisplay()
        linq.CountDisplay();
    }
}