using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Useful_Math_Equations
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void math_Click(object sender, EventArgs e)
        {
            Math math = new Math();
            math.Show();
        }
    }
}
