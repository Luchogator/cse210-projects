public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"📖 Recorded progress in '{Name}'. +{Points} points.");
    }

    public override bool IsComplete() => false;

    public override string GetStringRepresentation() =>
        $"[∞] {Name} - {Description} ({Points} points each time)";
}
