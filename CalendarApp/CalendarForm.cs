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
