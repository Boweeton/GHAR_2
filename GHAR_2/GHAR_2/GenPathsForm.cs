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

namespace GHAR_2
{
    public partial class GenPathsForm : Form
    {
        #region FormLevelFields

        MainForm mainForm;
        const int CpNocloseButton = 0x200;

        #endregion

        #region EventMethods

        /// <summary>
        /// Override the Params of the form to disallow the red X button in the corner.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CpNocloseButton;
                return myCp;
            }
        }

        public GenPathsForm(MainForm newMainForm)
        {
            InitializeComponent();
            mainForm = newMainForm;
        }

        void OnGeneratePathsSubWindowFormLoad(object sender, EventArgs e)
        {
            // Center the form on the mainForm
            Left = mainForm.Left + ((mainForm.Width - Width) / 2);
            Top = mainForm.Top + ((mainForm.Height - Height) / 2);

            // Generate the raw data paths and load them up
            mainForm.GenerateRawGhPaths();
            eaRawDataPathTextBox.Text = mainForm.RawEaPath;
            tmlRawDataPathTextBox.Text = mainForm.RawTmlPath;
        }

        void OnCopyEaRawDataPathButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(eaRawDataPathTextBox.Text);
        }

        void OnCopyTmlRawDataPathButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tmlRawDataPathTextBox.Text);
        }

        void OnCalculateButton_Click(object sender, EventArgs e)
        {
            // Check state of files
            if (File.Exists(mainForm.RawEaPath) && File.Exists(mainForm.RawTmlPath))
            {
                DialogResult = DialogResult.OK;
                mainForm.ReadInDataAndProcess();
                Close();
            }
            else
            {
                DialogResult localDialog = MessageBox.Show("One or both of the Raw Files are missing. Do you with to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (localDialog == DialogResult.Yes)
                {
                    DialogResult = DialogResult.OK;
                    mainForm.ReadInDataAndProcess();
                    Close();
                }
            }
        }

        void OnCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        #region HelperMethods



        #endregion
    }
}
