namespace DieRoller;

/// <summary>
/// Drives the command-prompt interaction: asks the user for the number of
/// sides, creates a <see cref="Die"/>, and rolls it on request.
/// Sealed: this design uses composition, not inheritance.
/// </summary>
public sealed class DieRollerApp
{
    private readonly TextReader _input;
    private readonly TextWriter _output;
    private readonly Random _random;

    public DieRollerApp(TextReader input, TextWriter output, Random random)
    {
        _input = input;
        _output = output;
        _random = random;
    }

    public void Run()
    {
        _output.WriteLine("=== N-Sided Die Roller ===");

        bool keepGoing = true;
        while (keepGoing)
        {
            int? sides = PromptForSides();
            if (sides is null)
            {
                break;
            }

            var die = new Die(sides.Value, _random);
            keepGoing = RollLoop(die);
        }

        _output.WriteLine("Goodbye!");
    }

    /// <summary>Returns the chosen number of sides, or null if the user quits.</summary>
    private int? PromptForSides()
    {
        while (true)
        {
            _output.Write("Enter the number of sides (2 or more), or 'q' to quit: ");
            string? line = _input.ReadLine();

            if (line is null || IsQuit(line))
            {
                return null;
            }

            if (int.TryParse(line.Trim(), out int sides) && sides >= 2)
            {
                return sides;
            }

            _output.WriteLine("Invalid input. Please enter a whole number of 2 or more.");
        }
    }

    /// <summary>
    /// Rolls the die until the user asks for a new die (returns true)
    /// or quits (returns false).
    /// </summary>
    private bool RollLoop(Die die)
    {
        _output.WriteLine($"You now have a {die.Sides}-sided die.");

        while (true)
        {
            _output.Write("Press Enter to roll, 'n' for a new die, or 'q' to quit: ");
            string? line = _input.ReadLine();

            if (line is null || IsQuit(line))
            {
                return false;
            }

            string choice = line.Trim().ToLowerInvariant();
            if (choice == "n")
            {
                return true;
            }

            if (choice.Length == 0 || choice == "r")
            {
                _output.WriteLine($"You rolled a {die.Roll()} (d{die.Sides}).");
            }
            else
            {
                _output.WriteLine("Unrecognized option.");
            }
        }
    }

    private static bool IsQuit(string line) =>
        line.Trim().Equals("q", StringComparison.OrdinalIgnoreCase);
}
