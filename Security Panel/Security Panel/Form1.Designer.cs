namespace Security_Panel
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRezo = new System.Windows.Forms.Button();
            this.lbAcceslog = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security code :";
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.Location = new System.Drawing.Point(175, 30);
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.PasswordChar = '*';
            this.txtSecurityCode.ReadOnly = true;
            this.txtSecurityCode.Size = new System.Drawing.Size(220, 20);
            this.txtSecurityCode.TabIndex = 1;
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(175, 76);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(40, 36);
            this.btnOne.TabIndex = 2;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnRezo_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(175, 118);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(40, 36);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnRezo_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(175, 160);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(40, 36);
            this.btnSeven.TabIndex = 4;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnRezo_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(235, 76);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(40, 36);
            this.btnTwo.TabIndex = 5;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnRezo_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(235, 118);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(40, 36);
            this.btnFive.TabIndex = 6;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnRezo_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(235, 160);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(40, 36);
            this.btnEight.TabIndex = 7;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnRezo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(293, 76);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(40, 36);
            this.btnThree.TabIndex = 8;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnRezo_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(293, 118);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(40, 36);
            this.btnSix.TabIndex = 9;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnRezo_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(293, 160);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(40, 36);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnRezo_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRemove.ForeColor = System.Drawing.Color.Lime;
            this.btnRemove.Location = new System.Drawing.Point(355, 76);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(40, 36);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "C";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEnter.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnEnter.Location = new System.Drawing.Point(355, 118);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(40, 36);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "#";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnRezo
            // 
            this.btnRezo.Location = new System.Drawing.Point(355, 160);
            this.btnRezo.Name = "btnRezo";
            this.btnRezo.Size = new System.Drawing.Size(40, 36);
            this.btnRezo.TabIndex = 13;
            this.btnRezo.Text = "0";
            this.btnRezo.UseVisualStyleBackColor = true;
            this.btnRezo.Click += new System.EventHandler(this.btnRezo_Click);
            // 
            // lbAcceslog
            // 
            this.lbAcceslog.FormattingEnabled = true;
            this.lbAcceslog.Location = new System.Drawing.Point(175, 203);
            this.lbAcceslog.Name = "lbAcceslog";
            this.lbAcceslog.Size = new System.Drawing.Size(220, 121);
            this.lbAcceslog.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Access Log :";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(355, 331);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAcceslog);
            this.Controls.Add(this.btnRezo);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.txtSecurityCode);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecurityCode;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnRezo;
        private System.Windows.Forms.ListBox lbAcceslog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
    }
}

