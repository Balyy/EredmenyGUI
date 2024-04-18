using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EredmenyGUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //EredmenyRepository.Path = "eredmenyek.txt";
            //dataGridViewEredmeny.DataSource = EredmenyRepository.FindAll();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogEredmeny.ShowDialog() == DialogResult.OK)
            {
                EredmenyRepository.Path = openFileDialogEredmeny.FileName;
                dataGridViewEredmeny.DataSource = EredmenyRepository.FindAll();
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
