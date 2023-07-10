using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomata_Proje
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button_seeTheFee_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(); 
            
            double saat = 0;
            saat = Convert.ToDouble(textBox_hours.Text);

            frm4.label_stayedHours.Text = "You stayed " + textBox_hours.Text + " hours";
            frm4.label_stayedHours2.Text = Convert.ToString(saat + saat) + " $";

            if (radioButton_yes.Checked)
            {
                frm4.label_chargingHours.Text = "Charged for " + textBox_hours.Text + " hours";
                frm4.label_chargingHours2.Text = textBox_hours.Text + " $";
                frm4.label_total.Text = "Total: " + Convert.ToString(saat + saat + saat) + " $";
            }
            else
            {
                frm4.label_total.Text = "Total: " + Convert.ToString(saat + saat) + " $";
            }

            frm4.Show();
        }

        private void textBox_hours_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
