using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepoManager.Views
{
    public partial class AddLinkedRepoForm : Form
    {
        public AddLinkedRepoForm()
        {
            InitializeComponent();
        }

        public List<string> ReposList { get; set; } = new List<string>();
        public string SelectedRepo { get; set; }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddLinkedRepoForm_Load(object sender, EventArgs e)
        {
            ReposList.ForEach(x => comboBoxReposList.Items.Add(x));
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (comboBoxReposList.SelectedIndex != -1)
                SelectedRepo = comboBoxReposList.Text;
            Close();
        }

        private void comboBoxReposList_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = comboBoxReposList.SelectedIndex != -1;
        }
    }
}
