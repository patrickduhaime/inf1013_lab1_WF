namespace inf1013_lab1_WF
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBoxItem = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxTable = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxCommand = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test connexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Execute command";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBoxItem
            // 
            this.checkedListBoxItem.FormattingEnabled = true;
            this.checkedListBoxItem.Items.AddRange(new object[] {
            "ALL"});
            this.checkedListBoxItem.Location = new System.Drawing.Point(138, 12);
            this.checkedListBoxItem.Name = "checkedListBoxItem";
            this.checkedListBoxItem.Size = new System.Drawing.Size(120, 49);
            this.checkedListBoxItem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FROM";
            // 
            // checkedListBoxTable
            // 
            this.checkedListBoxTable.FormattingEnabled = true;
            this.checkedListBoxTable.Items.AddRange(new object[] {
            "tblCategorie",
            "tblQuestion",
            "tblReponse"});
            this.checkedListBoxTable.Location = new System.Drawing.Point(317, 12);
            this.checkedListBoxTable.Name = "checkedListBoxTable";
            this.checkedListBoxTable.Size = new System.Drawing.Size(120, 49);
            this.checkedListBoxTable.TabIndex = 4;
            // 
            // checkedListBoxCommand
            // 
            this.checkedListBoxCommand.FormattingEnabled = true;
            this.checkedListBoxCommand.Items.AddRange(new object[] {
            "SELECT"});
            this.checkedListBoxCommand.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxCommand.Name = "checkedListBoxCommand";
            this.checkedListBoxCommand.Size = new System.Drawing.Size(120, 19);
            this.checkedListBoxCommand.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBoxCommand);
            this.Controls.Add(this.checkedListBoxTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxItem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBoxItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxTable;
        private System.Windows.Forms.CheckedListBox checkedListBoxCommand;
    }
}

