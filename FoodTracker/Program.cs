DateTime currentTime = DateTime.Now;
Console.WriteLine(currentTime);
string meal = "";
if (currentTime.Hour >= 0 && currentTime.Hour < 11)
{
    meal = "Breakfast: ";

}
else if (currentTime.Hour >= 11 && currentTime.Hour < 16)
{
    meal = "Lunch: ";
}
else if (currentTime.Hour >= 16 && currentTime.Hour <= 24)
{
    meal = "Dinner: ";
}

string food = GetFood("What food do you want to input? : ");
int calories = GetCalories($"How many claories are in {food}? : ");


File.WriteAllText("Save.txt", Convert.ToString(currentTime) + " " + meal + "Food: " + food + " Calories: " + Convert.ToString(calories));




string GetFood(string prompt)
{
    Console.Write(prompt);
    while (true)
    {
        try
        {
            string? food = Console.ReadLine();
            return food;
        }
        catch
        {
        }
        Console.WriteLine("Not a valid input. Try again!");
    }
}

int GetCalories(string prompt)
{
    Console.Write(prompt);
    while (true)
    {
        try
        {
            int calories = int.Parse(Console.ReadLine());
            return calories;
        }
        catch
        {
        }
        Console.WriteLine("Not a valid input. Try again!");
    }
}