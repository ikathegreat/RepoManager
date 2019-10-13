namespace RepoManager
{
    partial class RepoPropertiesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepoPropertiesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPreferredSolution = new System.Windows.Forms.Label();
            this.comboBoxPreferredSolution = new System.Windows.Forms.ComboBox();
            this.checkBoxOpenAsAdmin = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 232);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(672, 35);
            this.panel1.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(487, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(90, 25);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(577, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 25);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPreferredSolution
            // 
            this.labelPreferredSolution.AutoSize = true;
            this.labelPreferredSolution.Location = new System.Drawing.Point(12, 20);
            this.labelPreferredSolution.Name = "labelPreferredSolution";
            this.labelPreferredSolution.Size = new System.Drawing.Size(102, 15);
            this.labelPreferredSolution.TabIndex = 4;
            this.labelPreferredSolution.Text = "Preferred Solution";
            // 
            // comboBoxPreferredSolution
            // 
            this.comboBoxPreferredSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPreferredSolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPreferredSolution.FormattingEnabled = true;
            this.comboBoxPreferredSolution.Location = new System.Drawing.Point(15, 38);
            this.comboBoxPreferredSolution.Name = "comboBoxPreferredSolution";
            this.comboBoxPreferredSolution.Size = new System.Drawing.Size(645, 23);
            this.comboBoxPreferredSolution.TabIndex = 5;
            // 
            // checkBoxOpenAsAdmin
            // 
            this.checkBoxOpenAsAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxOpenAsAdmin.AutoSize = true;
            this.checkBoxOpenAsAdmin.Location = new System.Drawing.Point(454, 67);
            this.checkBoxOpenAsAdmin.Name = "checkBoxOpenAsAdmin";
            this.checkBoxOpenAsAdmin.Size = new System.Drawing.Size(206, 19);
            this.checkBoxOpenAsAdmin.TabIndex = 6;
            this.checkBoxOpenAsAdmin.Text = "Open Preferred Solution as Admin";
            this.checkBoxOpenAsAdmin.UseVisualStyleBackColor = true;
            // 
            // RepoPropertiesForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(672, 267);
            this.Controls.Add(this.checkBoxOpenAsAdmin);
            this.Controls.Add(this.comboBoxPreferredSolution);
            this.Controls.Add(this.labelPreferredSolution);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RepoPropertiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repo Properties";
            this.Load += new System.EventHandler(this.RepoPropertiesForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPreferredSolution;
        private System.Windows.Forms.ComboBox comboBoxPreferredSolution;
        private System.Windows.Forms.CheckBox checkBoxOpenAsAdmin;
    }
}