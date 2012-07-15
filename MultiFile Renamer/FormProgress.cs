using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultiFile_Renamer
{
    public partial class FormProgress : Form
    {
        BackgroundWorker backGrdWker;

        public FormProgress(BackgroundWorker b)
        {
            InitializeComponent();

            CenterToScreen();

            backGrdWker = b;
        }

        public void setProgressBarValue(int value)
        {
            progressBar1.Value = value;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            backGrdWker.CancelAsync();
        }
    }
}