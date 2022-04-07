using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaMeetings
{
  public class ResponsiblePerson
  {

    private Meeting _meeting;
    public string Name { get; set; }
    public bool IsResponsiblePerson { get; set; }

    public void CreateMeeting(Meeting meeting)
    {
      _meeting = meeting;
    }
    public void RemoveFromMeeting(ResponsiblePerson person)
    {
      if (!person.IsResponsiblePerson)
      {
        _meeting.RemoveFromMeeting(person);
      }
    }
  }
}
