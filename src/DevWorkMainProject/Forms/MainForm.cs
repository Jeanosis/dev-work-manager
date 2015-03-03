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

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainGridControl.DataSource = CreateData();
            
            mainGridView.OptionsView.ShowIndicator = false;
            this.AddOwnedForm(new CandidateForm());
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.Length > 1)
                return;

            this.AddOwnedForm(new CandidateForm());
            OwnedForms[0].Show();
            //this.Enabled = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (this.OwnedForms.Length > 1)
                return;

            this.AddOwnedForm(new CandidateForm());
            OwnedForms[0].Show();
            //this.Enabled = false;
        }
    }
}
