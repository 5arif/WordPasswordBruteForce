namespace WordPasswordBruteForce
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label11 = new System.Windows.Forms.Label();
            this.FileNameTxt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.EsecuzioneTLP = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StartTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeNeededTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ExtimedTimeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxTasksTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PwMinLenTxt = new System.Windows.Forms.TextBox();
            this.PwMaxLenTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SpecialChk = new System.Windows.Forms.CheckBox();
            this.UppercaseChk = new System.Windows.Forms.CheckBox();
            this.NumbersChk = new System.Windows.Forms.CheckBox();
            this.LowercaseChk = new System.Windows.Forms.CheckBox();
            this.BtnFind = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "File";
            // 
            // FileNameTxt
            // 
            this.FileNameTxt.Location = new System.Drawing.Point(14, 24);
            this.FileNameTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FileNameTxt.Name = "FileNameTxt";
            this.FileNameTxt.Size = new System.Drawing.Size(490, 23);
            this.FileNameTxt.TabIndex = 26;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox5.Controls.Add(this.EsecuzioneTLP);
            this.groupBox5.Location = new System.Drawing.Point(14, 228);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(595, 92);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Running threads";
            // 
            // EsecuzioneTLP
            // 
            this.EsecuzioneTLP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EsecuzioneTLP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EsecuzioneTLP.ColumnCount = 1;
            this.EsecuzioneTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EsecuzioneTLP.Location = new System.Drawing.Point(7, 23);
            this.EsecuzioneTLP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EsecuzioneTLP.Name = "EsecuzioneTLP";
            this.EsecuzioneTLP.RowCount = 2;
            this.EsecuzioneTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.EsecuzioneTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.EsecuzioneTLP.Size = new System.Drawing.Size(581, 62);
            this.EsecuzioneTLP.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.EndTxt);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.StartTxt);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TimeNeededTxt);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.PasswordTxt);
            this.groupBox4.Location = new System.Drawing.Point(14, 331);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(595, 74);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "End of job";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "End Time";
            // 
            // EndTxt
            // 
            this.EndTxt.BackColor = System.Drawing.SystemColors.Info;
            this.EndTxt.Location = new System.Drawing.Point(304, 37);
            this.EndTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EndTxt.Name = "EndTxt";
            this.EndTxt.ReadOnly = true;
            this.EndTxt.Size = new System.Drawing.Size(134, 23);
            this.EndTxt.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Start time";
            // 
            // StartTxt
            // 
            this.StartTxt.BackColor = System.Drawing.SystemColors.Info;
            this.StartTxt.Location = new System.Drawing.Point(163, 37);
            this.StartTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StartTxt.Name = "StartTxt";
            this.StartTxt.ReadOnly = true;
            this.StartTxt.Size = new System.Drawing.Size(134, 23);
            this.StartTxt.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Time elapsed";
            // 
            // TimeNeededTxt
            // 
            this.TimeNeededTxt.BackColor = System.Drawing.SystemColors.Info;
            this.TimeNeededTxt.Location = new System.Drawing.Point(446, 37);
            this.TimeNeededTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TimeNeededTxt.Name = "TimeNeededTxt";
            this.TimeNeededTxt.ReadOnly = true;
            this.TimeNeededTxt.Size = new System.Drawing.Size(142, 23);
            this.TimeNeededTxt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.SystemColors.Info;
            this.PasswordTxt.Location = new System.Drawing.Point(10, 37);
            this.PasswordTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.ReadOnly = true;
            this.PasswordTxt.Size = new System.Drawing.Size(145, 23);
            this.PasswordTxt.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ExtimedTimeTxt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.MaxTasksTxt);
            this.groupBox3.Location = new System.Drawing.Point(417, 63);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(192, 161);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elaboration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "(on a Intel i5, 2 GHz)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Estimate time to accomplish";
            // 
            // ExtimedTimeTxt
            // 
            this.ExtimedTimeTxt.BackColor = System.Drawing.SystemColors.Info;
            this.ExtimedTimeTxt.Location = new System.Drawing.Point(7, 85);
            this.ExtimedTimeTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExtimedTimeTxt.Name = "ExtimedTimeTxt";
            this.ExtimedTimeTxt.ReadOnly = true;
            this.ExtimedTimeTxt.Size = new System.Drawing.Size(178, 23);
            this.ExtimedTimeTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Core to use";
            // 
            // MaxTasksTxt
            // 
            this.MaxTasksTxt.Location = new System.Drawing.Point(7, 40);
            this.MaxTasksTxt.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.MaxTasksTxt.Name = "MaxTasksTxt";
            this.MaxTasksTxt.Size = new System.Drawing.Size(67, 23);
            this.MaxTasksTxt.TabIndex = 6;
            this.MaxTasksTxt.Text = "4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(14, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(394, 161);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.PwMinLenTxt);
            this.groupBox6.Controls.Add(this.PwMaxLenTxt);
            this.groupBox6.Location = new System.Drawing.Point(211, 24);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(167, 126);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "length";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Max";
            // 
            // PwMinLenTxt
            // 
            this.PwMinLenTxt.Location = new System.Drawing.Point(10, 37);
            this.PwMinLenTxt.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.PwMinLenTxt.Name = "PwMinLenTxt";
            this.PwMinLenTxt.Size = new System.Drawing.Size(60, 23);
            this.PwMinLenTxt.TabIndex = 4;
            this.PwMinLenTxt.Text = "3";
            this.PwMinLenTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PwMaxLenTxt
            // 
            this.PwMaxLenTxt.Location = new System.Drawing.Point(78, 37);
            this.PwMaxLenTxt.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.PwMaxLenTxt.Name = "PwMaxLenTxt";
            this.PwMaxLenTxt.Size = new System.Drawing.Size(60, 23);
            this.PwMaxLenTxt.TabIndex = 4;
            this.PwMaxLenTxt.Text = "9";
            this.PwMaxLenTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SpecialChk);
            this.groupBox1.Controls.Add(this.UppercaseChk);
            this.groupBox1.Controls.Add(this.NumbersChk);
            this.groupBox1.Controls.Add(this.LowercaseChk);
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(167, 128);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Char set";
            // 
            // SpecialChk
            // 
            this.SpecialChk.AutoSize = true;
            this.SpecialChk.Location = new System.Drawing.Point(8, 100);
            this.SpecialChk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SpecialChk.Name = "SpecialChk";
            this.SpecialChk.Size = new System.Drawing.Size(117, 19);
            this.SpecialChk.TabIndex = 10;
            this.SpecialChk.Text = "special char (@#)";
            this.SpecialChk.UseVisualStyleBackColor = true;
            // 
            // UppercaseChk
            // 
            this.UppercaseChk.AutoSize = true;
            this.UppercaseChk.Location = new System.Drawing.Point(8, 22);
            this.UppercaseChk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UppercaseChk.Name = "UppercaseChk";
            this.UppercaseChk.Size = new System.Drawing.Size(106, 19);
            this.UppercaseChk.TabIndex = 9;
            this.UppercaseChk.Text = "uppercase (AZ)";
            this.UppercaseChk.UseVisualStyleBackColor = true;
            // 
            // NumbersChk
            // 
            this.NumbersChk.AutoSize = true;
            this.NumbersChk.Checked = true;
            this.NumbersChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NumbersChk.Location = new System.Drawing.Point(8, 74);
            this.NumbersChk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumbersChk.Name = "NumbersChk";
            this.NumbersChk.Size = new System.Drawing.Size(96, 19);
            this.NumbersChk.TabIndex = 9;
            this.NumbersChk.Text = "numbers (09)";
            this.NumbersChk.UseVisualStyleBackColor = true;
            // 
            // LowercaseChk
            // 
            this.LowercaseChk.AutoSize = true;
            this.LowercaseChk.Location = new System.Drawing.Point(8, 48);
            this.LowercaseChk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LowercaseChk.Name = "LowercaseChk";
            this.LowercaseChk.Size = new System.Drawing.Size(100, 19);
            this.LowercaseChk.TabIndex = 9;
            this.LowercaseChk.Text = "lowercase (az)";
            this.LowercaseChk.UseVisualStyleBackColor = true;
            // 
            // BtnFind
            // 
            this.BtnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFind.BackColor = System.Drawing.Color.Honeydew;
            this.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFind.Location = new System.Drawing.Point(469, 428);
            this.BtnFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(144, 31);
            this.BtnFind.TabIndex = 20;
            this.BtnFind.Text = "Find password";
            this.BtnFind.UseVisualStyleBackColor = false;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(513, 24);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(88, 27);
            this.btnBrowse.TabIndex = 28;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 471);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FileNameTxt);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Password Brute Force";
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox FileNameTxt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel EsecuzioneTLP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EndTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StartTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TimeNeededTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ExtimedTimeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxTasksTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PwMinLenTxt;
        private System.Windows.Forms.TextBox PwMaxLenTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox UppercaseChk;
        private System.Windows.Forms.CheckBox NumbersChk;
        private System.Windows.Forms.CheckBox LowercaseChk;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private CheckBox SpecialChk;
    }
}

