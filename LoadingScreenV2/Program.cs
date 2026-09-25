int totalsteps = 100;
int a=1;
while (a <= totalsteps)
{
    Console.WriteLine($"Loading.. Step {a} of {totalsteps}");
    if (a % 3 == 0)
    {
        Console.WriteLine("Checkpoint reached!");
    }
    a++;
}
Console.WriteLine("\nDungeon is ready. Enter now!");