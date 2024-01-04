using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program2
{ 
    static void Main()
    {
        string inputString = "Hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf32432 12122000abc d34234jh dfh";
        List<string> ValidDates = FindDatesInString(inputString);

        Console.WriteLine("Valid dates found: " + string.Join(", ", ValidDates));
    }

    static List<string> FindDatesInString(string inputString)
    {
        List<string> validDates = new List<string>();
        Regex datePattern = new Regex(@"\b(\d{2})(\d{2})(\d{4})\b");
        MatchCollection matches = datePattern.Matches(inputString);
        foreach (Match match in matches)
        {
            int month = int.Parse(match.Groups[1].Value);
            int day = int.Parse(match.Groups[2].Value);
            int year = int.Parse(match.Groups[3].Value);
            if (1 <= month && month <= 12 && 1 <= day && day <= 31)
            {
                validDates.Add($"{month:D2}{day:D2}{year}");
            }
        }
        return validDates;
    }
}
