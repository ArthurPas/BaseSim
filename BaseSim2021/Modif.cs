using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseSim2021
{
    public partial class Modif : Form
    {
        public Modif(string name, int value, int max, int min)
        {
            
            InitializeComponent();
            this.labelName.Text = name;
            this.NumericUpDown.Maximum = max;
            this.NumericUpDown.Minimum = min;
            this.NumericUpDown.Value = value;
            
        }
    }
}
