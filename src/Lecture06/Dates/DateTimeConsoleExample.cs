public static class DateTimeConsoleExample
{
    public static void Run()
    {
        Console.WriteLine("DateTimeConsoleExample");

        DateTime now = DateTime.Now;

        // Properties
        Console.WriteLine($"Current date and time: {now}");
        Console.WriteLine($"Current Year: {now.Year}");
        Console.WriteLine($"Current Month: {now.Month}");
        Console.WriteLine($"Current Day: {now.Day}");
        Console.WriteLine($"Current Hour: {now.Hour}");
        Console.WriteLine($"Current Minute: {now.Minute}");
        Console.WriteLine($"Current Second: {now.Second}");
        Console.WriteLine($"Current Millisecond: {now.Millisecond}");
        Console.WriteLine($"Current Day of Week: {now.DayOfWeek}");
        Console.WriteLine($"Current Day of Year: {now.DayOfYear}");
        Console.WriteLine($"Current Time: {now.TimeOfDay}");
        Console.WriteLine($"Current Tick: {now.Ticks}");
        Console.WriteLine($"Current Kind: {now.Kind}");

        // Popular Methods
        Console.WriteLine($"Current Date (ToShortDateString): {now.ToShortDateString()}");
        Console.WriteLine($"Current Date (ToLongDateString): {now.ToLongDateString()}");
        Console.WriteLine($"Current Time (ToShortTimeString): {now.ToShortTimeString()}");
        Console.WriteLine($"Current Time (ToLongTimeString): {now.ToLongTimeString()}");
        Console.WriteLine($"Current Time (ToUniversalTime): {now.ToUniversalTime()}");

        // Formatting
        Console.WriteLine($"Current Date and Time (d): {now:d}"); // .ToString("d")
        Console.WriteLine($"Current Date and Time (D): {now:D}"); // .ToString("D")
        Console.WriteLine($"Current Date and Time (t): {now:t}"); // .ToString("t")
        Console.WriteLine($"Current Date and Time (T): {now:T}"); // .ToString("T")
        Console.WriteLine($"Current Date and Time (f): {now:f}"); // .ToString("f")
        Console.WriteLine($"Current Date and Time (F): {now:F}"); // .ToString("F")
        Console.WriteLine($"Current Date and Time (g): {now:g}"); // .ToString("g")
        Console.WriteLine($"Current Date and Time (G): {now:G}"); // .ToString("G")

        Console.WriteLine(
            $"Current Date and Time (yyyy-MM-dd HH:mm:ss): {now:yyyy-MM-dd HH:mm:ss}" // .ToString("yyyy-MM-dd HH:mm:ss")
        );
        Console.WriteLine(
            $"Current Date and Time (yyyy-MM-dd HH:mm:ss.fff): {now:yyyy-MM-dd HH:mm:ss.fff}" // .ToString("yyyy-MM-dd HH:mm:ss.fff")
        );
        Console.WriteLine(
            $"Current Date and Time (yyyy-MM-dd HH:mm:ss.fff tt zzz): {now:yyyy-MM-dd HH:mm:ss.fff tt zzz}" // .ToString("yyyy-MM-dd HH:mm:ss.fff tt zzz")
        );

        Console.WriteLine("--------------------------------");
        Console.WriteLine("Parsing");
        Console.WriteLine("--------------------------------");
        string dateString = "2025-10-29 14:30";
        DateTime parsed = DateTime.Parse(dateString);
        Console.WriteLine($"Parsed Date and Time: {parsed}");

        TimeZoneInfo localZone = TimeZoneInfo.Local;
        TimeZoneInfo utcZone = TimeZoneInfo.Utc;
        TimeZoneInfo tokyoZone = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
        Console.WriteLine(localZone.DisplayName);

        DateTime utcNow = DateTime.UtcNow;

        DateTime tokyoTime = TimeZoneInfo.ConvertTimeFromUtc(
            utcNow,
            TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time")
        );

        Console.WriteLine(tokyoTime);

        // DateOnly
        DateOnly date = new DateOnly(2025, 10, 29);
        Console.WriteLine(date); // 10/29/2025
        Console.WriteLine(date.DayOfWeek); // Wednesday

        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        Console.WriteLine(today);

        // Operations
        var start = new DateOnly(2025, 10, 29);
        var end = start.AddDays(5); // 2025-11-03

        int comparison = start.CompareTo(end); // -1
        bool equal = start == end; // false

        // Conversions
        DateTime dt = DateTime.Now;
        DateOnly dateOnly = DateOnly.FromDateTime(dt);

        DateTime backToDateTime = dateOnly.ToDateTime(TimeOnly.MinValue);

        // TimeOnly
        TimeOnly startTime = new TimeOnly(8, 30);
        TimeOnly endTime = new TimeOnly(17, 0);

        Console.WriteLine(startTime); // 08:30
        Console.WriteLine(endTime); // 17:00

        // Operations
        var timeNow = TimeOnly.FromDateTime(DateTime.Now);
        Console.WriteLine(now.AddHours(2));
        Console.WriteLine(startTime < endTime); // True

        // Conversions
        DateTime dtNow = DateTime.Now;
        TimeOnly timeOnly = TimeOnly.FromDateTime(dtNow);
        DateTime combined = dateOnly.ToDateTime(timeOnly);
    }
}
