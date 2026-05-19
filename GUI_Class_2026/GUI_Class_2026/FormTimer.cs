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
    public partial class FormTimer : Form
    {
        public FormTimer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int counter = Int32.Parse(labCounter.Text.Replace("秒",""));
            counter+=1;  //counter = counter+1;
            labCounter.Text=counter.ToString()+"秒";

        }

        private void labCounter_Click(object sender, EventArgs e)
        {
            
        }
    }
}
