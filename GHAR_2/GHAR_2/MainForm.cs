using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CS3020HW3Classes;
using GHAR_2_Class_Library;

namespace GHAR_2
{
    public partial class MainForm : Form
    {
        #region Fields

        readonly string currentDirectory = Directory.GetCurrentDirectory();
        const string RawDataFolderName = "RawData";
        const string ProcessedDataFolderName = "ProcessedData";
        List<Reservation> masteReservations;

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }


        #endregion

        #region Properties

        public string RawEaPath { get; set; }

        public string RawTmlPath { get; set; }

        public string ProcessedOvernightsReportPath { get; set; }

        public string ProcessedDayEventsReportPath { get; set; }

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

        public void GenerateRawGhPaths()
        {
            RawEaPath = $"{currentDirectory}/{RawDataFolderName}/{Util.CreateRawDataFileName("EA", "txt")}";
            RawTmlPath = $"{currentDirectory}/{RawDataFolderName}/{Util.CreateRawDataFileName("TML", "txt")}";
        }

        void GenerateProcessedGhPaths()
        {
            ProcessedOvernightsReportPath = $"{currentDirectory}/{ProcessedDataFolderName}/{Util.CreateProcessedDataFileName("Overnights", "txt")}";
            ProcessedDayEventsReportPath = $"{currentDirectory}/{ProcessedDataFolderName}/{Util.CreateProcessedDataFileName("DayEvents", "txt")}";
        }

        public void ReadInDataAndProcess()
        {
            BackColor = Color.Magenta;
        }

        #endregion
    }
}