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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
         private void btnAddInfo_Click(object sender, EventArgs e)
        {
            AddForm frmADD = new AddForm(this);
            frmADD.Show();
        }
       
        private void btnDelInfo_Click(object sender, EventArgs e)
        {
            dgvTableInfo.Rows.RemoveAt(dgvTableInfo.CurrentCell.RowIndex);
            StreamWriter myWriter = new StreamWriter("Airport_INFO.txt");
            for (int j = 0; j < dgvTableInfo.ColumnCount; j++)
            {
               myWriter.Write(dgvTableInfo.Columns[j].HeaderText.ToString() + ",");
            }
            myWriter.WriteLine();
            for (int i = 0; i < dgvTableInfo.RowCount - 1; i++)
            {
                for (int j = 0; j < dgvTableInfo.ColumnCount - 1; j++)
                {
                    myWriter.Write(dgvTableInfo.Rows[i].Cells[j].Value.ToString() + "/");
                }
                myWriter.WriteLine();
            }
            myWriter.Close();
        }

        public void DataRead()
        {
            DataSet dsSet = new DataSet();
            StreamReader strReader = new StreamReader("Airport_INFO.txt");
            dsSet.Tables.Add(new DataTable());
            string header = strReader.ReadLine();

            string[] colName = System.Text.RegularExpressions.Regex.Split(header, ",");

            for (int i = 0; i < colName.Length; i++)
            {
                dsSet.Tables[0].Columns.Add(colName[i]);
            }
            string row = strReader.ReadLine();
            while (row != null)
            {
                string[] rowValue = System.Text.RegularExpressions.Regex.Split(row, "/");
                dsSet.Tables[0].Rows.Add(rowValue);
                row = strReader.ReadLine();
            }

            dgvTableInfo.DataSource = dsSet.Tables[0];
            strReader.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTableInfo.RowCount; i++)
            {
                dgvTableInfo.Rows[i].Selected = false;
                for (int j = 0; j < dgvTableInfo.ColumnCount; j++)
                    if (dgvTableInfo.Rows[i].Cells[j].Value != null)
                        if (dgvTableInfo.Rows[i].Cells[j].Value.ToString().Contains(tbSearch.Text))
                        {
                            dgvTableInfo.Rows[i].Selected = true;
                            MessageBox.Show("Entry is found in a database...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
              }
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dgvTableInfo.Enabled)
            {
                DataRead();
            }
            else
            {
                dgvTableInfo.Rows.Clear();
            }
        }
        
        string text = @"    Помните, что в случае пожара на борту самолета наибольшую 
        опасность представляет дым, а не огонь. Дышите только через хлопчатобумажные или шерстяные элементы одежды, 
        по возможности, смоченные водой. Пробираясь к выходу, двигайтесь пригнувшись или на четвереньках, так как внизу 
        салона задымленность меньше. Защитите открытые участки тела от прямого воздействия огня, используя имеющуюся одежду,
        пледы и т.д. После приземления и остановки самолета немедленно направляйтесь к ближайшему выходу, 
        так как высока вероятность взрыва. Если проход завален, пробирайтесь через кресла, опуская их спинки. 
        При эвакуации избавьтесь от ручной клади и избегайте выхода через люки, вблизи которых имеется открытый огонь или сильная задымленность.
        После выхода из самолета удалитесь от него как можно дальше и лягте на землю, прижав голову руками – возможен взрыв.
        В любой ситуации действуйте без паники и решительно, это способствует Вашему спасению.";

        private void WarningTimer_Tick(object sender, EventArgs e)
       {
           text = text.Substring(1) + text[0];
           tbWarning.Text = text;
       }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            if (WarningTimer.Enabled)
            {
                WarningTimer.Stop();
            }
            else
            {
                WarningTimer.Start();
            }
        }
    }
}
