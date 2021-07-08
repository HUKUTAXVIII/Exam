using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLib
{
    public class Note
    {
        public string Name;
        public string Content;
        public DateTime CalendarPosition;

        public Note()
        {

        }
        public Note(string name,string content,DateTime pos)
        {
            Name = name;
            Content = content;
            CalendarPosition = pos;
        }






    }
}
