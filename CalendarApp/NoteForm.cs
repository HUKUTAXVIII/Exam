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
    public partial class NoteForm : Form
    {
        private bool isEditing;
        public NoteForm()
        {
            isEditing = true;
            InitializeComponent();
        }
        public NoteForm(bool edit)
        {

            isEditing = edit;
            InitializeComponent();
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {

        }

        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isEditing)
            {
                if (!string.IsNullOrEmpty(this.NameBox.Text))
                {
                    NoteManager note = new NoteManager();
                    note.Notes.Add(new Note(this.NameBox.Text,this.ContentBox.Text,DateTime.Now));
                    note.SaveNotes(File.ReadAllText("FilePath.txt"));                    
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Note won't save!");
                }
            }
        }
    }
}
