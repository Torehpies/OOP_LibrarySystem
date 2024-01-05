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
    public partial class libraryPanel : UserControl
    {
        public libraryPanel()
        {
            InitializeComponent();
            InitializeBookContainers();
        }

        private void InitializeBookContainers()
        {
            Label academicLabel = new Label();
            academicLabel.Font = new Font("Franklin Gothic Demi Cond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            academicLabel.ForeColor = Color.FromArgb(73, 85, 121);
            academicLabel.Size = new Size(203, 28);
            academicLabel.TabIndex = 1;
            academicLabel.Text = "ACADEMIC BOOKS";

            Label nonfictionLabel = new Label();
            nonfictionLabel.Font = new Font("Franklin Gothic Demi Cond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nonfictionLabel.ForeColor = Color.FromArgb(73, 85, 121);
            nonfictionLabel.Size = new Size(203, 28);
            nonfictionLabel.TabIndex = 1;
            nonfictionLabel.Text = "NON-FICTION BOOKS";

            Controls.Add(academicLabel);

            FlowLayoutPanel academicPanel = new FlowLayoutPanel();
            academicPanel.BackColor = Color.Transparent;
            //academicPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            academicPanel.AutoSize = true;
            academicPanel.AutoScroll = true;

            for (int i = 0; i < 9; i++)
            {
                academicPanel.Controls.Add(new BookContainer());
            }

            Controls.Add(academicPanel);

            Controls.Add(nonfictionLabel);
        }
    }
}
