using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class SolveMurder
    {
        public void solveMurder()
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
            "----------------Options----------\n" +
            "1. Suspect 1 is Guilty!\n" +
            "2. Suspect 2 is Guilty!\n" +
            "3. Suspect 3 is Guilty!\n" +
            "4. No one did it, he died of natural causes...\n" +
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