using CustomControls.RJControls;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkoutBtn = new CustomButton();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(1, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1135, 471);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // checkoutBtn
            // 
            checkoutBtn.BackColor = Color.FromArgb(34, 34, 59);
            checkoutBtn.BackgroundColor = Color.FromArgb(34, 34, 59);
            checkoutBtn.BorderColor = Color.PaleVioletRed;
            checkoutBtn.BorderRadius = 20;
            checkoutBtn.BorderSize = 0;
            checkoutBtn.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            checkoutBtn.FlatAppearance.BorderSize = 0;
            checkoutBtn.FlatStyle = FlatStyle.Flat;
            checkoutBtn.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkoutBtn.ForeColor = Color.White;
            checkoutBtn.Location = new Point(902, 485);
            checkoutBtn.Name = "checkoutBtn";
            checkoutBtn.Size = new Size(119, 38);
            checkoutBtn.TabIndex = 9;
            checkoutBtn.Text = "Checkout";
            checkoutBtn.TextColor = Color.White;
            checkoutBtn.UseVisualStyleBackColor = false;
            checkoutBtn.Click += button1_Click;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 173, 167);
            Controls.Add(checkoutBtn);
            Controls.Add(flowLayoutPanel1);
            Name = "Checkout";
            Size = new Size(1136, 559);
            Load += Checkout_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private CustomButton checkoutBtn;
    }
}