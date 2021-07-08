namespace CalendarApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.NotePanel = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(82, 55);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            // 
            // NotePanel
            // 
            this.NotePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotePanel.Location = new System.Drawing.Point(350, 22);
            this.NotePanel.Name = "NotePanel";
            this.NotePanel.Size = new System.Drawing.Size(200, 270);
            this.NotePanel.TabIndex = 1;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(12, 305);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(252, 20);
            this.SearchBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(270, 305);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(74, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "🔍";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(350, 305);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(74, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(430, 305);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(74, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "-";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(528, 305);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(22, 23);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.Text = "⚙";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 337);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.NotePanel);
            this.Controls.Add(this.Calendar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Panel NotePanel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SettingsButton;
    }
}

