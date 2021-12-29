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
    public partial class Edit : Form
    {
        Config adminForm;
        Dictionary mainForm;
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }
        void searchEditTranslate(Label lbSearch)
        {
            adminForm = new Config();
            mainForm = new Dictionary();
            ListBox from = adminForm.lbEn, to = adminForm.lbUa;
            if (mainForm.rb_ua.Checked == true)
            {
                from = adminForm.lbUa;
                to = adminForm.lbEn;
            }
            else if (mainForm.rb_en.Checked == true)
            {
                from = adminForm.lbEn;
                to = adminForm.lbUa;
            }
            for (int i = 0; i<from.Items.Count; i++)
            {
                if (tbSearchEdit.Text == from.Items[i].ToString())
                {
                    tbSearchEdit.Text = to.Items[i].ToString();
                }
            }
        }

        private void btnCloseEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void tbSearchEdit_KeyUp(object sender, EventArgs e)
        //{

        //}

        // private void tbEditWord_KeyUp(object sender, EventArgs e)
        //{
        // if (e.KeyCode == Keys.Return)
        //{
        //    searchTranslateEdit(lbSearchRes);
        //}

        //}
    }
}
