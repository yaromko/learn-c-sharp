using System.Collections.Generic;

class LoopExamplesApp
{
    static void Main()
    {
        var app = new LoopExamplesApp();
        app.Run();
    }
    /// <summary>
    /// Runs the main application loop, presenting a menu of options and executing the corresponding functionality based
    /// on user input.
    /// </summary>
    /// <remarks>The method continuously displays a menu, reads user input, and performs actions based on
    /// predefined commands.  The loop terminates when the user selects the exit option. Invalid inputs are handled by
    /// displaying an error message.</remarks>
    void Run()
    {
        while (true)
        {
            PrintMenu();
            string? input = Console.ReadLine();

            switch (input)
            {
                case CountCode: CountOddNumbers(); break;
                case FindIndicesCode: FindIndicesOfE(); break;
                case StudentGradesCode: StudentGradeTracker(); break;
                case CompareToFirstCode: CompareToFirstElement(); break;
                case DiceRollsCode: DiceRollFrequencies(); break;
                case PrintMenuCode: PrintMenu(); break;
                case ExitCode: return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    private void DiceRollFrequencies()
    {
        throw new NotImplementedException();
    }

    private void CompareToFirstElement()
    {
        throw new NotImplementedException();
    }

    private void FindIndicesOfE()
    {
        throw new NotImplementedException();
    }

    private void StudentGradeTracker()
    {
        throw new NotImplementedException();
    }

    private void CountOddNumbers()
    {
        throw new NotImplementedException();
    }

    private const string CountCode = "1";
    private const string FindIndicesCode = "2";
    private const string StudentGradesCode = "3";
    private const string CompareToFirstCode = "4";
    private const string DiceRollsCode = "5";
    private const string ExitCode = "0";
    private const string PrintMenuCode = "6";

    private void PrintMenu()
    {
        Console.WriteLine($$"""
--- LoopExamples Main Menu ---

{{CountCode}}. Count Odd Numbers
{{FindIndicesCode}}. Find Indices of 'e' in a String
{{StudentGradesCode}}. Student Grade Tracker
{{CompareToFirstCode}}. Compare Numbers to the First Element
{{DiceRollsCode}}. Frequency of Dice Rolls
{{PrintMenuCode}}. Print Menu
{{ExitCode}}. Exit
Select an option: 
""");
    }
}
