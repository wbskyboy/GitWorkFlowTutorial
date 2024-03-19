using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace GitWorkFlowTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public BindingList<User> Users = new BindingList<User>();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Users.Add(new User()
                {
                    Id = i,
                    Name = $"Name{i}",
                    Address = $"Address{i}",
                    BirthDay = DateTime.Now,
                });
            }
            vGridControl1.DataSource = Users;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(comboBoxEdit1.SelectedIndex >= 0)
                dataLayoutControl1.DataSource = Users[comboBoxEdit1.SelectedIndex];
        }
    }
}
