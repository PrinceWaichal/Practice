namespace Practice_Form
{
    partial class Form1
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
            this.Web01 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // Web01
            // 
            this.Web01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Web01.Location = new System.Drawing.Point(0, 0);
            this.Web01.MinimumSize = new System.Drawing.Size(20, 20);
            this.Web01.Name = "Web01";
            this.Web01.Size = new System.Drawing.Size(966, 645);
            this.Web01.TabIndex = 0;
            this.Web01.Url = new System.Uri("C:\\Users\\Prince\\Source\\Repos\\Practice\\Web Pages\\Assignment1 (Superb).html", System.UriKind.Absolute);
            this.Web01.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Web01_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 645);
            this.Controls.Add(this.Web01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser Web01;
    }
}

