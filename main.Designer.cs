namespace Useful_Math_Equations
{
    partial class Main
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
            this.MathIcon = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.math = new System.Windows.Forms.Button();
            this.physic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MathIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // MathIcon
            // 
            this.MathIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MathIcon.Image = global::Useful_Math_Equations.Properties.Resources.owl_47526;
            this.MathIcon.Location = new System.Drawing.Point(257, 1);
            this.MathIcon.Name = "MathIcon";
            this.MathIcon.Size = new System.Drawing.Size(277, 130);
            this.MathIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MathIcon.TabIndex = 0;
            this.MathIcon.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(300, 134);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(185, 22);
            this.title.TabIndex = 1;
            this.title.Text = "Useful Equations";
            // 
            // math
            // 
            this.math.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.math.Location = new System.Drawing.Point(64, 269);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(151, 49);
            this.math.TabIndex = 2;
            this.math.Text = "Math";
            this.math.UseVisualStyleBackColor = true;
            this.math.Click += new System.EventHandler(this.math_Click);
            // 
            // physic
            // 
            this.physic.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physic.Location = new System.Drawing.Point(566, 269);
            this.physic.Name = "physic";
            this.physic.Size = new System.Drawing.Size(151, 49);
            this.physic.TabIndex = 3;
            this.physic.Text = "Physics";
            this.physic.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.physic);
            this.Controls.Add(this.math);
            this.Controls.Add(this.title);
            this.Controls.Add(this.MathIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.MathIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MathIcon;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button math;
        private System.Windows.Forms.Button physic;
    }
}

