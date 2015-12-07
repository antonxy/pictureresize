using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PictureResize
{
    public partial class ErrorForm : Form
    {
        IErrorsLanguage language;
        PictureResizeError[] errors;
        public ErrorForm(IErrorsLanguage language, PictureResizeError[] errors)
        {
            InitializeComponent();
            this.language = language;
            this.errors = errors;
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            this.Text = language.WindowHeading;
            errorsHeadingLbl.Text = language.ErrorsOcoured;

            errorsLst.Items.Clear();
            foreach (PictureResizeError error in errors)
            {
                errorsLst.Items.Add(error.GetErrorMessage(language));
            }
        }
    }
}
