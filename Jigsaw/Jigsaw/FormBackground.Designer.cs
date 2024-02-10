namespace Main
{
    partial class FormBackground
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerActivateChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerActivateChecker
            // 
            this.timerActivateChecker.Enabled = true;
            this.timerActivateChecker.Tick += new System.EventHandler(this.timerActivateChecker_Tick);
            // 
            // FormBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "FormBackground";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Timer timerActivateChecker;
    }
}

