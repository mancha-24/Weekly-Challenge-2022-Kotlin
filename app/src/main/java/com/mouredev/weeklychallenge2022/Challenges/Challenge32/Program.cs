// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculating next 10 leap years from one gave...");
const int nextYears = 30;
var entry = GetEntry();
if (entry.IsSuccess)
{
    var currentYear = entry.year + 1;
    var lastYear = entry.year + nextYears;
    var leapYears = new List<int>();

    while(currentYear <= lastYear)
    {
         if(IsYearLeap(currentYear)) 
            leapYears.Add(currentYear);

        currentYear++;
    }
    Console.WriteLine("These years are leap:");
    leapYears.ForEach(p => Console.WriteLine(p));
    Console.WriteLine($"Total: {leapYears.Count} from {entry.year} to {lastYear}");
}
else
{
    Console.WriteLine($"You must insert a valid year...");
}
Finish();

static (bool IsSuccess, int year) GetEntry()
{
    Console.WriteLine("Insert a year: ");
    return int.TryParse(Console.ReadLine(), out int yearOut) && yearOut > 0 ? (true, yearOut) : (false, 0);
}

static bool IsYearLeap(int year) => (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));

static void Finish() => Console.WriteLine("Press any key to finish... take care!!"); Console.ReadKey();