//This file is part of PictureResize.

//PictureResize is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//PictureResize is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with PictureResize. If not, see <http://www.gnu.org/licenses/>.

namespace PictureResize {
    partial class MainForm {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent () {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picturesLst = new System.Windows.Forms.ListBox();
            this.loadPicturesBtn = new System.Windows.Forms.Button();
            this.clearListBtn = new System.Windows.Forms.Button();
            this.widthTxt = new System.Windows.Forms.TextBox();
            this.heightTxt = new System.Windows.Forms.TextBox();
            this.widthLbl = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Button();
            this.filenameExtTxt = new System.Windows.Forms.TextBox();
            this.filenameExtLbl = new System.Windows.Forms.Label();
            this.jpgQualityTrb = new System.Windows.Forms.TrackBar();
            this.jpgQualityLbl = new System.Windows.Forms.Label();
            this.interpolationModeLbl = new System.Windows.Forms.Label();
            this.interpolationModeCmb = new System.Windows.Forms.ComboBox();
            this.deleteSelectedBtn = new System.Windows.Forms.Button();
            this.pinBtn = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.languageCmb = new System.Windows.Forms.ComboBox();
            this.languageLbl = new System.Windows.Forms.Label();
            this.copyExifChb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // picturesLst
            // 
            this.picturesLst.AllowDrop = true;
            this.picturesLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picturesLst.FormattingEnabled = true;
            this.picturesLst.Location = new System.Drawing.Point(12, 41);
            this.picturesLst.Name = "picturesLst";
            this.picturesLst.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.picturesLst.Size = new System.Drawing.Size(283, 121);
            this.picturesLst.TabIndex = 4;
            this.picturesLst.DragDrop += new System.Windows.Forms.DragEventHandler(this.picturesLst_DragDrop);
            this.picturesLst.DragEnter += new System.Windows.Forms.DragEventHandler(this.picturesLst_DragEnter);
            // 
            // loadPicturesBtn
            // 
            this.loadPicturesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.loadPicturesBtn.Location = new System.Drawing.Point(40, 12);
            this.loadPicturesBtn.Name = "loadPicturesBtn";
            this.loadPicturesBtn.Size = new System.Drawing.Size(79, 23);
            this.loadPicturesBtn.TabIndex = 1;
            this.loadPicturesBtn.Text = "Bilder laden...";
            this.loadPicturesBtn.UseVisualStyleBackColor = true;
            this.loadPicturesBtn.Click += new System.EventHandler(this.loadPicturesBtn_Click);
            // 
            // clearListBtn
            // 
            this.clearListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearListBtn.Location = new System.Drawing.Point(211, 12);
            this.clearListBtn.Name = "clearListBtn";
            this.clearListBtn.Size = new System.Drawing.Size(84, 23);
            this.clearListBtn.TabIndex = 3;
            this.clearListBtn.Text = "Liste leeren";
            this.clearListBtn.UseVisualStyleBackColor = true;
            this.clearListBtn.Click += new System.EventHandler(this.clearListBtn_Click);
            // 
            // widthTxt
            // 
            this.widthTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.widthTxt.Location = new System.Drawing.Point(48, 174);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(103, 20);
            this.widthTxt.TabIndex = 5;
            // 
            // heightTxt
            // 
            this.heightTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.heightTxt.Location = new System.Drawing.Point(47, 200);
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.Size = new System.Drawing.Size(104, 20);
            this.heightTxt.TabIndex = 6;
            // 
            // widthLbl
            // 
            this.widthLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(8, 177);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(34, 13);
            this.widthLbl.TabIndex = 0;
            this.widthLbl.Text = "Breite";
            // 
            // heightLbl
            // 
            this.heightLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(8, 203);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(33, 13);
            this.heightLbl.TabIndex = 0;
            this.heightLbl.Text = "Höhe";
            // 
            // goBtn
            // 
            this.goBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.goBtn.Location = new System.Drawing.Point(11, 329);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(284, 29);
            this.goBtn.TabIndex = 10;
            this.goBtn.Text = "Los!";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // filenameExtTxt
            // 
            this.filenameExtTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.filenameExtTxt.Location = new System.Drawing.Point(162, 200);
            this.filenameExtTxt.Name = "filenameExtTxt";
            this.filenameExtTxt.Size = new System.Drawing.Size(133, 20);
            this.filenameExtTxt.TabIndex = 7;
            // 
            // filenameExtLbl
            // 
            this.filenameExtLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filenameExtLbl.AutoSize = true;
            this.filenameExtLbl.Location = new System.Drawing.Point(159, 177);
            this.filenameExtLbl.Name = "filenameExtLbl";
            this.filenameExtLbl.Size = new System.Drawing.Size(124, 13);
            this.filenameExtLbl.TabIndex = 0;
            this.filenameExtLbl.Text = "Dateinamenserweiterung";
            // 
            // jpgQualityTrb
            // 
            this.jpgQualityTrb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.jpgQualityTrb.Location = new System.Drawing.Point(51, 226);
            this.jpgQualityTrb.Maximum = 100;
            this.jpgQualityTrb.Name = "jpgQualityTrb";
            this.jpgQualityTrb.Size = new System.Drawing.Size(244, 42);
            this.jpgQualityTrb.TabIndex = 8;
            this.jpgQualityTrb.TickFrequency = 5;
            this.jpgQualityTrb.Value = 100;
            // 
            // jpgQualityLbl
            // 
            this.jpgQualityLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.jpgQualityLbl.AutoSize = true;
            this.jpgQualityLbl.Location = new System.Drawing.Point(8, 242);
            this.jpgQualityLbl.Name = "jpgQualityLbl";
            this.jpgQualityLbl.Size = new System.Drawing.Size(43, 26);
            this.jpgQualityLbl.TabIndex = 0;
            this.jpgQualityLbl.Text = "JPG\r\nQualität";
            // 
            // interpolationModeLbl
            // 
            this.interpolationModeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.interpolationModeLbl.AutoSize = true;
            this.interpolationModeLbl.Location = new System.Drawing.Point(8, 277);
            this.interpolationModeLbl.Name = "interpolationModeLbl";
            this.interpolationModeLbl.Size = new System.Drawing.Size(101, 13);
            this.interpolationModeLbl.TabIndex = 0;
            this.interpolationModeLbl.Text = "Interpolationsmodus";
            // 
            // interpolationModeCmb
            // 
            this.interpolationModeCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.interpolationModeCmb.FormattingEnabled = true;
            this.interpolationModeCmb.Location = new System.Drawing.Point(116, 274);
            this.interpolationModeCmb.Name = "interpolationModeCmb";
            this.interpolationModeCmb.Size = new System.Drawing.Size(179, 21);
            this.interpolationModeCmb.TabIndex = 9;
            // 
            // deleteSelectedBtn
            // 
            this.deleteSelectedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSelectedBtn.Location = new System.Drawing.Point(124, 12);
            this.deleteSelectedBtn.Name = "deleteSelectedBtn";
            this.deleteSelectedBtn.Size = new System.Drawing.Size(81, 23);
            this.deleteSelectedBtn.TabIndex = 2;
            this.deleteSelectedBtn.Text = "Entfernen";
            this.deleteSelectedBtn.UseVisualStyleBackColor = true;
            this.deleteSelectedBtn.Click += new System.EventHandler(this.deleteSelectedBtn_Click);
            // 
            // pinBtn
            // 
            this.pinBtn.BackColor = System.Drawing.SystemColors.Control;
            this.pinBtn.Image = global::PictureResize.Properties.Resources.Pin;
            this.pinBtn.Location = new System.Drawing.Point(11, 12);
            this.pinBtn.Name = "pinBtn";
            this.helpProvider.SetShowHelp(this.pinBtn, true);
            this.pinBtn.Size = new System.Drawing.Size(23, 23);
            this.pinBtn.TabIndex = 12;
            this.pinBtn.UseVisualStyleBackColor = false;
            this.pinBtn.Click += new System.EventHandler(this.pinBtn_Click);
            // 
            // languageCmb
            // 
            this.languageCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.languageCmb.FormattingEnabled = true;
            this.languageCmb.Location = new System.Drawing.Point(116, 364);
            this.languageCmb.Name = "languageCmb";
            this.languageCmb.Size = new System.Drawing.Size(179, 21);
            this.languageCmb.TabIndex = 14;
            this.languageCmb.SelectedIndexChanged += new System.EventHandler(this.spracheToolStripMenuItem_TextChanged);
            // 
            // languageLbl
            // 
            this.languageLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.languageLbl.AutoSize = true;
            this.languageLbl.Location = new System.Drawing.Point(8, 367);
            this.languageLbl.Name = "languageLbl";
            this.languageLbl.Size = new System.Drawing.Size(47, 13);
            this.languageLbl.TabIndex = 15;
            this.languageLbl.Text = "Sprache";
            // 
            // copyExifChb
            // 
            this.copyExifChb.AutoSize = true;
            this.copyExifChb.Checked = true;
            this.copyExifChb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyExifChb.Location = new System.Drawing.Point(12, 301);
            this.copyExifChb.Name = "copyExifChb";
            this.copyExifChb.Size = new System.Drawing.Size(119, 17);
            this.copyExifChb.TabIndex = 17;
            this.copyExifChb.Text = "Exif Daten kopieren";
            this.copyExifChb.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 397);
            this.Controls.Add(this.copyExifChb);
            this.Controls.Add(this.languageLbl);
            this.Controls.Add(this.languageCmb);
            this.Controls.Add(this.pinBtn);
            this.Controls.Add(this.deleteSelectedBtn);
            this.Controls.Add(this.interpolationModeCmb);
            this.Controls.Add(this.interpolationModeLbl);
            this.Controls.Add(this.jpgQualityLbl);
            this.Controls.Add(this.jpgQualityTrb);
            this.Controls.Add(this.filenameExtLbl);
            this.Controls.Add(this.filenameExtTxt);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.heightTxt);
            this.Controls.Add(this.widthTxt);
            this.Controls.Add(this.clearListBtn);
            this.Controls.Add(this.loadPicturesBtn);
            this.Controls.Add(this.picturesLst);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(315, 355);
            this.Name = "MainForm";
            this.Text = "PictureResize";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox picturesLst;
        private System.Windows.Forms.Button loadPicturesBtn;
        private System.Windows.Forms.Button clearListBtn;
        private System.Windows.Forms.TextBox widthTxt;
        private System.Windows.Forms.TextBox heightTxt;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.TextBox filenameExtTxt;
        private System.Windows.Forms.Label filenameExtLbl;
        private System.Windows.Forms.TrackBar jpgQualityTrb;
        private System.Windows.Forms.Label jpgQualityLbl;
        private System.Windows.Forms.Label interpolationModeLbl;
        private System.Windows.Forms.ComboBox interpolationModeCmb;
        private System.Windows.Forms.Button deleteSelectedBtn;
        private System.Windows.Forms.Button pinBtn;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.ComboBox languageCmb;
        private System.Windows.Forms.Label languageLbl;
        private System.Windows.Forms.CheckBox copyExifChb;
    }
}

