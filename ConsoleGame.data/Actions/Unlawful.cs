using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Unlawful
    {
        public void unlawful()
    {

        Suspect1 suspect1 = new Suspect1();
        Suspect2 suspect2 = new Suspect2();
        Suspect3 suspect3 = new Suspect3();


    Console.Clear();
    
        while (true)
        {
            System.Console.WriteLine($"{suspect1.Name}  {suspect1.Age}  {suspect1.Occupation}   {suspect1.Relationship}\n\n" +
                            $"{suspect2.Name}   {suspect2.Age}  {suspect2.Occupation}   {suspect2.Relationship}\n\n" +
                            $"{suspect3.Name}   {suspect3.Age}  {suspect3.Occupation}   {suspect3.Relationship}\n\n");
            Console.WriteLine(
            "----------------Shady Options (2 moves)----------\n" +
            "1. Break into Suspect 1 Home\n" +
            "2. Break into Suspect 2 Home\n" +
            "3. Break into Suspect 3 Home\n" +
            "---------Really Shady Options (50/50)--------\n" +
            "4. Coerce a confession from Suspect 1\n" +
            "5. Coerce a confession from Suspect 2\n" +
            "6. Coerce a confession from Suspect 3\n" +
            "7. Solve the Murder!\n" +
            "0. Return to previous menu"
            );
        
        string selection = Console.ReadLine() ?? "";
        switch (selection)
        {
            case "1":
                //
                break;
            case "2":
                //
                break;
            case "3":
                //
                break;
            case "4":
                //
                break;
            case "5":
                //
                break;
            case "6":
                //
                break;
            case "7":
                //
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Please enter a valid selection.");
                Program.PauseAndWaitForKeypress();
                break;
        }
        
        }
    }   
    }
