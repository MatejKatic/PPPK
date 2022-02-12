using System;
using System.Windows.Forms;
using Zadatak.Dal;
using Zadatak0102;

namespace Zadatak
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                RepositoryFactory.GetRepository().LogIn(TbServer.Text.Trim(), TbUserName.Text.Trim(), TbPassword.Text.Trim());
                new SqlManager().Show();
                Hide();
            }
            catch (Exception ex)
            {
                LbError.Text = ex.Message;
            }
        }
    }
}
