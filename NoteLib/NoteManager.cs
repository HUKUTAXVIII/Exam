using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLib
{
    public class NoteManager
    {
        public List<Note> Notes;

        public NoteManager()
        {
            Notes = new List<Note>();
        }

        public bool LoadNotes(string Path) {
            bool isCorrect = false;

            Directory.GetDirectories(Path + "/Notes/").ToList().ForEach((date)=> {
                Directory.GetFiles(date).ToList().ForEach((file)=> {
                    Notes.Add(new Note());
                    Notes.Last().Name = new FileInfo(file).Name.Substring(0, new FileInfo(file).Name.Length-4);
                    Notes.Last().Content = File.ReadAllText(file);
                    Notes.Last().CalendarPosition = Convert.ToDateTime(new DirectoryInfo(date).Name);
                });
            });

            return isCorrect;
        }
        public bool SaveNotes(string Path)
        {
            bool isCorrect = false;

            Directory.CreateDirectory("Notes");
            this.Notes.ForEach((note)=> {
                Directory.CreateDirectory(note.CalendarPosition.ToShortDateString());
                File.Create(Path+"/Notes/" + note.CalendarPosition.ToShortDateString()+"/"+note.Name).Close();
                File.WriteAllText(Path + "/Notes/" + note.CalendarPosition.ToShortDateString() + "/" + note.Name,note.Content);
            });

            return isCorrect;
        }

    }
}
