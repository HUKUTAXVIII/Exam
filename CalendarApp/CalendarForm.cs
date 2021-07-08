using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteLib;

namespace CalendarApp
{
    public partial class CalendarAppForm : Form
    {

        public NoteManager noteManager;

        public CalendarAppForm()
        {

            if (!File.Exists("FilePath.txt")) {
                File.Create("FilePath.txt");
            }
            if (!Directory.Exists("Note")) {
                Directory.CreateDirectory("Note");
            }

            noteManager = new NoteManager();
            noteManager.LoadNotes("Note/");
            InitializeComponent();
            UpdateGUINotes();
        }
        private void UpdateGUINotes() {
            if (this.noteManager.Notes.Count != 0) {
                this.noteManager.Notes.ToList().ForEach((item)=> {
                    Button button = new Button();

                    button.Size = new Size(this.NotePanel.Size.Width-2,50);
                    button.Name = item.Name;
                    if (this.NotePanel.Controls.Count != 0) {
                        button.Location = new Point(this.NotePanel.Controls.OfType<Button>().ToList().Last().Location.X, this.NotePanel.Controls.OfType<Button>().ToList().Last().Location.Y+50);
                        
                    }

                    button.FlatStyle = FlatStyle.Flat;
                    button.Text = $"{item.Name}\n\n{item.CalendarPosition.ToShortDateString()}";
                    button.Click += Button_Click;

                    this.NotePanel.Controls.Add(button);
                });
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var item = sender as Button;
            var note = noteManager.Notes.Where((not) => (item.Name == not.Name)).ToList()[0];
            using (NoteForm form = new NoteForm(note)) {
                form.ShowDialog();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (NoteForm note = new NoteForm()) {
                note.ShowDialog();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            using (SettingsForm settings = new SettingsForm()) {
                settings.ShowDialog();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
