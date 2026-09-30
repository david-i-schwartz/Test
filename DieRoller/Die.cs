namespace DieRoller;

/// <summary>
/// A single die with a fixed number of sides.
/// Sealed: this design uses composition, not inheritance.
/// </summary>
public sealed class Die
{
    private readonly Random _random;

    public int Sides { get; }

    public Die(int sides, Random random)
    {
        if (sides < 2)
        {
            throw new ArgumentOutOfRangeException(nameof(sides), "A die must have at least 2 sides.");
        }

        Sides = sides;
        _random = random ?? throw new ArgumentNullException(nameof(random));
    }

    /// <summary>Returns a value from 1 to Sides, inclusive.</summary>
    public int Roll() => _random.Next(1, Sides + 1);
}
