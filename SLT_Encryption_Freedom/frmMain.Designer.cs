namespace SLT_Encryption_Freedom
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdAbout = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDecrypt = new System.Windows.Forms.Button();
            this.TextBoxImportExport = new System.Windows.Forms.TextBox();
            this.cmdCrypt = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Paste the content above and click Decrypt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(317, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Open the banlist_encrypted.txt file and copy its content with ctrl+c";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "If you want to decrypt SLT current list:";
            // 
            // cmdAbout
            // 
            this.cmdAbout.Location = new System.Drawing.Point(12, 306);
            this.cmdAbout.Name = "cmdAbout";
            this.cmdAbout.Size = new System.Drawing.Size(75, 23);
            this.cmdAbout.TabIndex = 27;
            this.cmdAbout.Text = "&About";
            this.cmdAbout.UseVisualStyleBackColor = true;
            this.cmdAbout.Click += new System.EventHandler(this.cmdAbout_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(265, 306);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 31;
            this.cmdSave.Text = "&Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "You can then replace the file of the same name in SLT Tool folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "standard name for the tool is banlist_encrypted.txt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Then click the button below and choose where it will be saved";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "After you added everyone you want to, click encrypt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "1651065165465 # Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "[Steam ID] # [Description]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Input the text in the following format:";
            // 
            // cmdDecrypt
            // 
            this.cmdDecrypt.Location = new System.Drawing.Point(265, 160);
            this.cmdDecrypt.Name = "cmdDecrypt";
            this.cmdDecrypt.Size = new System.Drawing.Size(75, 23);
            this.cmdDecrypt.TabIndex = 19;
            this.cmdDecrypt.Text = "&Decrypt";
            this.cmdDecrypt.UseVisualStyleBackColor = true;
            this.cmdDecrypt.Click += new System.EventHandler(this.cmdDecrypt_Click);
            // 
            // TextBoxImportExport
            // 
            this.TextBoxImportExport.Location = new System.Drawing.Point(12, 12);
            this.TextBoxImportExport.Multiline = true;
            this.TextBoxImportExport.Name = "TextBoxImportExport";
            this.TextBoxImportExport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxImportExport.Size = new System.Drawing.Size(328, 142);
            this.TextBoxImportExport.TabIndex = 18;
            this.TextBoxImportExport.Text = resources.GetString("TextBoxImportExport.Text");
            // 
            // cmdCrypt
            // 
            this.cmdCrypt.Location = new System.Drawing.Point(184, 160);
            this.cmdCrypt.Name = "cmdCrypt";
            this.cmdCrypt.Size = new System.Drawing.Size(75, 23);
            this.cmdCrypt.TabIndex = 17;
            this.cmdCrypt.Text = "&Encrypt";
            this.cmdCrypt.UseVisualStyleBackColor = true;
            this.cmdCrypt.Click += new System.EventHandler(this.cmdCrypt_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 387);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdAbout);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDecrypt);
            this.Controls.Add(this.TextBoxImportExport);
            this.Controls.Add(this.cmdCrypt);
            this.Name = "frmPrincipal";
            this.Text = "SLT Encryption Freedom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdAbout;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDecrypt;
        private System.Windows.Forms.TextBox TextBoxImportExport;
        private System.Windows.Forms.Button cmdCrypt;
        private System.Windows.Forms.SaveFileDialog cmdGrabar;
    }
}

