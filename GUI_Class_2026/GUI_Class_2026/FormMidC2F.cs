using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Class_2026
{
    public partial class FormMidC2F : Form
    {
        public FormMidC2F()
        {
            InitializeComponent();
        }

        private void btnCauC2F_Click(object sender, EventArgs e)
        {
            String cString=tbC.Text;
            double cD=double.Parse(cString);
            double fD = cD*(9/5.0)+32;
            labResult.Text=fD.ToString()+"F";
        }
    }
}
