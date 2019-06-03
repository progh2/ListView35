using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        string strName;
        string strAge;
        string strWork;

        public Form1()
        {
            InitializeComponent();
        }

        private bool TextCheck()
        {
            if(this.txtName.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            if (this.txtAge.Text == "")
            {
                MessageBox.Show("나이를 입력해주세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAge.Focus();
                return false;
            }
            if (this.txtWork.Text == "")
            {
                MessageBox.Show("직업을 입력해주세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtWork.Focus();
                return false;
            }
            return true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TextCheck())
            {
                getUserInput();
                AddListViewItem();
                ClearUserInput();
                this.txtName.Focus();
            }
        }

        private void ClearUserInput()
        {
            this.txtName.Text = "";
            this.txtAge.Text = "";
            this.txtWork.Text = "";
        }

        private void AddListViewItem()
        {
            ListViewItem lvi = new ListViewItem(
                    new string[] {
                            this.strName,this.strAge,this.strWork
                    }
                );
            this.lvView.Items.Add(lvi);
        }

        private void getUserInput()
        {
            this.strName = this.txtName.Text;
            this.strAge = this.txtAge.Text;
            this.strWork = this.txtWork.Text;
        }

        private void LvView_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = this.lvView.SelectedItems[0];
            string name = lvi.SubItems[0].Text;
            string age = lvi.SubItems[1].Text;
            string work = lvi.SubItems[2].Text;

            MessageBox.Show("이름 : " + name +
                "\n나이 : " + age +
                "\n직업 : " + work, "자세히 보기",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
