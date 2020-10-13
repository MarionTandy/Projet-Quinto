using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quinto
{
    public partial class Scores : Form
    {
        private Scores()
        {
            InitializeComponent();
        }

        private static Scores singleScores = null;

        public static Scores Instance()
        {
            if (singleScores == null)
            {
                singleScores = new Scores();
            }
            return singleScores;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
