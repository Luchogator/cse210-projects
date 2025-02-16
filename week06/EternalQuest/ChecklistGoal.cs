public class ChecklistGoal : Goal
{
    private int amountCompleted = 0;
    private int target;
    private int bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        this.target = target;
        this.bonus = bonus;
    }

    public override void RecordEvent()
    {
        amountCompleted++;
        Console.WriteLine($"✅ Recorded progress in '{Name}'. {amountCompleted}/{target}");

        if (amountCompleted == target)
        {
            Console.WriteLine($"🎉 Goal '{Name}' completed! You receive a bonus of {bonus} points.");
            Points += bonus;
        }
    }

    public override bool IsComplete() => amountCompleted >= target;

    public override string GetStringRepresentation() =>
        $"[ {(IsComplete() ? "X" : " ")} ] {Name} - {Description} ({amountCompleted}/{target} times, {Points} points)";
}
