namespace Conversion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.txtCM = new System.Windows.Forms.TextBox();
            this.btnToMetric = new System.Windows.Forms.Button();
            this.btnToImperial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inches";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "cm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(140, 56);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(89, 20);
            this.txtFeet.TabIndex = 3;
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(140, 108);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(89, 20);
            this.txtInches.TabIndex = 4;
            // 
            // txtCM
            // 
            this.txtCM.Location = new System.Drawing.Point(444, 81);
            this.txtCM.Name = "txtCM";
            this.txtCM.Size = new System.Drawing.Size(89, 20);
            this.txtCM.TabIndex = 5;
            this.txtCM.TextChanged += new System.EventHandler(this.txtCM_TextChanged);
            // 
            // btnToMetric
            // 
            this.btnToMetric.Location = new System.Drawing.Point(319, 54);
            this.btnToMetric.Name = "btnToMetric";
            this.btnToMetric.Size = new System.Drawing.Size(75, 23);
            this.btnToMetric.TabIndex = 6;
            this.btnToMetric.Text = ">";
            this.btnToMetric.UseVisualStyleBackColor = true;
            this.btnToMetric.Click += new System.EventHandler(this.btnToMetric_Click);
            // 
            // btnToImperial
            // 
            this.btnToImperial.Location = new System.Drawing.Point(319, 110);
            this.btnToImperial.Name = "btnToImperial";
            this.btnToImperial.Size = new System.Drawing.Size(75, 23);
            this.btnToImperial.TabIndex = 7;
            this.btnToImperial.Text = "<";
            this.btnToImperial.UseVisualStyleBackColor = true;
            this.btnToImperial.Click += new System.EventHandler(this.btnToImperial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToImperial);
            this.Controls.Add(this.btnToMetric);
            this.Controls.Add(this.txtCM);
            this.Controls.Add(this.txtInches);
            this.Controls.Add(this.txtFeet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.TextBox txtInches;
        private System.Windows.Forms.TextBox txtCM;
        private System.Windows.Forms.Button btnToMetric;
        private System.Windows.Forms.Button btnToImperial;
    }
}

