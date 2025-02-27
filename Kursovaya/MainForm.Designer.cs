namespace Kursovaya
{
    partial class MainForm
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
            MainMenuStrip = new MenuStrip();
            FileToolStripMenuItem1 = new ToolStripMenuItem();
            CreateToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            SaveAsToolStripMenuItem = new ToolStripMenuItem();
            CloseFileToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            CancelToolStripMenuItem = new ToolStripMenuItem();
            RepeatToolStripMenuItem = new ToolStripMenuItem();
            CutToolStripMenuItem = new ToolStripMenuItem();
            CopyToolStripMenuItem = new ToolStripMenuItem();
            PasteToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            SelectAllВсеToolStripMenuItem = new ToolStripMenuItem();
            TextToolStripMenuItem = new ToolStripMenuItem();
            StatementToolStripMenuItem = new ToolStripMenuItem();
            GrammarToolStripMenuItem = new ToolStripMenuItem();
            GrammarClassToolStripMenuItem = new ToolStripMenuItem();
            AnalysMethodToolStripMenuItem = new ToolStripMenuItem();
            DiagnosticToolStripMenuItem = new ToolStripMenuItem();
            TestToolStripMenuItem = new ToolStripMenuItem();
            ReferencesToolStripMenuItem = new ToolStripMenuItem();
            CodeToolStripMenuItem = new ToolStripMenuItem();
            StartToolStripMenuItem = new ToolStripMenuItem();
            HelpToolStripMenuItem = new ToolStripMenuItem();
            OpenHelpToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            HelpBtn = new Button();
            StartBtn = new Button();
            PasteBtn = new Button();
            CutBtn = new Button();
            CopyBtn = new Button();
            RepeatBtn = new Button();
            CancelBtn = new Button();
            SaveBtn = new Button();
            AboutBtn = new Button();
            OpenBtn = new Button();
            CreateBtn = new Button();
            panel2 = new Panel();
            TabControl = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            MainPanel = new Panel();
            EditRTB = new RichTextBox();
            NumbersBox = new ListBox();
            FinalRTB = new RichTextBox();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            MainMenuStrip.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.BackColor = SystemColors.Control;
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem1, EditToolStripMenuItem, TextToolStripMenuItem, StartToolStripMenuItem, HelpToolStripMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(784, 24);
            MainMenuStrip.TabIndex = 0;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem1
            // 
            FileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, SaveAsToolStripMenuItem, CloseFileToolStripMenuItem, ExitToolStripMenuItem });
            FileToolStripMenuItem1.Name = "FileToolStripMenuItem1";
            FileToolStripMenuItem1.Size = new Size(48, 20);
            FileToolStripMenuItem1.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            CreateToolStripMenuItem.Size = new Size(166, 22);
            CreateToolStripMenuItem.Text = "Создать";
            CreateToolStripMenuItem.Click += CreateToolStripMenuItem_Click;
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(166, 22);
            OpenToolStripMenuItem.Text = "Открыть";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(166, 22);
            SaveToolStripMenuItem.Text = "Сохранить";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // SaveAsToolStripMenuItem
            // 
            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            SaveAsToolStripMenuItem.Size = new Size(166, 22);
            SaveAsToolStripMenuItem.Text = "Сохранить как";
            SaveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // CloseFileToolStripMenuItem
            // 
            CloseFileToolStripMenuItem.Name = "CloseFileToolStripMenuItem";
            CloseFileToolStripMenuItem.Size = new Size(166, 22);
            CloseFileToolStripMenuItem.Text = "Закрыть вкладку";
            CloseFileToolStripMenuItem.Click += CloseFileToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(166, 22);
            ExitToolStripMenuItem.Text = "Выход";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CancelToolStripMenuItem, RepeatToolStripMenuItem, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, DeleteToolStripMenuItem, SelectAllВсеToolStripMenuItem });
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(59, 20);
            EditToolStripMenuItem.Text = "Правка";
            // 
            // CancelToolStripMenuItem
            // 
            CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            CancelToolStripMenuItem.Size = new Size(180, 22);
            CancelToolStripMenuItem.Text = "Отменить";
            CancelToolStripMenuItem.Click += CancelToolStripMenuItem_Click;
            // 
            // RepeatToolStripMenuItem
            // 
            RepeatToolStripMenuItem.Name = "RepeatToolStripMenuItem";
            RepeatToolStripMenuItem.Size = new Size(180, 22);
            RepeatToolStripMenuItem.Text = "Повторить";
            RepeatToolStripMenuItem.Click += RepeatToolStripMenuItem_Click;
            // 
            // CutToolStripMenuItem
            // 
            CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            CutToolStripMenuItem.Size = new Size(180, 22);
            CutToolStripMenuItem.Text = "Вырезать";
            CutToolStripMenuItem.Click += CutToolStripMenuItem_Click;
            // 
            // CopyToolStripMenuItem
            // 
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            CopyToolStripMenuItem.Size = new Size(180, 22);
            CopyToolStripMenuItem.Text = "Копировать";
            CopyToolStripMenuItem.Click += CopyToolStripMenuItem_Click;
            // 
            // PasteToolStripMenuItem
            // 
            PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            PasteToolStripMenuItem.Size = new Size(180, 22);
            PasteToolStripMenuItem.Text = "Вставить";
            PasteToolStripMenuItem.Click += PasteToolStripMenuItem_Click;
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(180, 22);
            DeleteToolStripMenuItem.Text = "Удалить";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // SelectAllВсеToolStripMenuItem
            // 
            SelectAllВсеToolStripMenuItem.Name = "SelectAllВсеToolStripMenuItem";
            SelectAllВсеToolStripMenuItem.Size = new Size(180, 22);
            SelectAllВсеToolStripMenuItem.Text = "Выделить все";
            SelectAllВсеToolStripMenuItem.Click += SelectAllВсеToolStripMenuItem_Click;
            // 
            // TextToolStripMenuItem
            // 
            TextToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { StatementToolStripMenuItem, GrammarToolStripMenuItem, GrammarClassToolStripMenuItem, AnalysMethodToolStripMenuItem, DiagnosticToolStripMenuItem, TestToolStripMenuItem, ReferencesToolStripMenuItem, CodeToolStripMenuItem });
            TextToolStripMenuItem.Name = "TextToolStripMenuItem";
            TextToolStripMenuItem.Size = new Size(48, 20);
            TextToolStripMenuItem.Text = "Текст";
            // 
            // StatementToolStripMenuItem
            // 
            StatementToolStripMenuItem.Name = "StatementToolStripMenuItem";
            StatementToolStripMenuItem.Size = new Size(288, 22);
            StatementToolStripMenuItem.Text = "Постановка задачи";
            // 
            // GrammarToolStripMenuItem
            // 
            GrammarToolStripMenuItem.Name = "GrammarToolStripMenuItem";
            GrammarToolStripMenuItem.Size = new Size(288, 22);
            GrammarToolStripMenuItem.Text = "Грамматика";
            // 
            // GrammarClassToolStripMenuItem
            // 
            GrammarClassToolStripMenuItem.Name = "GrammarClassToolStripMenuItem";
            GrammarClassToolStripMenuItem.Size = new Size(288, 22);
            GrammarClassToolStripMenuItem.Text = "Классификация грамматики";
            // 
            // AnalysMethodToolStripMenuItem
            // 
            AnalysMethodToolStripMenuItem.Name = "AnalysMethodToolStripMenuItem";
            AnalysMethodToolStripMenuItem.Size = new Size(288, 22);
            AnalysMethodToolStripMenuItem.Text = "Метод анализа";
            // 
            // DiagnosticToolStripMenuItem
            // 
            DiagnosticToolStripMenuItem.Name = "DiagnosticToolStripMenuItem";
            DiagnosticToolStripMenuItem.Size = new Size(288, 22);
            DiagnosticToolStripMenuItem.Text = "Диагностика и нейтрализация ошибок";
            // 
            // TestToolStripMenuItem
            // 
            TestToolStripMenuItem.Name = "TestToolStripMenuItem";
            TestToolStripMenuItem.Size = new Size(288, 22);
            TestToolStripMenuItem.Text = "Тестовый пример";
            // 
            // ReferencesToolStripMenuItem
            // 
            ReferencesToolStripMenuItem.Name = "ReferencesToolStripMenuItem";
            ReferencesToolStripMenuItem.Size = new Size(288, 22);
            ReferencesToolStripMenuItem.Text = "Список литературы";
            // 
            // CodeToolStripMenuItem
            // 
            CodeToolStripMenuItem.Name = "CodeToolStripMenuItem";
            CodeToolStripMenuItem.Size = new Size(288, 22);
            CodeToolStripMenuItem.Text = "Исходный код программы";
            // 
            // StartToolStripMenuItem
            // 
            StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            StartToolStripMenuItem.Size = new Size(46, 20);
            StartToolStripMenuItem.Text = "Пуск";
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenHelpToolStripMenuItem, AboutToolStripMenuItem });
            HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            HelpToolStripMenuItem.Size = new Size(65, 20);
            HelpToolStripMenuItem.Text = "Справка";
            // 
            // OpenHelpToolStripMenuItem
            // 
            OpenHelpToolStripMenuItem.Name = "OpenHelpToolStripMenuItem";
            OpenHelpToolStripMenuItem.Size = new Size(156, 22);
            OpenHelpToolStripMenuItem.Text = "Вызов справки";
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(156, 22);
            AboutToolStripMenuItem.Text = "О программе";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(HelpBtn);
            panel1.Controls.Add(StartBtn);
            panel1.Controls.Add(PasteBtn);
            panel1.Controls.Add(CutBtn);
            panel1.Controls.Add(CopyBtn);
            panel1.Controls.Add(RepeatBtn);
            panel1.Controls.Add(CancelBtn);
            panel1.Controls.Add(SaveBtn);
            panel1.Controls.Add(AboutBtn);
            panel1.Controls.Add(OpenBtn);
            panel1.Controls.Add(CreateBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 55);
            panel1.TabIndex = 1;
            // 
            // HelpBtn
            // 
            HelpBtn.BackgroundImage = Properties.Resources.icons8_help1;
            HelpBtn.BackgroundImageLayout = ImageLayout.Stretch;
            HelpBtn.Location = new Point(516, 3);
            HelpBtn.Name = "HelpBtn";
            HelpBtn.Size = new Size(50, 50);
            HelpBtn.TabIndex = 10;
            HelpBtn.UseVisualStyleBackColor = true;
            // 
            // StartBtn
            // 
            StartBtn.BackgroundImage = Properties.Resources.icons8_start_100;
            StartBtn.BackgroundImageLayout = ImageLayout.Stretch;
            StartBtn.Location = new Point(460, 3);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(50, 50);
            StartBtn.TabIndex = 9;
            StartBtn.UseVisualStyleBackColor = true;
            // 
            // PasteBtn
            // 
            PasteBtn.BackgroundImage = Properties.Resources.icons8_paste_100;
            PasteBtn.BackgroundImageLayout = ImageLayout.Stretch;
            PasteBtn.Location = new Point(404, 3);
            PasteBtn.Name = "PasteBtn";
            PasteBtn.Size = new Size(50, 50);
            PasteBtn.TabIndex = 8;
            PasteBtn.UseVisualStyleBackColor = true;
            // 
            // CutBtn
            // 
            CutBtn.BackgroundImage = Properties.Resources.icons8_cut_100;
            CutBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CutBtn.Location = new Point(348, 3);
            CutBtn.Name = "CutBtn";
            CutBtn.Size = new Size(50, 50);
            CutBtn.TabIndex = 7;
            CutBtn.UseVisualStyleBackColor = true;
            // 
            // CopyBtn
            // 
            CopyBtn.BackgroundImage = Properties.Resources.icons8_copy_100;
            CopyBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CopyBtn.Location = new Point(292, 3);
            CopyBtn.Name = "CopyBtn";
            CopyBtn.Size = new Size(50, 50);
            CopyBtn.TabIndex = 6;
            CopyBtn.UseVisualStyleBackColor = true;
            // 
            // RepeatBtn
            // 
            RepeatBtn.BackgroundImage = Properties.Resources.icons8_redo_96;
            RepeatBtn.BackgroundImageLayout = ImageLayout.Stretch;
            RepeatBtn.Location = new Point(236, 3);
            RepeatBtn.Name = "RepeatBtn";
            RepeatBtn.Size = new Size(50, 50);
            RepeatBtn.TabIndex = 5;
            RepeatBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            CancelBtn.BackgroundImage = Properties.Resources.icons8_undo_96;
            CancelBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CancelBtn.Location = new Point(180, 3);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(50, 50);
            CancelBtn.TabIndex = 4;
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            SaveBtn.BackgroundImage = Properties.Resources.icons8_save_100;
            SaveBtn.BackgroundImageLayout = ImageLayout.Stretch;
            SaveBtn.Location = new Point(124, 3);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(50, 50);
            SaveBtn.TabIndex = 3;
            SaveBtn.UseVisualStyleBackColor = true;
            // 
            // AboutBtn
            // 
            AboutBtn.BackgroundImage = Properties.Resources.icons8_info;
            AboutBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AboutBtn.Location = new Point(572, 3);
            AboutBtn.Name = "AboutBtn";
            AboutBtn.Size = new Size(50, 50);
            AboutBtn.TabIndex = 2;
            AboutBtn.UseVisualStyleBackColor = true;
            // 
            // OpenBtn
            // 
            OpenBtn.BackgroundImage = Properties.Resources.icons8_opened_folder;
            OpenBtn.BackgroundImageLayout = ImageLayout.Stretch;
            OpenBtn.Location = new Point(68, 3);
            OpenBtn.Name = "OpenBtn";
            OpenBtn.Size = new Size(50, 50);
            OpenBtn.TabIndex = 1;
            OpenBtn.UseVisualStyleBackColor = true;
            // 
            // CreateBtn
            // 
            CreateBtn.BackgroundImage = Properties.Resources.icons8_add_file_100;
            CreateBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CreateBtn.Location = new Point(12, 3);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(50, 50);
            CreateBtn.TabIndex = 0;
            CreateBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            CreateBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(TabControl);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 482);
            panel2.TabIndex = 2;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Dock = DockStyle.Fill;
            TabControl.ItemSize = new Size(140, 30);
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(784, 482);
            TabControl.SizeMode = TabSizeMode.Fixed;
            TabControl.TabIndex = 6;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(776, 444);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Новый документ *";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(MainPanel);
            splitContainer1.Panel1MinSize = 195;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(FinalRTB);
            splitContainer1.Panel2MinSize = 180;
            splitContainer1.Size = new Size(770, 438);
            splitContainer1.SplitterDistance = 195;
            splitContainer1.SplitterWidth = 30;
            splitContainer1.TabIndex = 6;
            splitContainer1.TabStop = false;
            // 
            // MainPanel
            // 
            MainPanel.AutoSize = true;
            MainPanel.Controls.Add(EditRTB);
            MainPanel.Controls.Add(NumbersBox);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.MinimumSize = new Size(770, 195);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(770, 195);
            MainPanel.TabIndex = 5;
            // 
            // EditRTB
            // 
            EditRTB.AcceptsTab = true;
            EditRTB.Dock = DockStyle.Fill;
            EditRTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditRTB.Location = new Point(60, 0);
            EditRTB.Name = "EditRTB";
            EditRTB.ScrollBars = RichTextBoxScrollBars.Vertical;
            EditRTB.Size = new Size(710, 195);
            EditRTB.TabIndex = 3;
            EditRTB.Text = "";
            EditRTB.WordWrap = false;
            EditRTB.TextChanged += EditRTB_TextChanged;
            // 
            // NumbersBox
            // 
            NumbersBox.Dock = DockStyle.Left;
            NumbersBox.FormattingEnabled = true;
            NumbersBox.ItemHeight = 21;
            NumbersBox.Location = new Point(0, 0);
            NumbersBox.MinimumSize = new Size(60, 195);
            NumbersBox.Name = "NumbersBox";
            NumbersBox.Size = new Size(60, 195);
            NumbersBox.TabIndex = 4;
            NumbersBox.SelectedIndexChanged += NumbersBox_SelectedIndexChanged;
            // 
            // FinalRTB
            // 
            FinalRTB.Dock = DockStyle.Fill;
            FinalRTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FinalRTB.Location = new Point(0, 0);
            FinalRTB.Name = "FinalRTB";
            FinalRTB.ReadOnly = true;
            FinalRTB.Size = new Size(770, 213);
            FinalRTB.TabIndex = 4;
            FinalRTB.Text = "";
            FinalRTB.WordWrap = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(MainMenuStrip);
            MinimumSize = new Size(800, 600);
            Name = "MainForm";
            Text = "Compiler";
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenuStrip;
        private Panel panel1;
        private Panel panel2;
        private RichTextBox FinalRTB;
        private RichTextBox EditRTB;
        private ToolStripMenuItem FileToolStripMenuItem1;
        private ToolStripMenuItem CreateToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem SaveAsToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem CancelToolStripMenuItem;
        private ToolStripMenuItem RepeatToolStripMenuItem;
        private ToolStripMenuItem CutToolStripMenuItem;
        private ToolStripMenuItem CopyToolStripMenuItem;
        private ToolStripMenuItem PasteToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripMenuItem SelectAllВсеToolStripMenuItem;
        private ToolStripMenuItem TextToolStripMenuItem;
        private ToolStripMenuItem StatementToolStripMenuItem;
        private ToolStripMenuItem GrammarToolStripMenuItem;
        private ToolStripMenuItem GrammarClassToolStripMenuItem;
        private ToolStripMenuItem AnalysMethodToolStripMenuItem;
        private ToolStripMenuItem DiagnosticToolStripMenuItem;
        private ToolStripMenuItem TestToolStripMenuItem;
        private ToolStripMenuItem ReferencesToolStripMenuItem;
        private ToolStripMenuItem CodeToolStripMenuItem;
        private ToolStripMenuItem StartToolStripMenuItem;
        private ToolStripMenuItem HelpToolStripMenuItem;
        private ToolStripMenuItem OpenHelpToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private Button CreateBtn;
        private Button HelpBtn;
        private Button StartBtn;
        private Button PasteBtn;
        private Button CutBtn;
        private Button CopyBtn;
        private Button RepeatBtn;
        private Button CancelBtn;
        private Button SaveBtn;
        private Button AboutBtn;
        private Button OpenBtn;
        private Panel MainPanel;
        private TabControl TabControl;
        private TabPage tabPage1;
        private ListBox NumbersBox;
        private SplitContainer splitContainer1;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private ToolStripMenuItem CloseFileToolStripMenuItem;
    }
}
