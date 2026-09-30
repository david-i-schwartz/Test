# Test
 Test of GitHub

## DieRoller

A C# console app that rolls a simulated die with a user-chosen number of sides.

```
cd DieRoller
dotnet run
```

Enter the number of sides (2 or more), then press Enter to roll, `n` for a new die, or `q` to quit.

Design: OOP with composition only (no inheritance). `Die` holds its side count and an injected `Random`;
`DieRollerApp` owns the prompt loop and takes its input/output streams as constructor arguments; `Program.cs` wires them together.
