public class SimpleGoal : Goal
{
    private bool isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        if (!isComplete)
        {
            isComplete = true;
            Console.WriteLine($"✔ Goal '{Name}' completed.");
        }
        else
        {
            Console.WriteLine($"⚠ Goal '{Name}' was already completed.");
        }
    }

    public override bool IsComplete() => isComplete;

    public override string GetStringRepresentation() =>
        $"[ {(isComplete ? "X" : " ")} ] {Name} - {Description} ({Points} points)";
}
