using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        /// Ovveride the Params of the form to disallow the red X button in the corner.
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
            Left = mainForm.Left + ((mainForm.Width - Width) / 2);
            Top = mainForm.Top + ((mainForm.Height - Height) / 2);
        }

        void OnCalculateButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
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
