using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inf1013_lab1_WF
{
    public partial class Form1 : Form
    {

        DBConnect DB = new DBConnect();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le compte du nombre de quetions est : " + DB.Count());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBoxCommand.GetItemCheckState(0) == CheckState.Checked)
            {
                if (checkedListBoxItem.GetItemCheckState(0) == CheckState.Checked)
                {
                    String query = null;

                    if (checkedListBoxTable.GetItemCheckState(0) == CheckState.Checked)
                    {
                        query = "SELECT * FROM tblCategorie";
                    }
                    else if (checkedListBoxTable.GetItemCheckState(1) == CheckState.Checked)
                    {
                        query = "SELECT * FROM tblQuestion";
                    }
                    if (checkedListBoxTable.GetItemCheckState(2) == CheckState.Checked)
                    {
                        query = "SELECT * FROM tblReponse";
                    }

                    DB.Select(query);
                }
            }
        }
    }
}
