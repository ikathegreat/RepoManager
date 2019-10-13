using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepoManager
{
    public partial class RepoPropertiesForm : Form
    {
        private readonly RepoModel repoModel;
        private IniFile iniFile;
        public RepoPropertiesForm(RepoModel aRepoModel)
        {
            InitializeComponent();
            repoModel = aRepoModel;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RepoPropertiesForm_Load(object sender, EventArgs e)
        {
            var slnList = repoModel.GetSolutionList();
            slnList.ForEach(x => comboBoxPreferredSolution.Items.Add(x));

            iniFile = new IniFile(FormMain.RepoPropertiesIni);
            comboBoxPreferredSolution.Text = iniFile.ReadString(repoModel.Name, "PreferredSolution", "");
            checkBoxOpenAsAdmin.Checked = iniFile.ReadBool(repoModel.Name, "OpenPreferredSolutionAsAdmin", false);

            if (string.IsNullOrEmpty(comboBoxPreferredSolution.Text) && slnList.Count == 1)
                comboBoxPreferredSolution.SelectedIndex = 0;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            iniFile.WriteString(repoModel.Name, "PreferredSolution", comboBoxPreferredSolution.Text);
            iniFile.WriteBool(repoModel.Name, "OpenPreferredSolutionAsAdmin", checkBoxOpenAsAdmin.Checked);
            Close();
        }
    }
}
