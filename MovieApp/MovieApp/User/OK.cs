using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp.User
{
    public partial class OK : Form
    {
        main OW;
        public OK()
        {
            InitializeComponent();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            OW.deleteForm();
            OW.putForm(new home());
        }

        private void OK_Load(object sender, EventArgs e)
        {
            OW = (main)this.Owner;
        }
    }
}
