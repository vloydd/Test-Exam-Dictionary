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
    public partial class Dictionary : Form
    {
        Config adminForm;
        public Dictionary()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void showTranslate (string tofrom, Label lbFrom, Label lbTo)
        {
            adminForm = new Config();
            ListBox from = adminForm.lbEn, to = adminForm.lbUa;
            if (tofrom == "Ukrainian-English")
            {
                from = adminForm.lbUa;
                to = adminForm.lbEn;
            }
            else
            {
                from = adminForm.lbEn;
                to = adminForm.lbUa;
            }
            for (int i = 0; i<from.Items.Count; i++)
            {
                if (lbFrom.Text != from.Items[i].ToString())
                {
                    lbFrom.Text = from.Items[i].ToString();
                    lbTo.Text = to.Items[i].ToString();
                }
            }
        }
        private void adminButton_Click(object sender, EventArgs e)
        {
            adminForm = new Config();
            adminForm.Show();
        }

        private void rb_ua_CheckedChanged(object sender, EventArgs e)
        {
            showTranslate("Ukrainian-English", lbTranslate1, lbTranslate2);
        }

        private void rb_en_CheckedChanged(object sender, EventArgs e)
        {
            showTranslate("English-Ukrainian", lbTranslate1, lbTranslate2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void searchTranslate(Label lbSearch)
        {
            adminForm = new Config();
            ListBox from = adminForm.lbEn, to = adminForm.lbUa;           
            if (rb_ua.Checked == true)
            {
                from = adminForm.lbUa;
                to = adminForm.lbEn;
            }
            else if (rb_en.Checked == true)
            {
                from = adminForm.lbEn;
                to = adminForm.lbUa;
            }
            for (int i = 0; i<from.Items.Count; i++)
            {
                if (tbSearch.Text == from.Items[i].ToString())
                {
                    lbSearch.Text = to.Items[i].ToString();
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            tbSearch.Text = "";
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                searchTranslate(lbSearchRes);
            }
        }
    }
}
