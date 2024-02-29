using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OptiClear.Cleaners;

namespace OptiClear
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            var tempCleaner = new TempCleaner();
            tempCleaner.Clean();
            MessageBox.Show( "Done" );
        }
    }
}
