namespace CalendarApp
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.FolderButton = new System.Windows.Forms.Button();
            this.BGColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LangBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FolderButton
            // 
            resources.ApplyResources(this.FolderButton, "FolderButton");
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // BGColor
            // 
            resources.ApplyResources(this.BGColor, "BGColor");
            this.BGColor.Name = "BGColor";
            this.BGColor.UseVisualStyleBackColor = true;
            this.BGColor.Click += new System.EventHandler(this.BGColor_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // LangBox
            // 
            this.LangBox.FormattingEnabled = true;
            this.LangBox.Items.AddRange(new object[] {
            resources.GetString("LangBox.Items"),
            resources.GetString("LangBox.Items1"),
            resources.GetString("LangBox.Items2")});
            resources.ApplyResources(this.LangBox, "LangBox");
            this.LangBox.Name = "LangBox";
            this.LangBox.SelectedIndexChanged += new System.EventHandler(this.LangBox_SelectedIndexChanged);
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LangBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BGColor);
            this.Controls.Add(this.FolderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.Button BGColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LangBox;
    }
}