using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseService;

namespace WindowsFormsUsers
{
    public partial class AddUser : Form
    {
        private readonly Form1 FormUserList;
        public AddUser(Form1 FormUser)
        {
            FormUserList = FormUser;
            InitializeComponent();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            User oUser = new User();
            oUser.nUserID = Int32.Parse(inptNewID.Text);
            oUser.sUserFirstName = inptNewFirstName.Text;
            oUser.sUserLastName = inptNewLastName.Text;
            oUser.sUserPassword = inptNewPassword.Text;
            oUser.sUserName = inptNewUserName.Text;
            Crud Crud = new Crud();
            Crud.AddUsers(oUser);
            this.FormUserList.dataGridViewUsers.DataSource = Crud.GetUsers();
            this.Hide();
        }
    }
}
