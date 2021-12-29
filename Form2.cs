using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukrainian_English_Dictionary
{
    public partial class Config : Form
    {
 
        Edit editForm;
        public Config()
        {
            InitializeComponent();
            string lineUa, lineEn;
            try
            {
                var fileUa = new System.IO.StreamReader("dictionaryUa.txt");
                while ((lineUa = fileUa.ReadLine()) != null)
                {
                    lbUa.Items.Add(lineUa);
                }
                fileUa.Close();
                var fileEn = new System.IO.StreamReader("dictionaryEn.txt");
                while ((lineEn = fileEn.ReadLine()) != null)
                {
                    lbEn.Items.Add(lineEn);
                }
                fileEn.Close();
            }
            catch (Exception el) { }
        }

        private void nameLbEn_Click(object sender, EventArgs e)
        {

        }

        private void nameLbUa_Click(object sender, EventArgs e)
        {

        }

        private void inpUa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                inpEn.Focus();
            }
        }

        private void inpEn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                lbUa.Items.Add(inpUa.Text);
                lbEn.Items.Add(inpEn.Text);
                inpUa.Text = "";
                inpEn.Text = "";
                inpUa.Focus();
                System.IO.StreamWriter SaveFileUa = new System.IO.StreamWriter("dictionaryUa.txt");
                foreach (var item in lbUa.Items)
                {
                    SaveFileUa.WriteLine(item.ToString());
                }
                SaveFileUa.Close();
                System.IO.StreamWriter SaveFileEn = new System.IO.StreamWriter("dictionaryEn.txt");
                foreach (var item in lbEn.Items)
                {
                    SaveFileEn.WriteLine(item.ToString());
                }
                SaveFileEn.Close();

            }
        }

        private void closeAdminButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editForm = new Edit();
            editForm.Show();

        }

        private void Config_Load(object sender, EventArgs e)
        {

        }
    }
}
