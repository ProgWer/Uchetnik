using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uchetnik
{
    
    public partial class Auth_Form : Form
    {   SQL SQL = new SQL();
        public Auth_Form()
        {
            InitializeComponent();
            
        }

        private void Auth_Button_Click(object sender, EventArgs e)
        {
            if (SQL.AuthQuery(Auth_TextBox.Text) == true)
            {MainForm MainForm = new MainForm(); MainForm.Show(); Hide(); }else MessageBox.Show("Такого пользователя не существует или введен неверный логин", "Ошибка #1");
        }
    }
}
