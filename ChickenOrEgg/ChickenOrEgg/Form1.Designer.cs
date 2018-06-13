namespace ChickenOrEgg
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.picAnswer = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radEgg = new System.Windows.Forms.RadioButton();
            this.radChicken = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AllowDrop = true;
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblQuestion.Location = new System.Drawing.Point(58, 49);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(159, 25);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "What was first?";
            // 
            // picAnswer
            // 
            this.picAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAnswer.Location = new System.Drawing.Point(216, 93);
            this.picAnswer.Name = "picAnswer";
            this.picAnswer.Size = new System.Drawing.Size(244, 185);
            this.picAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnswer.TabIndex = 1;
            this.picAnswer.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radChicken);
            this.groupBox1.Controls.Add(this.radEgg);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick Your Answer";
            // 
            // radEgg
            // 
            this.radEgg.AutoSize = true;
            this.radEgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEgg.Location = new System.Drawing.Point(6, 54);
            this.radEgg.Name = "radEgg";
            this.radEgg.Size = new System.Drawing.Size(65, 24);
            this.radEgg.TabIndex = 0;
            this.radEgg.TabStop = true;
            this.radEgg.Text = "Egg?";
            this.radEgg.UseVisualStyleBackColor = true;
            this.radEgg.CheckedChanged += new System.EventHandler(this.radEgg_CheckedChanged);
            // 
            // radChicken
            // 
            this.radChicken.AutoSize = true;
            this.radChicken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChicken.Location = new System.Drawing.Point(6, 99);
            this.radChicken.Name = "radChicken";
            this.radChicken.Size = new System.Drawing.Size(93, 24);
            this.radChicken.TabIndex = 1;
            this.radChicken.TabStop = true;
            this.radChicken.Text = "Chicken?";
            this.radChicken.UseVisualStyleBackColor = true;
            this.radChicken.CheckedChanged += new System.EventHandler(this.radChicken_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form1";
            this.Text = "Chicken or Egg";
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox picAnswer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radChicken;
        private System.Windows.Forms.RadioButton radEgg;
    }
}

