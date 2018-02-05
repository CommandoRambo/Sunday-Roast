namespace SundayRoast.Controls
{
    partial class Clock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberScroll1 = new SundayRoast.Controls.NumberScroll();
            this.numberScroll2 = new SundayRoast.Controls.NumberScroll();
            this.numberScroll3 = new SundayRoast.Controls.NumberScroll();
            this.numberScroll4 = new SundayRoast.Controls.NumberScroll();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberScroll1
            // 
            this.numberScroll1.Location = new System.Drawing.Point(0, 16);
            this.numberScroll1.Name = "numberScroll1";
            this.numberScroll1.Size = new System.Drawing.Size(32, 60);
            this.numberScroll1.TabIndex = 0;
            // 
            // numberScroll2
            // 
            this.numberScroll2.Location = new System.Drawing.Point(32, 16);
            this.numberScroll2.Name = "numberScroll2";
            this.numberScroll2.Size = new System.Drawing.Size(32, 60);
            this.numberScroll2.TabIndex = 1;
            // 
            // numberScroll3
            // 
            this.numberScroll3.Location = new System.Drawing.Point(72, 16);
            this.numberScroll3.Name = "numberScroll3";
            this.numberScroll3.Size = new System.Drawing.Size(32, 60);
            this.numberScroll3.TabIndex = 2;
            // 
            // numberScroll4
            // 
            this.numberScroll4.Location = new System.Drawing.Point(104, 16);
            this.numberScroll4.Name = "numberScroll4";
            this.numberScroll4.Size = new System.Drawing.Size(32, 60);
            this.numberScroll4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "H";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "M";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = ":";
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberScroll4);
            this.Controls.Add(this.numberScroll3);
            this.Controls.Add(this.numberScroll2);
            this.Controls.Add(this.numberScroll1);
            this.Controls.Add(this.label5);
            this.Name = "Clock";
            this.Size = new System.Drawing.Size(136, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumberScroll numberScroll1;
        private NumberScroll numberScroll2;
        private NumberScroll numberScroll3;
        private NumberScroll numberScroll4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
