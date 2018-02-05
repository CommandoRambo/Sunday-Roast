namespace SundayRoast.Controls
{
    partial class NumberScroll
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
            this.butDown = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.butUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butDown
            // 
            this.butDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDown.Image = global::SundayRoast.Properties.Resources.Down;
            this.butDown.Location = new System.Drawing.Point(0, 40);
            this.butDown.Name = "butDown";
            this.butDown.Size = new System.Drawing.Size(32, 20);
            this.butDown.TabIndex = 1;
            this.butDown.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(0, 20);
            this.txtNumber.MaxLength = 1;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(32, 20);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.Text = "0";
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butUp
            // 
            this.butUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUp.Image = global::SundayRoast.Properties.Resources.Up;
            this.butUp.Location = new System.Drawing.Point(0, 0);
            this.butUp.Name = "butUp";
            this.butUp.Size = new System.Drawing.Size(32, 20);
            this.butUp.TabIndex = 0;
            this.butUp.UseVisualStyleBackColor = true;
            // 
            // NumberScroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.butDown);
            this.Controls.Add(this.butUp);
            this.Name = "NumberScroll";
            this.Size = new System.Drawing.Size(32, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butUp;
        private System.Windows.Forms.Button butDown;
        private System.Windows.Forms.TextBox txtNumber;
    }
}
