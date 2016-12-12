using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AirportApp
{
    public partial class AddForm : Form
    {
        public AddForm(MainForm _frm)
        {
            InitializeComponent();
        }
       
        public void AddInfoToDB()
        {
            try
            {
                FileStream fileStream = new FileStream("Airport_INFO.txt", FileMode.Append);//запись в конец файла
                StreamWriter strWriter = new StreamWriter(fileStream);

                string lines = tbNumberFly.Text + "/" + tbArrival.Text + "/" + tbDepart.Text + "/" +
                               tbDirection.Text + "/" + tbAirline.Text + "/" + tbTerminal.Text + "/" +
                               cbStatus.Text;

                strWriter.Write("\r\n" + lines);
                strWriter.Close();
                
                MessageBox.Show("Information added", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbNumberFly.Text == "" && tbArrival.Text == "" && tbDepart.Text == "" &&
                tbDirection.Text == "" && tbAirline.Text == "" && tbTerminal.Text == "" &&
                cbStatus.Text == "")
            {
                MessageBox.Show("Write all elements...", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else AddInfoToDB();
        }
    }
}
