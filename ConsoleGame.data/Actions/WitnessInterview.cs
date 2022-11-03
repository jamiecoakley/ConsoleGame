public class WitnessInterview
{

public void witnesses()
    {

    Witness witness1 = new Witness1();
    Witness witness2 = new Witness2();
    Witness witness3 = new Witness3();
    
    Console.Clear();
    
        while (true)
        {   
            System.Console.WriteLine($"{witness1.Name}  {witness1.Age}  {witness1.Occupation}   {witness1.Role}\n\n" +
                                    $"{witness2.Name}   {witness2.Age}  {witness2.Occupation}   {witness2.Role}\n\n" +
                                    $"{witness3.Name}   {witness3.Age}  {witness3.Occupation}   {witness3.Role}\n\n");

            Console.WriteLine(
            "------------Options-----------\n" +
            "1. Interview Witness 1\n" +
            "2. Interview Witness 2\n" +
            "3. Interview Witness 3\n" +
            "4. Solve the Murder!\n" +
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