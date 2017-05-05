using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takeaway_system
{
    public partial class TSMessage : Form
    {
        public TSMessage()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void MessageExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MessageCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
