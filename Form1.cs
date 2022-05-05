using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Osoba osoba = new Osoba("Ivan", "Ivanovic", 156, 49);
        private void button1_Click(object sender, EventArgs e)
        {
            osoba.BMI();
            MessageBox.Show(osoba.ToString());
        }
        Pacient pacient = new Pacient("Ivan", "Ivanovic", 194, 88, 0.82);
        private void button2_Click(object sender, EventArgs e)
        {
            pacient.BMI();
            pacient.ABSI();
            MessageBox.Show(pacient.ToString());
        }
    }
}
