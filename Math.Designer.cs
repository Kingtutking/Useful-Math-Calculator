namespace Useful_Math_Equations
{
    partial class Math
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
            this.algebra1 = new System.Windows.Forms.Button();
            this.geometry = new System.Windows.Forms.Button();
            this.linear_algebra = new System.Windows.Forms.Button();
            this.diff_equations = new System.Windows.Forms.Button();
            this.algebra2 = new System.Windows.Forms.Button();
            this.pre_Calculus = new System.Windows.Forms.Button();
            this.calculus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // algebra1
            // 
            this.algebra1.Font = new System.Drawing.Font("Lemon", 24F, System.Drawing.FontStyle.Bold);
            this.algebra1.Location = new System.Drawing.Point(12, 1);
            this.algebra1.Name = "algebra1";
            this.algebra1.Size = new System.Drawing.Size(309, 67);
            this.algebra1.TabIndex = 2;
            this.algebra1.Text = "Algebra 1";
            this.algebra1.UseVisualStyleBackColor = true;
            this.algebra1.Click += new System.EventHandler(this.algebra_Click);
            // 
            // geometry
            // 
            this.geometry.Font = new System.Drawing.Font("Lemon", 24F, System.Drawing.FontStyle.Bold);
            this.geometry.Location = new System.Drawing.Point(12, 64);
            this.geometry.Name = "geometry";
            this.geometry.Size = new System.Drawing.Size(309, 67);
            this.geometry.TabIndex = 3;
            this.geometry.Text = "Geometry";
            this.geometry.UseVisualStyleBackColor = true;
            this.geometry.Click += new System.EventHandler(this.geometry_Click);
            // 
            // linear_algebra
            // 
            this.linear_algebra.Font = new System.Drawing.Font("Lemon", 24F, System.Drawing.FontStyle.Bold);
            this.linear_algebra.Location = new System.Drawing.Point(12, 319);
            this.linear_algebra.Name = "linear_algebra";
            this.linear_algebra.Size = new System.Drawing.Size(309, 67);
            this.linear_algebra.TabIndex = 4;
            this.linear_algebra.Text = "Linear Algebra";
            this.linear_algebra.UseVisualStyleBackColor = true;
            this.linear_algebra.Click += new System.EventHandler(this.linear_Algebra_Click);
            // 
            // diff_equations
            // 
            this.diff_equations.Font = new System.Drawing.Font("Lemon", 24F, System.Drawing.FontStyle.Bold);
            this.diff_equations.Location = new System.Drawing.Point(12, 382);
            this.diff_equations.Name = "diff_equations";
            this.diff_equations.Size = new System.Drawing.Size(309, 67);
            this.diff_equations.TabIndex = 5;
            this.diff_equations.Text = "Diff Equations";
            this.diff_equations.UseVisualStyleBackColor = true;
            this.diff_equations.Click += new System.EventHandler(this.diff_Equations_Click);
            // 
            // algebra2
            // 
            this.algebra2.Font = new System.Drawing.Font("Lemon", 24F, System.Drawing.FontStyle.Bold);
            this.algebra2.Location = new System.Drawing.Point(12, 128);
            this.algebra2.Name = "algebra2";
            this.algebra2.Size = new System.Drawing.Size(309, 67);
            this.algebra2.TabIndex = 6;
            this.algebra2.Text = "Algebra 2";
            this.algebra2.UseVisualStyleBackColor = true;
            this.algebra2.Click += new System.EventHandler(this.algebra2_Click);
            // 
            // pre_Calculus
            // 
            this.pre_Calculus.Font = new System.Drawing.Font("Lemon", 24F, System.Drawing.FontStyle.Bold);
            this.pre_Calculus.Location = new System.Drawing.Point(12, 192);
            this.pre_Calculus.Name = "pre_Calculus";
            this.pre_Calculus.Size = new System.Drawing.Size(309, 67);
            this.pre_Calculus.TabIndex = 7;
            this.pre_Calculus.Text = "Pre-Calculus";
            this.pre_Calculus.UseVisualStyleBackColor = true;
            this.pre_Calculus.Click += new System.EventHandler(this.pre_Calculus_Click);
            // 
            // calculus
            // 
            this.calculus.Font = new System.Drawing.Font("Lemon", 24F, System.Drawing.FontStyle.Bold);
            this.calculus.Location = new System.Drawing.Point(12, 256);
            this.calculus.Name = "calculus";
            this.calculus.Size = new System.Drawing.Size(309, 67);
            this.calculus.TabIndex = 8;
            this.calculus.Text = "Calculus";
            this.calculus.UseVisualStyleBackColor = true;
            this.calculus.Click += new System.EventHandler(this.calculus_Click);
            // 
            // Math
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculus);
            this.Controls.Add(this.pre_Calculus);
            this.Controls.Add(this.algebra2);
            this.Controls.Add(this.diff_equations);
            this.Controls.Add(this.linear_algebra);
            this.Controls.Add(this.geometry);
            this.Controls.Add(this.algebra1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Math";
            this.Text = "Math";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button algebra1;
        private System.Windows.Forms.Button geometry;
        private System.Windows.Forms.Button linear_algebra;
        private System.Windows.Forms.Button diff_equations;
        private System.Windows.Forms.Button algebra2;
        private System.Windows.Forms.Button pre_Calculus;
        private System.Windows.Forms.Button calculus;
    }
}