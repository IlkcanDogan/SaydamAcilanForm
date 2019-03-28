using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaydamAcilanForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerAcilis.Enabled = true;
            this.Opacity = 0.0;

        }

        private void timerAcilis_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1.0)
            {
                this.Opacity += 0.1;

            }
            else
            {
                timerAcilis.Enabled = false;
            }
        }

        private void timerKapanis_Tick(object sender, EventArgs e)
        {
            if(this.Opacity > 0.0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                timerKapanis.Enabled = false;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            timerKapanis.Enabled = true;
        }
    }
}
