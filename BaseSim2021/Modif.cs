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
        public int Value { get { return (int)NumericUpDown.Value; } }
        public string NameOfIndex { get { return labelName.Text; } }

        public Modif(string name, int value, int max, int min, string desc)
        {
            InitializeComponent();
            labelName.Text = name;
            labelDesc.Text = desc;
            NumericUpDown.Maximum = max;
            NumericUpDown.Minimum = min;
            NumericUpDown.Value = value;
            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                
            }
        }
    }
}
