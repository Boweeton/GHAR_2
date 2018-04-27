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
    public partial class MainForm : Form
    {
        #region Fields



        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }


        #endregion

        #region Properties

        public string ToursReportPath { get; set; }

        public string DayEventsReportPath { get; set; }

        #endregion

        #region EventMethods

        void OnGharMainScreenFormLoad(object sender, EventArgs e)
        {

        }

        void OnOpenGenPathsButton_Click(object sender, EventArgs e)
        {
            GenPathsForm genPathsForm = new GenPathsForm(this);
            genPathsForm.ShowDialog();
        }

        #endregion

        #region HelperMethods

        public void GenerateGhPaths()
        {

        }

        #endregion
    }
}