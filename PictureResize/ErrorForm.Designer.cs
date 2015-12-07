namespace PictureResize
{
    partial class ErrorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.errorsHeadingLbl = new System.Windows.Forms.Label();
            this.errorsLst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // errorsHeadingLbl
            // 
            this.errorsHeadingLbl.AutoSize = true;
            this.errorsHeadingLbl.Location = new System.Drawing.Point(10, 9);
            this.errorsHeadingLbl.Name = "errorsHeadingLbl";
            this.errorsHeadingLbl.Size = new System.Drawing.Size(131, 13);
            this.errorsHeadingLbl.TabIndex = 0;
            this.errorsHeadingLbl.Text = "Folgende Fehler traten auf";
            // 
            // errorsLst
            // 
            this.errorsLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.errorsLst.FormattingEnabled = true;
            this.errorsLst.Location = new System.Drawing.Point(12, 25);
            this.errorsLst.Name = "errorsLst";
            this.errorsLst.Size = new System.Drawing.Size(268, 69);
            this.errorsLst.TabIndex = 1;
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 112);
            this.Controls.Add(this.errorsLst);
            this.Controls.Add(this.errorsHeadingLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 139);
            this.Name = "ErrorForm";
            this.Text = "PictureResize - Fehler";
            this.Load += new System.EventHandler(this.ErrorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorsHeadingLbl;
        private System.Windows.Forms.ListBox errorsLst;
    }
}