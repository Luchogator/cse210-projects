using System;

// =================== CREATIVE FEATURES IMPLEMENTED ===================
//
// 1️⃣ Improved User Interface 🎨
// ---------------------------------------------------------
// - The program now features colors and emojis for a more 
//   engaging and readable UI.
// - Titles and separators make the program visually appealing.
// - Error messages appear in red for better visibility.
//
// 2️⃣ Leveling System 🎖
// ---------------------------------------------------------
// - Users level up every 1000 points.
// - A message is displayed when a new level is reached.
//
// 3️⃣ Achievements & Progress Bonuses 🏆
// ---------------------------------------------------------
// - Users earn special achievement messages when they 
//   reach key milestones (e.g., 500 points, 1000 points).
// - Checklist goals offer bonus points when fully completed.
//
// 4️⃣ Advanced Input Validation ✅
// ---------------------------------------------------------
// - Ensures users only enter valid numbers for goal creation.
// - Prevents crashes when entering non-numeric values.
// - Rejects out-of-range inputs for goal selection.
//
// 5️⃣ Enhanced File Handling 📂
// ---------------------------------------------------------
// - Saves and loads goals in a structured text format (.txt).
// - Automatically creates the "Data/" directory if it does not exist.
// - Prevents crashes if the save file is missing or corrupted.
//
// ====================================================================

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        manager.LoadGoals();

        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================================");
            Console.WriteLine("🌟  WELCOME TO THE ETERNAL QUEST  🌟");
            Console.WriteLine("====================================");
            Console.ResetColor();
            Console.WriteLine($"🎯 Score: {manager.Score} | 🎖 Level: {manager.Level}");
            Console.WriteLine("\n1. 📋 List Goals");
            Console.WriteLine("2. ✏ Create New Goal");
            Console.WriteLine("3. ✅ Record Progress");
            Console.WriteLine("4. 💾 Save and Exit");
            Console.Write("\nSelect an option: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    manager.ListGoals();
                    break;
                case "2":
                    manager.CreateGoal();
                    break;
                case "3":
                    manager.RecordEvent();
                    break;
                case "4":
                    manager.SaveGoals();
                    Console.WriteLine("📂 Data saved. Exiting...");
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("❌ Invalid option. Please enter a number between 1 and 4.");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
        }
    }
}
