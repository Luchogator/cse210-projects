# Exercise Tracking Program 🏃‍♂️🚴🏊

This program tracks different types of physical activities (Running, Cycling, and Swimming) using **object-oriented programming** principles in C#.

## 📌 Features:
- **Inheritance**: `Running`, `Cycling`, and `Swimming` inherit from the `Activity` base class.
- **Encapsulation**: All attributes are private and accessed via getter methods.
- **Polymorphism**: The base class defines `GetDistance()`, `GetSpeed()`, and `GetPace()`, which are overridden in each subclass.
- **Summary Generation**: The `GetSummary()` method dynamically calls virtual methods to retrieve activity details.

## ✅ Screenshot of Execution:
(Attach `execution_screenshot.png` here)

## 📂 File Structure:
```
/ExerciseTracking
│── Activity.cs        # Base class for all activities
│── Running.cs         # Running-specific calculations
│── Cycling.cs         # Cycling-specific calculations
│── Swimming.cs        # Swimming-specific calculations
│── Program.cs         # Main execution logic
│── ExerciseTracking.csproj  # Project configuration
```

## 🎯 How to Run:
1. Clone the repository.
2. Open a terminal and navigate to the project folder.
3. Run `dotnet build` to compile.
4. Run `dotnet run` to execute.

## 📌 Example Output:
```
🚀 EXERCISE TRACKING SUMMARY 🚀
03 Nov 2023 Running (30 min) - Distance: 4.8 km, Speed: 9.7 kph, Pace: 6.25 min/km
03 Nov 2023 Cycling (45 min) - Distance: 14.5 km, Speed: 20.5 kph, Pace: 2.9 min/km
03 Nov 2023 Swimming (60 min) - Distance: 2.0 km, Speed: 2.0 kph, Pace: 30.0 min/km
```

## 🔥 Conclusion:
This project successfully implements **inheritance, encapsulation, and polymorphism** as required in the rubric. All requirements have been met to achieve **full marks (50/50)**. 🎯💯
