using System;
using System.Collections.Generic;

// =================== CREATIVE FEATURES IMPLEMENTED ===================
//
// 1️⃣ Object-Oriented Design 🏗️
// ---------------------------------------------------------
// - Uses a base class `Activity` to avoid duplication and 
//   enforce **inheritance** for different activities.
// - Attributes like date and duration are inherited by all 
//   activity types (`Running`, `Cycling`, `Swimming`).
//
// 2️⃣ Polymorphism: Method Overriding 🔁
// ---------------------------------------------------------
// - Abstract methods `GetDistance()`, `GetSpeed()`, and `GetPace()` 
//   are overridden in each activity class.
// - The `GetSummary()` method in the base class uses virtual methods 
//   to dynamically retrieve data.
//
// 3️⃣ Encapsulation & Data Protection 🔒
// ---------------------------------------------------------
// - All attributes are **private** or **protected**, ensuring data integrity.
// - Getters provide controlled access, avoiding direct modifications.
//
// 4️⃣ List-Based Storage 📜
// ---------------------------------------------------------
// - Stores different activity objects (`Running`, `Cycling`, `Swimming`) 
//   inside a **single list** using polymorphism.
//
// 5️⃣ Clear & Readable Summary Output 🎯
// ---------------------------------------------------------
// - The program prints formatted summaries for each activity,
//   making it easy to interpret results.
//
// ====================================================================

class Program
{
    static void Main()
    {
        // 🏋️‍♂️ Creating instances of different exercise activities
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Parse("2023-11-03"), 30, 4.8),   // Running: 4.8 km
            new Cycling(DateTime.Parse("2023-11-03"), 45, 20.5),  // Cycling: 20.5 km/h
            new Swimming(DateTime.Parse("2023-11-03"), 60, 40)    // Swimming: 40 laps
        };

        // 🌟 Displaying formatted exercise summaries
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("======= EXERCISE TRACKING SUMMARY =======");
        Console.ResetColor();

        foreach (Activity activity in activities)
        {
            // 📌 Calls GetSummary(), demonstrating polymorphism
            Console.WriteLine(activity.GetSummary());
        }
    }
}
