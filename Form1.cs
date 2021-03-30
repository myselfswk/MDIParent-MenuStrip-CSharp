using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIParent_MenuStrip_CSharp
{
    public partial class mdiForm : Form
    {
        public mdiForm()
        {
            InitializeComponent();
        }

        private void textEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditor textEditor = new TextEditor();
            textEditor.MdiParent = this;
            textEditor.Show();
        }

        private void stopWatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopWatch stopWatch = new StopWatch();
            stopWatch.MdiParent = this;
            stopWatch.Show();
        }
    }
}
