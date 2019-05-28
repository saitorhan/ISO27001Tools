using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISO27001Tools.GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void localAdminTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form localAdminTest = new LocalAdminTest();
            OpenForm(ref localAdminTest);
        }

        void OpenForm(ref Form newForm)
        {
            Form f = newForm;

            Form form = MdiChildren.FirstOrDefault(ff => ff.Text == f.Text);

            if (form != null)
            {
                form.BringToFront();
            }
            else
            {
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }
    }
}
