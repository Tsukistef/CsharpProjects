using System.Globalization;

namespace StringsDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STRING CLASSES
            string name = "Stefania";       
            Console.WriteLine(name.Substring(4));
            Console.WriteLine(name.Replace("a", "ora"));

            string quote = "The name of the mountain is \"Fuji\"";

            string[] words = quote.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string newWord = words[i];
                Console.WriteLine(newWord);
            }

            string quote2 = "Ricardo is the best husband in the world!";
            string[] sentence = quote2.Split(' ');

            for (int i = 0; i < sentence.Length; i++)
            {
                string newSentence = sentence[i];
                Console.WriteLine(newSentence);
            }

            // String formatting
            int salary = 3293930;
            Console.WriteLine($"{nameof(salary)} : {salary:C}");
            Console.WriteLine(nameof(salary) + " : " + salary.ToString("C")); //Alternative syntax
                        
            // DATETIME CLASSES --------------------
            DateTime dob = new DateTime(1995, 3, 2);
            DateTime exactDob = new DateTime(1995, 3, 2, 12, 14, 30, 15, DateTimeKind.Local);
            DateTime now = DateTime.Now;

            Console.WriteLine(dob);
            Console.WriteLine(dob.ToString("dd/MM/yyyy"));

            // Methods DateTime
            Console.WriteLine(exactDob.DayOfWeek);
            Console.WriteLine(exactDob.DayOfYear);
            Console.WriteLine(exactDob.TimeOfDay);
            Console.WriteLine(exactDob.Kind);
            Console.WriteLine(exactDob.Ticks);

            Console.WriteLine(now);

            // Methods String
            Console.WriteLine(now.ToString("dd/MM/yyyy"));
            Console.WriteLine($"The date of birth is {dob.ToString("dd/MM/yyyy")}");

            // DateTime conversion to string
            var userDob = DateTime.Parse(dob.ToString("dd/MM/yyyy"));

            // Timezones -----------------------------

            // Utc coordinated universal time 
            var utcNow = DateTime.UtcNow;
            Console.WriteLine($"UTC now : {utcNow}");

            // Date time offset
            var tz = TimeZoneInfo.Local.GetUtcOffset(utcNow);
            Console.WriteLine($"Timezone get utc offset : {tz}");

            // User time with utc offset
            var dto = new DateTimeOffset(now, tz);
            Console.WriteLine($"date, time and zone(offset): {dto}");

            utcNow = dto.UtcDateTime;
            Console.WriteLine($"Current utc (date and time): {utcNow}");

            // Another country timezone
            var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            Console.WriteLine($"Indian Timezone: {indiaTz}");

            var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
            Console.WriteLine($"India date and time: {indiaDateTime}");

            //Date Only
            var dateOnly = new DateOnly(2024, 09, 10);
            Console.WriteLine($"The day after tomorrow: {dateOnly.AddDays(2)}");
            Console.WriteLine($"One year ago: {dateOnly.AddYears(-1)}");

            var dateOnly2 = DateOnly.FromDateTime(now);
            Console.WriteLine($"Date only from datetime: {dateOnly2}");

            // var exactDateOnly = DateOnly.ParseExact('02/03/1995', 'dd MM yyyy', CultureInfo.InvariantCulture); error

            // TimeOnly
            var timeNow = TimeOnly.FromDateTime(now);
            Console.WriteLine($"Time Only from date time: {timeNow}");
        }
    }
}
