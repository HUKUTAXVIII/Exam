using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarAppForm));
        private string language = string.Empty;
        private CultureInfo ci;


        public NoteManager noteManager;

        public CalendarAppForm()
        {

            if (!File.Exists("FilePath.txt")) {
                File.Create("FilePath.txt").Close();
                File.WriteAllText("FilePath.txt", "Note/");
            }
            if (!Directory.Exists("Note")) {
                Directory.CreateDirectory("Note");
            }
            

            if (File.Exists("Color.txt")) {
                var color = File.ReadAllText("Color.txt").Split(' ').ToArray();
                this.BackColor = Color.FromArgb(255,int.Parse(color[0]),int.Parse(color[1]),int.Parse(color[2]));
            }
            if (File.Exists("language.txt"))
            {
                ci = new CultureInfo(File.ReadAllText("language.txt"));
            }
            else {
                File.Create("language.txt").Close();
                File.WriteAllText("language.txt","ru");
                ci = new CultureInfo(File.ReadAllText("language.txt"));
            }

            noteManager = new NoteManager();
            noteManager.LoadNotes(File.ReadAllText("FilePath.txt"));
            InitializeComponent();
            UpdateGUINotes();
            ChangeLanguage();
        }
        private void ChangeLanguage()
        {
            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, ci);
            }
            resources.ApplyResources(this, "$this",ci);
        }
        private void UpdateGUINotes() {
            if (this.noteManager.Notes.Count != 0) {
                this.NotePanel.Controls.Clear();
                this.noteManager.Notes.ToList()
                    .Where((file)=>file.CalendarPosition.ToShortDateString() == this.Calendar.SelectionEnd.Date.ToShortDateString()).ToList()
                    .ForEach((item)=> {
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
            using (NoteForm note = new NoteForm(this.Calendar.SelectionEnd,true)) {
                note.ShowDialog();
            }
                noteManager.Notes.Clear();
            this.NotePanel.Controls.Clear();
                noteManager.LoadNotes(File.ReadAllText("FilePath.txt"));
                this.UpdateGUINotes();
                ci = new CultureInfo(File.ReadAllText("language.txt"));
                ChangeLanguage();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            using (SettingsForm settings = new SettingsForm()) {
                settings.ShowDialog();
                if (File.Exists("Color.txt"))
                {
                    var color = File.ReadAllText("Color.txt").Split(' ').ToArray();
                    this.BackColor = Color.FromArgb(255, int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]));
                }
                ci = new CultureInfo(File.ReadAllText("language.txt"));
                ChangeLanguage();

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.NotePanel.Controls.Clear();
            noteManager.Notes.Where(item => item.Name.Contains(this.SearchBox.Text)).ToList().ForEach((item)=> {

                Button button = new Button();

                button.Size = new Size(this.NotePanel.Size.Width - 2, 50);
                button.Name = item.Name;
                if (this.NotePanel.Controls.Count != 0)
                {
                    button.Location = new Point(this.NotePanel.Controls.OfType<Button>().ToList().Last().Location.X, this.NotePanel.Controls.OfType<Button>().ToList().Last().Location.Y + 50);

                }

                button.FlatStyle = FlatStyle.Flat;
                button.Text = $"{item.Name}\n\n{item.CalendarPosition.ToShortDateString()}";
                button.Click += Button_Click;

                this.NotePanel.Controls.Add(button);

            });
                
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show(e.End.ToShortDateString());
            this.UpdateGUINotes();
        }
    }
}
