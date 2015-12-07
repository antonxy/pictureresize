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

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.IO;

namespace PictureResize
{
    public partial class MainForm : Form
    {
        IMainFormLanguage language;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string[] filenames)
        {
            InitializeComponent();
            loadPictureFilenames(filenames);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnterLanguagesInCombo();
            SetSelectedLanguage();
            LoadSettings();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            ResizePics();
        }

        private void spracheToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            SetSelectedLanguage();
        }

        private void loadPicturesBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDiag = new OpenFileDialog();
            openDiag.Multiselect = true;

            if (openDiag.ShowDialog() != DialogResult.OK)
                return;

            loadPictureFilenames(openDiag.FileNames);
        }

        private void clearListBtn_Click(object sender, EventArgs e)
        {
            picturesLst.Items.Clear();
        }

        private void picturesLst_DragDrop(object sender, DragEventArgs e)
        {
            //Die geDragNDropten Dateien werden zur Liste hinzugefügt
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            loadPictureFilenames(s);
        }

        private void picturesLst_DragEnter(object sender, DragEventArgs e)
        {
            //Nur Dateien für DragNDrop zulassen
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Löscht die Ausgewählten Einträge aus der Liste
        /// </summary>
        private void deleteSelectedBtn_Click(object sender, EventArgs e)
        {
            //Leere Liste wird erzeugt und die Daten aus picturesLst.Items hineingeschreiben
            //da sonst zu durchsuchende Liste durch das Löschen während dem foreach verändert würde
            List<int> colDel = new List<int>();
            foreach (int i in picturesLst.SelectedIndices)
            {
                colDel.Add(i);
            }
            colDel.Reverse();

            //Die Einträge werden aus picturesLst.Items gelöscht
            foreach (int i in colDel)
            {
                picturesLst.Items.RemoveAt(i);
            }
            colDel = null;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }

        /// <summary>
        /// Vergrößert/-kleinert alle geladenen Bilder
        /// </summary>
        private void ResizePics()
        {
            //Es muss eine Dateinamenserweiterung eingegeben werden
            if (filenameExtTxt.Text == "")
            {
                MessageBox.Show(language.EnterFilenameExt);
                return;
            }

            //Die Höhe und Breite wird aus den entsprechenden Textfeldern ausgelesen
            int width = 0;
            int height = 0;

            int.TryParse(widthTxt.Text, out width);
            int.TryParse(heightTxt.Text, out height);

            //Breite und/oder Höhe müssen eingegeben werden
            if (width <= 0 && height <= 0)
            {
                MessageBox.Show(language.NoWidthHeightEntered);
                return;
            }

            //Liste mit den auszuführenden Tasks
            List<LoadResizeSaveTask> tasks = new List<LoadResizeSaveTask>();

            EncoderParameters epParameters = new EncoderParameters(1);
            epParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, jpgQualityTrb.Value);
            InterpolationMode intMode = GetInterpolationMode();
            foreach (string filename in picturesLst.Items)
            {
                LoadResizeSaveTask lrsTask =
                    new LoadResizeSaveTask(
                    filename,
                    width,
                    height,
                    filenameExtTxt.Text,
                    new JpegImageSaver(epParameters),
                    new GraphicsResizer(intMode),
                    copyExifChb.Checked
                    );
                tasks.Add(lrsTask);
            }
            foreach (LoadResizeSaveTask task in tasks)
            {
                task.Start();
            }

            List<PictureResizeError> errors = new List<PictureResizeError>();
            foreach (LoadResizeSaveTask task in tasks)
            {
                PictureResizeError result = task.Result();
                if (result.Type != PictureResizeError.PRErrorType.None)
                {
                    errors.Add(result);
                }
            }

            if (errors.Count > 0)
            {
                IErrorsLanguage errorLanguage;
                if (language is MainFormLangGerman)
                    errorLanguage = new ErrorLangGerman();
                else
                    errorLanguage = new ErrorLangEnglish();
                ErrorForm errForm = new ErrorForm(errorLanguage, errors.ToArray());
                errForm.ShowDialog();
            }
            else
            {
                MessageBox.Show(language.PicturesResized);
            }
        }

        /// <summary>
        /// Gibt den in interpolationModeCmb ausgewählten InterpolationMode zurück
        /// </summary>
        /// <returns>Der in interpolationModeCmb ausgewählte InterpolationMode</returns>
        private InterpolationMode GetInterpolationMode()
        {
            if (interpolationModeCmb.SelectedText == language.Bicubic)
                return InterpolationMode.Bicubic;

            else if (interpolationModeCmb.SelectedText == language.HighQualityBicubic)
                return InterpolationMode.HighQualityBicubic;

            else if (interpolationModeCmb.SelectedText == language.Bilinear)
                return InterpolationMode.Bilinear;

            else if (interpolationModeCmb.SelectedText == language.HighQualityBilinear)
                return InterpolationMode.HighQualityBilinear;

            else if (interpolationModeCmb.SelectedText == language.NearestNeighbour)
                return InterpolationMode.NearestNeighbor;

            else
                return InterpolationMode.Default;
        }

        /// <summary>
        /// Fügt die Dateinamen in die Liste ein
        /// </summary>
        /// <param name="filenames">Die einzufügenden Dateinamen</param>
        private void loadPictureFilenames(string[] filenames)
        {
            foreach (string filename in filenames)
            {
                //Nur zur Liste hinzufügen, wenn der Eintrag noch nicht in der Liste ist
                if (!picturesLst.Items.Contains(filename))
                {
                    //Wenn einer der Dateinamen ein Verzeichniss ist, die Dateien in diesem Ordner hinzufügen
                    if (System.IO.Path.GetExtension(filename) == "")
                    {
                        picturesLst.Items.AddRange(DirectoryToIncludingFiles(filename));
                    }
                    else
                    {
                        picturesLst.Items.Add(filename);
                    }
                }
            }
        }

        /// <summary>
        /// Verwandelt einen Verzeichnisspfad in ein Array der Unterpfade
        /// </summary>
        /// <param name="directoryPath">Der Pfad des Verzeichnisses</param>
        /// <returns>Die Pfade der Dateien in dem Verzeichniss und seinen Unterverzeichnissen</returns>
        private string[] DirectoryToIncludingFiles(string directoryPath)
        {
            List<string> newList = new List<string>();
            if (Path.GetExtension(directoryPath) == "")
            {
                newList.AddRange(Directory.GetFiles(directoryPath));
                foreach (string directory in Directory.GetDirectories(directoryPath))
                {
                    newList.AddRange(DirectoryToIncludingFiles(directory));
                }
            }
            return newList.ToArray();
        }

        /// <summary>
        /// Beschriftet alle GUI Elemente mit den in language (IMainFormLanguage) definierten Strings
        /// </summary>
        private void LoadLanguageInGUI()
        {
            this.Text = Application.ProductName;
            loadPicturesBtn.Text = language.LoadImages;
            clearListBtn.Text = language.ClearList;
            widthLbl.Text = language.Width;
            heightLbl.Text = language.Height;
            filenameExtLbl.Text = language.FilenameExt;
            jpgQualityLbl.Text = language.JPGQuality;
            interpolationModeLbl.Text = language.InterpolationMode;
            deleteSelectedBtn.Text = language.DeleteSelected;
            languageLbl.Text = language.Language;
            copyExifChb.Text = language.CopyExif;

            int selectedIndex = interpolationModeCmb.SelectedIndex;
            interpolationModeCmb.Items.Clear();
            interpolationModeCmb.Items.Add(language.Bicubic);
            interpolationModeCmb.Items.Add(language.Bilinear);
            interpolationModeCmb.Items.Add(language.HighQualityBicubic);
            interpolationModeCmb.Items.Add(language.HighQualityBilinear);
            interpolationModeCmb.Items.Add(language.NearestNeighbour);
            interpolationModeCmb.SelectedIndex = selectedIndex;

            LoadHelpStrings();
        }


        /// <summary>
        /// Fügt die Namen der Sprachen in die Combobox ein
        /// </summary>
        private void EnterLanguagesInCombo()
        {
            languageCmb.Items.Clear();
            languageCmb.Items.Add("Deutsch");
            languageCmb.Items.Add("English");
        }

        /// <summary>
        /// Lädt die Hilfe-Texte für alle Steuerelemente in den HelpProvider
        /// </summary>
        private void LoadHelpStrings()
        {
            IHelpLanguage helpLanguage;
            if (language is MainFormLangGerman)
                helpLanguage = new HelpLanguageGerman();
            else
                helpLanguage = new HelpLanguageEnglish();

            helpProvider.SetHelpString(pinBtn, helpLanguage.Pin);
            helpProvider.SetHelpString(loadPicturesBtn, helpLanguage.LoadPictures);
            helpProvider.SetHelpString(deleteSelectedBtn, helpLanguage.Delete);
            helpProvider.SetHelpString(clearListBtn, helpLanguage.ClearList);
            helpProvider.SetHelpString(picturesLst, helpLanguage.picturesLst);
            helpProvider.SetHelpString(widthTxt, helpLanguage.Width);
            helpProvider.SetHelpString(heightTxt, helpLanguage.Height);
            helpProvider.SetHelpString(filenameExtTxt, helpLanguage.FilenameExt);
            helpProvider.SetHelpString(jpgQualityTrb, helpLanguage.JPGQuality);
            helpProvider.SetHelpString(interpolationModeCmb, helpLanguage.Interpolationmode);
            helpProvider.SetHelpString(goBtn, helpLanguage.Go);
            helpProvider.SetHelpString(copyExifChb, helpLanguage.CopyExif);
        }

        /// <summary>
        /// Lädt die in languageCmb ausgewählte Sprache
        /// </summary>
        private void SetSelectedLanguage()
        {
            switch (languageCmb.Text)
            {
                case "English":
                    language = new MainFormLangEnglish();
                    break;
                default:
                    language = new MainFormLangGerman();
                    break;
            }
            LoadLanguageInGUI();
            LoadHelpStrings();
        }

        private void SaveSettings()
        {
            MainSettings settings = new MainSettings();
            settings.Reload();

            int width;
            int.TryParse(widthTxt.Text, out width);
            settings.Width = width;

            int height;
            int.TryParse(heightTxt.Text, out height);
            settings.Height = height;

            settings.JpgQuality = jpgQualityTrb.Value;
            settings.filenameExt = filenameExtTxt.Text;

            settings.InterpolationmodeIndex = interpolationModeCmb.SelectedIndex;
            settings.Language = languageCmb.SelectedIndex;
            settings.copyExif = copyExifChb.Checked;

            settings.Save();
        }

        private void LoadSettings()
        {
            MainSettings settings = new MainSettings();
            settings.Reload();

            widthTxt.Text = settings.Width.ToString();
            heightTxt.Text = settings.Height.ToString();
            jpgQualityTrb.Value = settings.JpgQuality;
            filenameExtTxt.Text = settings.filenameExt;
            interpolationModeCmb.SelectedIndex = settings.InterpolationmodeIndex;
            languageCmb.SelectedIndex = settings.Language;
            copyExifChb.Checked = settings.copyExif;
        }

        private void pinBtn_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            if (this.TopMost == true)
            {
                pinBtn.BackColor = SystemColors.ControlDark;
            }
            else
            {
                pinBtn.BackColor = SystemColors.Control;
            }
        }
    }
}
