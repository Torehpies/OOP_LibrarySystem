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
            button5 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(1, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1135, 503);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(102, 102, 102);
            button5.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Quicksand SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(874, 511);
            button5.Name = "button5";
            button5.Size = new Size(75, 27);
            button5.TabIndex = 9;
            button5.Text = "Checkout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button1_Click;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(button5);
            Controls.Add(flowLayoutPanel1);
            Name = "Checkout";
            Size = new Size(1136, 559);
            Load += Checkout_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button5;
    }
}