// See https://aka.ms/new-console-template for more information

List<string> days = new List<string> { "Monday", "Tuesday", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY" };
List<string> answers = new List<string> { "You just started the week, it cant be that bad, 5 days to go", "You're doing well, 4 days to go", "Halfway through,3 days to go", "Almost done, 2 days to go", "Just 1 day to go", "Its the weekend, time to hit immo", "rest up today, it'll be a busy week" };

Console.Write("What day is it?");
string day = Console.ReadLine().ToUpper().Trim();

if (days.Contains(day))
{
    int index = days.IndexOf(day); // Get the index of the matching day
    Console.WriteLine(answers[index]);
} 
else
{
    Console.WriteLine("Thats not a day");
}
