public class Program
{
public static void Main()
{

SuspectInterview suspectInterview = new SuspectInterview();
WitnessInterview witnessInterview = new WitnessInterview();
RunBackgroundCheck runBackgroundCheck = new RunBackgroundCheck();
Forensics forensics = new Forensics();
Warrants warrants = new Warrants();
Unlawful unlawful = new Unlawful();
SolveMurder solveMurder = new SolveMurder();

Console.Clear();
System.Console.WriteLine("----Murder Solve---\n");
System.Console.WriteLine("You are a small-town detective who’s been assigned to a murder scene: the local bar, ___________ in rural _________, ___. A long-time local resident, ___________, had just finished a beer, when he suddenly fell off of his stool. Fellow patrons rushed to help him back up thinking he’d lost his balance, only to find that he was dead! Detective Player’s job is to find out who did it, and fast! \n\n\n");

System.Console.WriteLine("Your Challenge!  You only have 7 detective choices that you can make to solve this case.  Each choice can provide information to help in determining from the 3 suspects who did it!  Be careful of using UnLawful tactic choices!");

PauseAndWaitForKeypress();

bool continueToRun = true;

    while (continueToRun)
    {
        Console.Clear();
        Console.WriteLine(
        "----Murder Solve---\n" +
        "1. Suspects\n" +
        "2. Witnesses\n" +
        "3. Background Check(s)\n" +
        "4. Forensic Options\n" +
        "5. Try for Warrant(s)\n" +
        "6. Unlawful Tactics\n" +
        "7. Solve the Murder!\n" +
        "0. Exit"
        );

        string selection = Console.ReadLine() ?? "";
        switch (selection)
        {
            case "1":
                suspectInterview.suspects();
                break;
            case "2":
                witnessInterview.witnesses();
                break;
            case "3":
                runBackgroundCheck.background();
                break;
            case "4":
                forensics.forensics();
                break;
            case "5":
                warrants.warrants();
                break;
            case "6":
                unlawful.unlawful();
                break;
            case "7":
                solveMurder.solveMurder();
                break;
            case "0":
                continueToRun = false;
                break;
            default:
                Console.WriteLine("Please enter a valid selection.");
                PauseAndWaitForKeypress();
                break;
        }
    }
    Console.WriteLine("Goodbye!");




    
    
    


}

public static void PauseAndWaitForKeypress()
    {
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}