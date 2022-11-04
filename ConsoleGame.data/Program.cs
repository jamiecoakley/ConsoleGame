public class Program
{
public static void Main()
{

Suspect suspect1 = new Suspect("WifeName", 30, "Homemaker", "Wife", false, true, new List<string>{
    "At home seething, he went out to the bar again! I was home alone, washing the dishes. Someone has to clean up and it certainly wasn’t going to be him.", 
    "He’s a good-for-nothing scoundrel who goes out to the bar too much! There’s no way he’s not cheating on me, gone until all hours of the night.",
    "Nope, wasn’t there.",
    "Nope, I wasn’t there."
}, 
null);
Suspect suspect2 = new Suspect("CoWorkerName", 30, "Engineer", "Co-Worker", false, false, new List<string>{
    "I was at the bar, sitting a few seats down from (victim) trying to ignore him! I wish there was any other bar to go to in this town where I could go to drown my sorrows… I don’t know why the boss gave (victim) the promotion after that crap he pulled a couple years ago. My buddy met me there after work.", 
    "The boss gave (victim) the promotion I worked so hard for, even after his check fraud incident and coming into work drunk!",
    "He was wobbly because he’s a stupid drunk! This is the only bar in this town! I couldn’t avoid him!",
    "I was trying to ignore him. I don’t remember seeing his wife there. There’s no way he would bring her, they can’t stand each other."
}, null);
Suspect suspect3 = new Suspect("Rusty Shackelford", 30, "Exterminator", "Town crazy", true, false, new List<string>{
    "I was trying to get (victim) to buy me another beer. He bought me one last time! The bouncer kicked me out, so I was panhandling outside the bar to see if someone would give me beer money. I was just trying to get (victim) to buy me a beer by any means necessary!", 
    "We kinda got into it a year or so ago when I just wanted another beer the last time he bought me a beer. He could afford it! I saw all that cash in his wallet!",
    "I didn’t do nothin’",
    "I’d have remembered seeing a lady in the bar! (Suspect 2) pointed and whispered to the person sitting next to him… we made eye contact when (victim) bought me a beer."
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