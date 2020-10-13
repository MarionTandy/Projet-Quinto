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
    public partial class Jeu : Form
    {
        private Jeu()
        {
            InitializeComponent();
        }

        private static Jeu singleJeu = null;
        public static Jeu Instance()
        {
            if (singleJeu == null)
            {
                singleJeu = new Jeu();
            }
            return singleJeu;
        }

        private void bu_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            foreach (Char c in txtMotATrouver.Text)
            {
                if (c.Equals(button.Text))
                {
                    
                }
            }
        }
    }
}
