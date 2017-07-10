using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maintenance_Scheduler_UI
{
    public partial class Messanger : Form
    {
        public Messanger(string message)
        {
            InitializeComponent();
            messageRtb.Text = message;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
