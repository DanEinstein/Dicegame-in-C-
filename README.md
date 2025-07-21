# 🎲 Dice Game in C#

This is a beginner-friendly dice game project built using **C#**. It uses the `Random` class to simulate the rolling of three dice and applies bonus logic to determine if the player wins or loses.I have created this game with a aim of understanding how conditionals work in C# 

---

## 📌 Description

The game rolls **three dice**, each producing a number between **1 and 6**. Bonuses are added based on the outcome:

- 🎁 **+2 Bonus** if any two dice match (doubles)
- 🎁 **+6 Bonus** if all three dice match (triples)

The total score determines the result:
- ✅ **Win** if total score is **15 or more**
- ❌ **Lose** if total score is **less than 15**

---

## 💡 Features

- Simulates rolling 3 dice
- Adds bonuses for matching numbers
- Displays results with bonus info
- Console-based interaction

---

## 🚀 Getting Started

### ✅ Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) installed

### ⚙️ Setup and Run

1. Create a new console project:
   ```bash
   dotnet new console
2. Run the project using the : dotnet run command
