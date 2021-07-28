namespace Flight_Reservation_System
{
    partial class Help_Form
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
            this.txtBox_Help = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox_Help
            // 
            this.txtBox_Help.BackColor = System.Drawing.SystemColors.Info;
            this.txtBox_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Help.Location = new System.Drawing.Point(12, 12);
            this.txtBox_Help.Multiline = true;
            this.txtBox_Help.Name = "txtBox_Help";
            this.txtBox_Help.ReadOnly = true;
            this.txtBox_Help.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Help.Size = new System.Drawing.Size(539, 361);
            this.txtBox_Help.TabIndex = 2;
            this.txtBox_Help.TabStop = false;
            // 
            // Help_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 385);
            this.Controls.Add(this.txtBox_Help);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Help_Form";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox_Help;
    }
}