using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstoquIN.View;

namespace EstoquIN.View
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            FormGeral Fg = new FormGeral(1);
        }
    }
}
