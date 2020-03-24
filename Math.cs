using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Useful_Math_Equations.Math_Equations;

namespace Useful_Math_Equations
{
    public partial class Math : Form
    {
        public Math()
        {
            InitializeComponent();
        }
        private void algebra_Click(object sender, EventArgs e)
        {
            Algebra1 page = new Algebra1();
            page.Show();
        }

        private void geometry_Click(object sender, EventArgs e)
        {
            Geometry page = new Geometry();
            page.Show();
        }

        private void linear_Algebra_Click(object sender, EventArgs e)
        {
            LinearAlgebra page = new LinearAlgebra();
            page.Show();
        }

        private void diff_Equations_Click(object sender, EventArgs e)
        {
            DiffEquations page = new DiffEquations();
            page.Show();
        }

        private void algebra2_Click(object sender, EventArgs e)
        {
            Algebra2 page = new Algebra2();
            page.Show();
        }

        private void pre_Calculus_Click(object sender, EventArgs e)
        {
            PreCalculus page = new PreCalculus();
            page.Show();
        }

        private void calculus_Click(object sender, EventArgs e)
        {
            Calculus page = new Calculus();
            page.Show();
        }
    }
}
