namespace digitalClock
{
    partial class Clock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(129, 120);
            label1.Name = "label1";
            label1.Size = new Size(1442, 541);
            label1.TabIndex = 0;
            label1.Text = "00:00:00";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Clock
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1684, 827);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Clock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Digital Clock";
            Load += Clock_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}
