using _05_Tipler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta05_01_KisiTakipWinform
{
    public partial class Form1 : Form
    {
        FormSetteings frmSetteings;
        public Form1()
        {
            frmSetteings = new FormSetteings();
            string txtSt = File.ReadAllText("../../../Setteings.json");
            frmSetteings=JsonSerializer.Deserialize<FormSetteings>(txtSt);
            InitializeComponent();
            try
            {
                //   this.BackColor = Color.FromArgb(frmSetteings.BackColor.Alpha, frmSetteings.BackColor.Red, frmSetteings.BackColor.Green, frmSetteings.BackColor.Blue);
                //   this.BackColor = Color.FromName(frmSetteings.BackColor); ;
                // this.BackColor = frmSetteings.BackColor;
                this.BackColor = Color.FromArgb(frmSetteings.BackColor.A, frmSetteings.BackColor.R, frmSetteings.BackColor.G, frmSetteings.BackColor.B);
            }
            catch (Exception)
            {

              //  this.BackColor = ColorTranslator.FromHtml(frmSetteings.BackColor);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Location.X + 10, this.Location.Y + 30);
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                //  string ayarlar = $"'BackColor':{ colorDialog1.Color.Name} }}";
                // colorDialog1.Color.
                //  frmSetteings.BackColor = colorDialog1.Color.Name;


                //  frmSetteings.BackColor = new MyColor(colorDialog1.Color.A, colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
                frmSetteings.BackColor = colorDialog1.Color;

                string ayarlar = JsonSerializer.Serialize(frmSetteings);

                File.WriteAllText("../../../Setteings.json", ayarlar);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKisi frm = new FormKisi();
            frm.ShowDialog();
        }
    }
}
