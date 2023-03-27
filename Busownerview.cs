using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiet_Parking_sys
{
    public partial class Busownerview : Form
    {
        public Busownerview()
        {
            InitializeComponent();
        }

        private void Busownerview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kPMSDataSet1.Businfo' table. You can move, or remove it, as needed.
            this.businfoTableAdapter.Fill(this.kPMSDataSet1.Businfo);

        }

        private void Home_button_Click(object sender, EventArgs e)
        {

            Home obj = new Home();
            Hide();
            obj.Tag = this;
            obj.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Records obj = new Records();
            Hide();
            obj.Tag = this;
            obj.Show(this);
        }

        private void About_buuton_Click(object sender, EventArgs e)
        {
            About obj = new About();
            Hide();
            obj.Tag = this;
            obj.Show(this);

        }

        private void Developer_button_Click(object sender, EventArgs e)
        {
            Developer obj = new Developer();
            Hide();
            obj.Tag = this;
            obj.Show(this);
        }

        private void Help_button_Click(object sender, EventArgs e)
        {
            Contact_Us obj = new Contact_Us();
            Hide();
            obj.Tag = this;
            obj.Show(this);
        }
    }
}
