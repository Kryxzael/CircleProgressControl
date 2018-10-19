namespace TestWrapper
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
            this.circleProgressControl1 = new CircleControl.CircleProgressControl();
            this.SuspendLayout();
            // 
            // circleProgressControl1
            // 
            this.circleProgressControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.circleProgressControl1.Boldness = 25F;
            this.circleProgressControl1.CircleTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.circleProgressControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circleProgressControl1.ForeColor = System.Drawing.Color.Yellow;
            this.circleProgressControl1.Location = new System.Drawing.Point(0, 0);
            this.circleProgressControl1.MaxValue = 60F;
            this.circleProgressControl1.Name = "circleProgressControl1";
            this.circleProgressControl1.Size = new System.Drawing.Size(284, 261);
            this.circleProgressControl1.TabIndex = 0;
            this.circleProgressControl1.Value = 0F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.circleProgressControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CircleControl.CircleProgressControl circleProgressControl1;
    }
}

