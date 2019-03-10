namespace errors1
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
            this.calcTXT1 = new System.Windows.Forms.TextBox();
            this.calcTXT2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.answrBTN = new System.Windows.Forms.Button();
            this.answrTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcTXT1
            // 
            this.calcTXT1.Location = new System.Drawing.Point(56, 68);
            this.calcTXT1.Name = "calcTXT1";
            this.calcTXT1.Size = new System.Drawing.Size(100, 20);
            this.calcTXT1.TabIndex = 0;
            // 
            // calcTXT2
            // 
            this.calcTXT2.Location = new System.Drawing.Point(211, 67);
            this.calcTXT2.Name = "calcTXT2";
            this.calcTXT2.Size = new System.Drawing.Size(100, 20);
            this.calcTXT2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // answrBTN
            // 
            this.answrBTN.Location = new System.Drawing.Point(129, 122);
            this.answrBTN.Name = "answrBTN";
            this.answrBTN.Size = new System.Drawing.Size(75, 23);
            this.answrBTN.TabIndex = 3;
            this.answrBTN.Text = "Calculate";
            this.answrBTN.UseVisualStyleBackColor = true;
            this.answrBTN.Click += new System.EventHandler(this.answrBTN_Click);
            // 
            // answrTXT
            // 
            this.answrTXT.Location = new System.Drawing.Point(103, 201);
            this.answrTXT.Name = "answrTXT";
            this.answrTXT.Size = new System.Drawing.Size(100, 20);
            this.answrTXT.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 329);
            this.Controls.Add(this.answrTXT);
            this.Controls.Add(this.answrBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcTXT2);
            this.Controls.Add(this.calcTXT1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calcTXT1;
        private System.Windows.Forms.TextBox calcTXT2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button answrBTN;
        private System.Windows.Forms.TextBox answrTXT;
    }
}

