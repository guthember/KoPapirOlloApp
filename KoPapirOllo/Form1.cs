using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoPapirOllo
{
    public partial class frmFo : Form
    {
        int ember = 0;
        int gep = 0;
        public frmFo()
        {
            InitializeComponent();
            lblKor.Text = "";
        }

        private void menuKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Valasztas_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b != null)
            {
                int emberValasz = EmberValasztas(b.Tag.ToString());
                string szovegesKor = b.Tag.ToString()+" - ";
                int gepValasz = GepValasztas();
                szovegesKor += GepSzoveg(gepValasz);
                lblKor.Text = szovegesKor;
                Kiertekel(emberValasz, gepValasz);
            }
        }

        private string GepSzoveg(int gepValasz)
        {
            switch (gepValasz)
            {
                case 1:
                    return "Kő";
                case 2:
                    return "Papír";
                default:
                    return "Olló";
            }
        }

        private void Kiertekel(int emberValasz, int gepValasz)
        {
            if (emberValasz == gepValasz)
            {
                gep++;
                ember++;
            }
            else if ( EmberNyer(emberValasz, gepValasz) )
            {
                ember++;
            }
            else
            {
                gep++;
            }

            EredmenyKiiras();
        }

        private void EredmenyKiiras()
        {
            lblEredmeny.Text = $"Eredmény: {ember} - {gep}";
        }

        private static bool EmberNyer(int emberValasz, int gepValasz)
        {
            return (emberValasz == 1 && gepValasz == 3)
                            ||
                            (emberValasz == 2 && gepValasz == 1)
                            ||
                            (emberValasz == 3 && gepValasz == 2);
        }

        private int EmberValasztas(string mit)
        {
            if (mit == "Kő")
            {
                return 1;
            }
            else if(mit == "Papír")
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        private int GepValasztas()
        {
            Random vel = new Random(Guid.NewGuid().GetHashCode());

            return vel.Next(3) + 1;

        }

        private void menuJatekszabaly_Click(object sender, EventArgs e)
        {
            frmSzabaly formSzabaly = new frmSzabaly();
            formSzabaly.ShowDialog();
        }

        private void menuRolunk_Click(object sender, EventArgs e)
        {
            AboutBox1 FormRolunk = new AboutBox1();
            FormRolunk.ShowDialog();
        }
    }
}
