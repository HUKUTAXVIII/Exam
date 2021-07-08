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

namespace CalendarApp
{
    public partial class SettingsForm : Form
    {

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));

        private CultureInfo ci;

        public SettingsForm()
        {
            InitializeComponent();
            if (File.Exists("language.txt"))
            {
                ci = new CultureInfo(File.ReadAllText("language.txt"));
            }
            ChangeLanguage();
        }
        private void ChangeLanguage()
        {
            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, ci);
            }
            resources.ApplyResources(this, "$this", ci);
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog()) {
                if (dialog.ShowDialog() == DialogResult.OK) {
                    File.WriteAllText("FilePath.txt",dialog.SelectedPath);
                }
            }
        }

        private void BGColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog color = new ColorDialog()) {
                if (color.ShowDialog() == DialogResult.OK) {
                    File.WriteAllText("Color.txt",color.Color.R+" "+ color.Color.G+" "+color.Color.B);
                }
            }
        }

        private void LangBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            File.WriteAllText("language.txt", this.LangBox.SelectedItem.ToString());
            ci = new CultureInfo(this.LangBox.SelectedItem.ToString());
            ChangeLanguage();

        }
    }
}
