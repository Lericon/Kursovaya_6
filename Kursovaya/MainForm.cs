using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Kursovaya.Properties;
using System.Reflection.Metadata;
using System;
using System.Xml.Linq;
using System.Resources;
using System.Globalization;

namespace Kursovaya
{
    public partial class MainForm : Form
    {
        private string newFileName = "Новый документ *";
        private bool currentLanguage = false;
        public List<File> files;
        private bool anotherFile;
        int index = 0;
        private enum LastActionType { None, Insert, Backspace, Paste }
        private LastActionType lastAction = LastActionType.None;
        private string lastText = "";
        private int lastCursorPos = 0;
        public MainForm()
        {
            InitializeComponent();
            SetupNumericPanel();
            files = new List<File>();
            File file = new File("Новый документ", "", "", "", false, false);
            TabControl.TabPages[TabControl.SelectedIndex].Text = file.filename + " *";
            this.files.Add(file);

            saveFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";

            CreateBtn.Click += CreateToolStripMenuItem_Click!;
            OpenBtn.Click += OpenToolStripMenuItem_Click!;
            SaveBtn.Click += SaveToolStripMenuItem_Click!;
            CancelBtn.Click += CancelToolStripMenuItem_Click!;
            RepeatBtn.Click += RepeatToolStripMenuItem_Click!;
            CutBtn.Click += CutToolStripMenuItem_Click!;
            CopyBtn.Click += CopyToolStripMenuItem_Click!;
            PasteBtn.Click += PasteToolStripMenuItem_Click!;
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File file = new File(newFileName, null, null, null, false, false);
            this.files.Add(file);

            AddNewTabPage(file.filename);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string path = openFileDialog.FileName;

            File file = File.OpenFile(path);
            files.Add(file);

            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].path == path)
                {
                    TabControl.SelectedIndex = i;
                    AddNewTabPage(files[i].filename);
                    return;
                }
            }
            MessageBox.Show("Файл успешно открыт!");
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File currentFile = files[TabControl.SelectedIndex];
            SaveFile(currentFile);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File currentFile = files[TabControl.SelectedIndex];
            SaveFileAs(currentFile);
        }

        private void SaveFile(File file)
        {
            if (!string.IsNullOrEmpty(file.path))
            {
                SaveToFile(file.path, EditRTB.Text);
                TabControl.TabPages[TabControl.SelectedIndex].Text = file.filename;
            }
            else
            {
                SaveFileAs(file);
            }
        }

        private void SaveToFile(string path, string text)
        {
            System.IO.File.WriteAllText(path, text);
            files[TabControl.SelectedIndex].file_saved = true;
        }

        private void SaveFileAs(File file)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string path = saveFileDialog.FileName;
            string filename = Path.GetFileName(path);

            file.path = path;
            file.filename = filename;

            TabControl.TabPages[TabControl.SelectedIndex].Text = filename;

            SaveToFile(path, EditRTB.Text);
            file.file_saved = true;
            file.file_saved_as = true;

            MessageBox.Show("Файл успешно сохранён!");
        }

        private void AddNewTabPage(string filename)
        {
            TabPage newTab = new TabPage(filename);
            newTab.Controls.Add(this.splitContainer1);
            TabControl.TabPages.Add(newTab);
            splitContainer1.SplitterDistance = TabControl.Height / 2;

            TabControl.SelectedTab = newTab;
        }

        private void SetupNumericPanel()
        {
            NumbersBox.DrawMode = DrawMode.OwnerDrawFixed;
            NumbersBox.IntegralHeight = false;
            NumbersBox.ScrollAlwaysVisible = false;
            NumbersBox.MouseWheel += (s, e) => ((HandledMouseEventArgs)e).Handled = true;
            NumbersBox.Font = new Font("Segou UI", 12);
            EditRTB.VScroll += (s, e) => SyncScroll();
            EditRTB.TextChanged += (s, e) => UpdateLineNumbers();
            EditRTB.Resize += (s, e) => UpdateLineNumbers();
            NumbersBox.DrawItem += NumbersBox_DrawItem;
            UpdateLineNumbers();
        }

        private void UpdateLineNumbers()
        {
            int lineCount = EditRTB.Lines.Length;
            int visibleLines = EditRTB.Height / EditRTB.Font.Height;

            NumbersBox.BeginUpdate();
            NumbersBox.Items.Clear();

            for (int i = 1; i <= lineCount; i++)
            {
                NumbersBox.Items.Add(i.ToString());
            }

            NumbersBox.EndUpdate();
            SyncScroll();
        }

        private void SyncScroll()
        {
            if (NumbersBox.Items.Count == 0) return;

            int firstCharIndex = EditRTB.GetCharIndexFromPosition(new Point(0, 3));
            int firstVisibleLine = EditRTB.GetLineFromCharIndex(firstCharIndex);

            if (firstVisibleLine < NumbersBox.Items.Count)
            {
                NumbersBox.TopIndex = firstVisibleLine;
            }
        }

        private void NumbersBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                e.Graphics.DrawString(
                    NumbersBox.Items[e.Index].ToString(),
                    NumbersBox.Font,
                    Brushes.Black,
                    e.Bounds.Location
                );
            }
            e.DrawFocusRectangle();
        }

        private void EditRTB_TextChanged(object sender, EventArgs e)
        {
            int index = TabControl.SelectedIndex;

            if (anotherFile == true)
            {
                anotherFile = false;
                return;
            }
            if (index >= 0)
            {
                if (files[index].file_saved == true)
                {
                    files[index].file_saved = false;
                    TabControl.TabPages[TabControl.SelectedIndex].Text = files[TabControl.SelectedIndex].filename + " *";
                }
            }
            lastCursorPos = EditRTB.SelectionStart;
            if (
                EditRTB.SelectionLength == 0 &&
                EditRTB.Text.Length > lastText.Length &&
                lastCursorPos > 0 &&
                lastAction != LastActionType.Backspace &&
                lastAction != LastActionType.Paste
                )
            {
                lastAction = LastActionType.Insert;
                lastText = EditRTB.Text.Substring(lastCursorPos - 1, 1);
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            File file = new File(newFileName, null, EditRTB.Text, null, false, false);

            TabControl.TabPages[TabControl.SelectedIndex].Controls.Add(this.splitContainer1);

            files[this.index].EditText = EditRTB.Text;
            files[this.index].FinalText = FinalRTB.Text;

            anotherFile = true;
            EditRTB.Text = files[TabControl.SelectedIndex].EditText;

            this.index = TabControl.SelectedIndex;
        }

        private void NumbersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NumbersBox.SelectedIndex != -1)
            {
                int selectedLine = NumbersBox.SelectedIndex;

                int charIndex = EditRTB.GetFirstCharIndexFromLine(selectedLine);

                int lineLength = EditRTB.Lines[selectedLine].Length;
                EditRTB.Select(charIndex, lineLength);
                EditRTB.Focus();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var file in files)
            {
                if (!file.file_saved)
                {
                    DialogResult result = MessageBox.Show(
                        $"Сохранить файл \"{file.filename}\"?",
                        "Сохранение файла",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question
                    );
                    if (result == DialogResult.Yes)
                    {
                        SaveFile(file);
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }
            this.Close();
        }

        private void CloseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File currentFile = files[TabControl.SelectedIndex];
            CloseFile(currentFile);
        }

        private void CloseFile(File file)
        {
            if (!file.file_saved)
            {
                DialogResult result = MessageBox.Show(
                    $"Сохранить файл \"{file.filename}\"?",
                    "Сохранение файла",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.Yes)
                {
                    SaveFile(file);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (TabControl.TabPages.Count == 1)
            {
                files[0].file_saved = true;
                this.Close();
            }
            else
            {
                int newIndex = (TabControl.SelectedIndex == 0) ? 1 : TabControl.SelectedIndex - 1;

                files.RemoveAt(index - 1);
                TabControl.TabPages.RemoveAt(index - 1);

                TabControl.SelectedIndex = Math.Max(0, newIndex);
            }
            this.index = TabControl.SelectedIndex;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            File currentFile = files[TabControl.SelectedIndex];
            if (keyData == (Keys.Control | Keys.S))
            {
                SaveFile(currentFile);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.O))
            {
                OpenFile();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.N))
            {
                File file = new File(newFileName, null, null, null, false, false);
                this.files.Add(file);

                AddNewTabPage(file.filename);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.W))
            {
                CloseFile(currentFile);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.V))
            {
                PasteFunction();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.C))
            {
                EditRTB.Copy();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Z))
            {
                UndoFunction();
                return true;
            }
            else if (keyData == (Keys.Back))
            {
                lastAction = LastActionType.Backspace;
                if (EditRTB.Text.Length > 0)
                {
                    if (EditRTB.SelectionLength > 0)
                    {
                        EditRTB.SelectedText = "";
                    }
                    else if (EditRTB.SelectionLength == 0)
                    {
                        EditRTB.SelectionStart--;
                        EditRTB.SelectionLength = 1;
                        EditRTB.SelectedText = "";
                    }
                }
                return true;
            }
            else
            {
                lastAction = LastActionType.Insert;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SelectAllВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRTB.SelectAll();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFunction();
        }

        private void DeleteFunction()
        {
            if (EditRTB.Text.Length > 0)
            {
                lastAction = LastActionType.Backspace;
                lastText = EditRTB.SelectedText;
                EditRTB.SelectedText = "";
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteFunction();
        }

        private void PasteFunction()
        {
            if (Clipboard.ContainsText())
            {
                lastAction = LastActionType.Paste;
                lastText = Clipboard.GetText();
                EditRTB.Paste();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRTB.Copy();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRTB.Cut();
        }

        private void RepeatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (lastAction)
            {
                case LastActionType.Insert:
                    int pos = EditRTB.SelectionStart;
                    EditRTB.SelectedText = lastText;
                    EditRTB.SelectionStart = pos + lastText.Length;
                    break;

                case LastActionType.Backspace:
                    if (EditRTB.Text.Length > 0)
                    {
                        EditRTB.SelectionStart--;
                        EditRTB.SelectionLength = 1;
                        EditRTB.SelectedText = "";
                    }
                    break;

                case LastActionType.Paste:
                    EditRTB.Paste();
                    break;
            }
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoFunction();
        }

        private void UndoFunction()
        {
            if (EditRTB.CanUndo)
            {
                EditRTB.Undo();
            }
        }

        private void UpdateControlsText(Control control, ResourceManager res)
        {
            LanguageBtn.Text = res.GetString("LanguageBtn");
            newFileName = res.GetString("newFileName");

            foreach (var item in this.MainMenuStrip.Items)
            {
                if (item is ToolStripMenuItem menuItem)
                {
                    UpdateMenuItems(menuItem, res);
                }
            }
        }
        private void UpdateMenuItems(ToolStripMenuItem menuItem, ResourceManager res)
        {
            if (!string.IsNullOrEmpty(menuItem.Name))
            {
                string newText = res.GetString(menuItem.Name);
                if (!string.IsNullOrEmpty(newText))
                    menuItem.Text = newText;
            }


            foreach (ToolStripItem subItem in menuItem.DropDownItems)
            {
                if (subItem is ToolStripMenuItem subMenuItem)
                {
                    UpdateMenuItems(subMenuItem, res);
                }
            }
        }

        private void LanguageBtn_Click(object sender, EventArgs e)
        {
            if (currentLanguage)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
                ResourceManager res = new ResourceManager("Kursovaya.Properties.Resources_ru", typeof(MainForm).Assembly);
                UpdateControlsText(this, res);
                currentLanguage = false;
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                ResourceManager res = new ResourceManager("Kursovaya.Properties.Resources_en", typeof(MainForm).Assembly);
                UpdateControlsText(this, res);
                currentLanguage = true;
            }
        }
    }
}
