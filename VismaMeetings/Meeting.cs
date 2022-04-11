namespace VismaMeetings
{
  public class Meeting
  {
    public string Name { get; set; }

    public Meeting CurrentMeeting { get; private set; }
    public ResponsiblePerson ResponsiblePerson { get; set; }
    public string Description { get; set; }

    public List<string> Category = new()
    {
      "CodeMonkey",
      "Hub",
      "Short",
      "TeamBuilding"
    };

    public List<string> Type = new()
    {
      "Live",
      "InPerson"
    };
    public DateOnly StartDate;
    public DateOnly EndDate;

    private List<ResponsiblePerson> _persons = new();

    public void AddToMeeting(ResponsiblePerson person)
    {


      if (!_persons.Contains(person))
      {
        _persons.Add(person);

      }
      else
      {
        Console.WriteLine($"{person.Name} already in meeting!");
      }

    }

    public void RemoveFromMeeting(ResponsiblePerson responsiblePerson)
    {
      if (_persons != null)
        _persons.Remove(responsiblePerson);
    }

    public string MeetingInfo()
    {
      return Name + " " + Description + " " + ResponsiblePerson.Name;
    }


  }
}