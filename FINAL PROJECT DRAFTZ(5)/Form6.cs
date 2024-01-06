using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class BorrowingForm : Form
    {
        int borrowLimit;
        public BorrowingForm()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check if any CheckBox in the GroupBox is checked
            foreach (CheckBox checkBox in groupBox1.Controls)
            {
                if (checkBox.Checked)
                {
                    // Show a dialog box (replace YourDialogBox with the actual dialog box you want to show)
                    MessageBox.Show("Academic Books are only allowed inside the library");
                }
            }
        }

        public void formConfig(bool isStudent)
        {
            if (isStudent) { borrowLimit = 2; }
            else { borrowLimit = 5; }
        }


        private int CountCheckedCheckboxes(Control container)
        {
            int checkedCount = 0;

            // Iterate through all controls in the container
            foreach (Control control in container.Controls)
            {
                // Check if the control is a CheckBox
                if (control is CheckBox checkBox)
                {
                    // Check if the CheckBox is checked
                    if (checkBox.Checked)
                    {
                        checkedCount++;
                    }
                }

                // If the control is a container (like a GroupBox), recursively count checkboxes within it
                if (control.HasChildren)
                {
                    checkedCount += CountCheckedCheckboxes(control);
                }
            }

            return checkedCount;
        }
        private void BorrowingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
