public class Program
{
public static void Main()
{

Suspect suspect1 = new Suspect("WifeName", 30, "Homemaker", "Wife", false, true, new List<string>{
    "At home seething, he went out to the bar again!", 
    "He’s a good-for-nothing scoundrel who goes out to the bar too much! There’s no way he’s not cheating on me, gone until all hours of the night.",
    "Nope, wasn’t there.",
    "Nope, wasn’t there."
}, 
null);
Suspect suspect2 = new Suspect("CoWorkerName", 30, "Engineer", "Co-Worker", false, false, new List<string>{
    "At home seething, he went out to the bar again!", 
    "He’s a good-for-nothing scoundrel who goes out to the bar too much! There’s no way he’s not cheating on me, gone until all hours of the night.",
    "Nope, wasn’t there.",
    "Nope, wasn’t there."
}, null);
Suspect suspect3 = new Suspect("Rusty Shackelford", 30, "Exterminator", "Town crazy", true, false, new List<string>{
    "At home seething, he went out to the bar again!", 
    "He’s a good-for-nothing scoundrel who goes out to the bar too much! There’s no way he’s not cheating on me, gone until all hours of the night.",
    "Nope, wasn’t there.",
    "Nope, wasn’t there."
}, new List<Crime>{
    new Crime(
        "Assault",
        "Felony: Guilty",
        new DateTime(2021,10,24),
        "Town",
        "State"
    ),
    new Crime(
        "Public Nuisance",
        "Misdemeanor: Guilty",
        new DateTime(2021,10,04),
        "Town",
        "State"
    ),
    new Crime(
        "Assault",
        "Felony: Guilty",
        new DateTime(2021,02,24),
        "Town",
        "State"
    ),
    new Crime(
        "Public Intoxication",
        "Misdemeanor: Guilty",
        new DateTime(2021,02,04),
        "Town",
        "State"
    ),
});
SuspectInterview suspectInterview = new SuspectInterview();
WitnessInterview witnessInterview = new WitnessInterview();
RunBackgroundCheck runBackgroundCheck = new RunBackgroundCheck();
Forensics forensics = new Forensics();
Warrants warrants = new Warrants();
Unlawful unlawful = new Unlawful();
SolveMurder solveMurder = new SolveMurder();
List<Suspect> suspects = new List<Suspect>(){suspect1, suspect2, suspect3};
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
        //"4. Forensic Options\n" +
        "4. Try for Warrant(s)\n" +
        "5. Unlawful Tactics\n" +
        "6. Solve the Murder!\n" +
        "0. Exit"
        );

        string selection = Console.ReadLine() ?? "";
        switch (selection)
        {
            case "1":
                suspectInterview.suspects(suspects);
                break;
            case "2":
                witnessInterview.witnesses();
                break;
            case "3":
                runBackgroundCheck.background(suspects);
                break;
            case "4":
                warrants.warrants(suspects);
                break;
            case "5":
                unlawful.unlawful(suspects);
                break;
            case "6":
                solveMurder.solveMurder(suspects);
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