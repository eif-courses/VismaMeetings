// See https://aka.ms/new-console-template for more information
using VismaMeetings;

var meetings = new List<Meeting>();

Meeting meeting = new()
{
  Name = "C# conference",
  Description = "Most popular",
  ResponsiblePerson = new()
  {
    Name = "Petras Petraitis"
  }
};
Meeting meeting2 = new()
{
  Name = "Java conference",
  Description = "Best ever",
  ResponsiblePerson = new()
  {
    Name = "Ona Onaitiene"
  }
};

meetings.Add(meeting);
meetings.Add(meeting2);

for (int i = 0; i < meetings.Count; i++)
{
  Console.WriteLine($"{i+1}. {meetings[i].Name}, {meetings[i].ResponsiblePerson.Name}");
}
/*Console.WriteLine("===============================");
Console.WriteLine("=======Filter by ==========");
Console.WriteLine("===============================");
Console.WriteLine("1. Description.");
Console.WriteLine("2. Responsible person.");
Console.WriteLine("3. Category.");*/

Console.Write("Filter value: ");
string filter = Console.ReadLine();
var filterResult = meetings.Where(x => x.Description.ToLower() == filter.ToLower());
  
foreach(var ii in filterResult) { 
  Console.WriteLine($"{ ii.MeetingInfo()}");
}














int result = 1;

while (result != 0)
{
 
  Console.WriteLine("===============================");
  Console.WriteLine("=======VISMA Meetings==========");
  Console.WriteLine("===============================");

  Console.WriteLine("1. Create meeting.");
  Console.WriteLine("2. Delete meeting.");
  Console.WriteLine("3. Add Person to meeting.");
  Console.WriteLine("4. Remove Person from meeting.");
  Console.WriteLine("5. Display all meetings.");
  Console.WriteLine("0. Close and Exit.");

  string option = Console.ReadLine();
  int.TryParse(option, out result);






  switch (result)
  {
    case 1:
      Console.WriteLine("1. Create meeting.");
      break;
      case 2:
      Console.WriteLine("2. Delete meeting.");
      break;
    case 3:
      break;
    case 4:
      break;
      case 5:

      break;
    case 0:
      break;
    default:
    
      Console.WriteLine("Wrong input no option selected!");
      break;
  }
}

Console.WriteLine("Goodbye my friend :)");



