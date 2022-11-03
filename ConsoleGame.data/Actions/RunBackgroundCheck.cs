public class RunBackgroundCheck
{
    public void background()
    {

        Suspect1 suspect1 = new Suspect1();
        Suspect2 suspect2 = new Suspect2();
        Suspect3 suspect3 = new Suspect3();
        Victim victim = new Victim();


    Console.Clear();
    
        while (true)
        {
            System.Console.WriteLine($"{suspect1.Name}  {suspect1.Age}  {suspect1.Occupation}   {suspect1.Relationship}\n\n" +
                            $"{suspect2.Name}   {suspect2.Age}  {suspect2.Occupation}   {suspect2.Relationship}\n\n" +
                            $"{suspect3.Name}   {suspect3.Age}  {suspect3.Occupation}   {suspect3.Relationship}\n\n" +
                            $"{victim.Name}   {victim.Age}  {victim.Occupation}   {victim.CauseOfDeath}\n\n");
            Console.WriteLine(
            "------------Options-----------\n" +
            "1. Run Background Check on Suspect 1\n" +
            "2. Run Background Check on Suspect 2\n" +
            "3. Run Background Check on Suspect 3\n" +
            "4. Run Background Check on Victim\n" +
            "5. Solve the Murder!\n" +
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