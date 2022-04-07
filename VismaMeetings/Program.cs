// See https://aka.ms/new-console-template for more information
using VismaMeetings;


Meeting meeting = new()
{
  Name = "C# conference",
  Description = "",

};

meeting.AddToMeeting(new ResponsiblePerson() { 

  Name ="Petras Petraitis"

});


Console.WriteLine("Hello, World!");



