using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace DevWorkMainProject.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainGridControl.DataSource = CreateData();
        }

        private List<Candidate> CreateData()
        {
            Contact newContact = null;
            List<Candidate> Result = new List<Candidate>();

            for (int i = 0; i < 10; i++)
            {
                newContact = new Contact();
                newContact.Date = new DateTime(1994, 01, 15 + i);
                newContact.Comment = String.Format("This is comment #{0}", i);
                newContact.Type = ContactType.Meet;

                Result.Add(new Candidate(String.Format("Vasya_{0}", i), String.Format("Vasilievich_{0}", i),
                    String.Format("Pupkin_{0}", i), GenderType.Male, newContact));
            }

            return Result;
        }
    }
}
