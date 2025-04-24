using System;

class WorkingWithString{

    public void usesOfStrings(){
        string name = "John Doe";

        Console.WriteLine();
        Console.WriteLine(name.Length);
        Console.WriteLine(name.ToUpper());
        Console.WriteLine(name.ToLower());
        Console.WriteLine(name.Contains("Doe"));
        Console.WriteLine(name[0]);
        Console.WriteLine(name[2]);
        Console.WriteLine(name.IndexOf("o"));
        Console.WriteLine(name.IndexOf("z"));
        Console.WriteLine(name.Substring(2));
        Console.WriteLine(name.Substring(2,3));
    }

}