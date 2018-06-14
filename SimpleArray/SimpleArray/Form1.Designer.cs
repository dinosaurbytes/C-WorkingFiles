namespace SimpleArray
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotoal = new System.Windows.Forms.Label();
            this.lstMyNumbers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSmallest = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLargest = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblLargest);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSmallest);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTotoal);
            this.groupBox1.Controls.Add(this.lstMyNumbers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(297, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Entry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total";
            // 
            // lblTotoal
            // 
            this.lblTotoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotoal.Location = new System.Drawing.Point(29, 135);
            this.lblTotoal.Name = "lblTotoal";
            this.lblTotoal.Size = new System.Drawing.Size(112, 22);
            this.lblTotoal.TabIndex = 5;
            // 
            // lstMyNumbers
            // 
            this.lstMyNumbers.FormattingEnabled = true;
            this.lstMyNumbers.Location = new System.Drawing.Point(208, 60);
            this.lstMyNumbers.Name = "lstMyNumbers";
            this.lstMyNumbers.Size = new System.Drawing.Size(135, 160);
            this.lstMyNumbers.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "My Numbers";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(29, 55);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter A nNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Smallest";
            // 
            // lblSmallest
            // 
            this.lblSmallest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallest.Location = new System.Drawing.Point(29, 170);
            this.lblSmallest.Name = "lblSmallest";
            this.lblSmallest.Size = new System.Drawing.Size(112, 22);
            this.lblSmallest.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Largest";
            // 
            // lblLargest
            // 
            this.lblLargest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargest.Location = new System.Drawing.Point(29, 205);
            this.lblLargest.Name = "lblLargest";
            this.lblLargest.Size = new System.Drawing.Size(112, 22);
            this.lblLargest.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotoal;
        private System.Windows.Forms.ListBox lstMyNumbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLargest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSmallest;
    }
}

