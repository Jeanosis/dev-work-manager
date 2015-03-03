using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevWorkMainProject.Forms
{
    public partial class CandidateForm : Form
    {
        public CandidateForm()
        {
            InitializeComponent();
        }

        private void CandidateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Enabled = true;            
        }
    }
}
