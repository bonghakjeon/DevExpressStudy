﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace ProgressIndicatorExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Processing data...");

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);  // Demo
            }

            SplashScreenManager.CloseForm();
        }
    }
}
