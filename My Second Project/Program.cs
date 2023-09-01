Console.Write("Welcome, today you'll be using a very special calculator!\n Please, input the x value:  ");
int x = int.Parse(Console.ReadLine());
Console.Write("\n And now y value, please: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("\nNow, behold!");
Console.WriteLine($"The result of -6*x^3+5*x^2-10*x+15 is:{(-6 * Math.Pow(x, 3)) + (5 * Math.Pow(x, 2)) - 10 * x + 15}");
Console.WriteLine($"The result of abs(x)*sin(x) is: {Math.Abs(x) * Math.Sin(x):F3}");
Console.WriteLine($"The result of 2*pi*x is: {2 * Math.PI * x:F3}");
Console.WriteLine($"The result of max(x, y) is: {Math.Max(x, y)}");
Console.WriteLine("\nNow behold, the most magical feature of this program - New Year Predictor!");

DateTime previousNewYear = new DateTime(DateTime.Now.Year, 1, 1);
DateTime currentDate =  DateTime.Now;
DateTime nextNewYear = new DateTime(DateTime.Now.Year + 1, 1, 1);

TimeSpan previousNewYearSpan = currentDate - previousNewYear;
Console.WriteLine($"It's been {previousNewYearSpan.Days} since last New Year, can't wait for the next one!");
TimeSpan nextNewYearSpan = nextNewYear - currentDate;
Console.WriteLine($"It's only {nextNewYearSpan.Days} until next New Year, have you already put up the Christmas Tree? :D");
