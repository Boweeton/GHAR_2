﻿using System;
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
        List<Reservation> masterReservations;
        readonly ReportParser parser = new ReportParser();
        ReportGenerator reportGenerator = new ReportGenerator();


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
            // Clear out the current list
            masterReservations = new List<Reservation>();

            // Read in the TML report
            if (File.Exists(RawTmlPath))
            {
                foreach (Reservation res in parser.ParseTmlReport(RawTmlPath))
                {
                    masterReservations.Add(res);
                }
            }

            // Read in the EA report
            if (File.Exists(RawEaPath))
            {
                foreach (Reservation res in parser.ParseTmlReport(RawEaPath))
                {
                    masterReservations.Add(res);
                }
            }

            // Generate Reports
            reportGenerator.SetMasterReservations(masterReservations);

            // Generate OtherEventCodes
            reportGenerator.CalculateOtherEventCodes();

            // Generate processed report destination paths
            GenerateProcessedGhPaths();

            // Create the 2 new reports
            reportGenerator.CreateDayEventsReport(ProcessedDayEventsReportPath);
            reportGenerator.CreateOvernightsReport(ProcessedOvernightsReportPath);

            gateHousePage.BackColor = Color.Magenta;    // Signal execution point reached
        }

        #endregion
    }
}