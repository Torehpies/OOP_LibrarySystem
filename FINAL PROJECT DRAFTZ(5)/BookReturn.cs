using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class BookReturn : Form
    {
        public BookReturn()
        {
            InitializeComponent();
        }

        private void BookReturn_Load(object sender, EventArgs e)
        {
            PrivateFontCollection fonting = new PrivateFontCollection();
            fonting.AddFontFile("C:\\Users\\ADMIN\\Source\\Repos\\OOP_LibrarySystem\\FINAL PROJECT DRAFTZ(5)\\Resources\\Quicksand-VariableFont_wght.ttf");
            Dsplay_bookreturn.Font = new Font(fonting.Families[0], 26, FontStyle.Bold);

            Dsplay_Id.Font = new Font(fonting.Families[0], 15, FontStyle.Bold);

            Dsplay_borrowerinfo.Font = new Font(fonting.Families[0], 26, FontStyle.Bold);
            Dsplay_name.Font = new Font(fonting.Families[0], 15, FontStyle.Regular);
            Dsplay_details.Font = new Font(fonting.Families[0], 15, FontStyle.Regular);
            Dsplay_bookcount.Font = new Font(fonting.Families[0], 15, FontStyle.Regular);
            Dsplay_lstreturn.Font = new Font(fonting.Families[0], 15, FontStyle.Regular);

            Dsplay_namebrwer.Font = new Font(fonting.Families[0], 18, FontStyle.Bold);
            Dsplay_detailsbrwer.Font = new Font(fonting.Families[0], 18, FontStyle.Bold);

            Dsplay_borrowedbooks.Font = new Font(fonting.Families[0], 22, FontStyle.Bold);
            Dsplay_title.Font = new Font(fonting.Families[0], 16, FontStyle.Regular);
            Dsplay_author.Font = new Font(fonting.Families[0], 16, FontStyle.Regular);
            Dsplay_due.Font = new Font(fonting.Families[0], 16, FontStyle.Regular);
            Dsplay_return.Font = new Font(fonting.Families[0], 16, FontStyle.Regular);

            enterId_btn.Font = new Font(fonting.Families[0], 12, FontStyle.Regular);
            cancel_btn.Font = new Font(fonting.Families[0], 12, FontStyle.Regular);
            confirm_btn.Font = new Font(fonting.Families[0], 12, FontStyle.Regular);


            //ApplyFontToLabels(this.Controls, fonting);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        /*private void ApplyFontToLabels(Control.ControlCollection controls, PrivateFontCollection fonting)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Label)
                {
                    ctrl.Font = new Font(fonting.Families[0], 15, FontStyle.Bold);
                }
                else if (ctrl.HasChildren)
                {
                    ApplyFontToLabels(ctrl.Controls, fonting);
                }
            }
        }*/
    }
}
