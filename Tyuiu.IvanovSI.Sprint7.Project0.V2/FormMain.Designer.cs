
namespace Tyuiu.IvanovSI.Sprint7.Project0.V2
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog_ISI = new System.Windows.Forms.OpenFileDialog();
            this.panelFunctions_ISI = new System.Windows.Forms.Panel();
            this.groupBoxSearch_ISI = new System.Windows.Forms.GroupBox();
            this.textBoxSearch_ISI = new System.Windows.Forms.TextBox();
            this.buttonStat_ISI = new System.Windows.Forms.Button();
            this.buttonSave_ISI = new System.Windows.Forms.Button();
            this.panelGrid_ISI = new System.Windows.Forms.Panel();
            this.groupBoxGrid_ISI = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_ISI = new System.Windows.Forms.DataGridView();
            this.saveFileDialog_ISI = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip_ISI = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ценаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.адресМагазинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аЯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фИОПоставщикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аЯToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.яАToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroToolTip_ISI = new MetroFramework.Components.MetroToolTip();
            this.buttonAdd_ISI = new System.Windows.Forms.Button();
            this.buttonSort_ISI = new System.Windows.Forms.Button();
            this.buttonOpenFile_ISI = new System.Windows.Forms.Button();
            this.buttonAboutProg_ISI = new System.Windows.Forms.Button();
            this.buttonHelp_ISI = new System.Windows.Forms.Button();
            this.panelFunctions_ISI.SuspendLayout();
            this.groupBoxSearch_ISI.SuspendLayout();
            this.panelGrid_ISI.SuspendLayout();
            this.groupBoxGrid_ISI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_ISI)).BeginInit();
            this.contextMenuStrip_ISI.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_ISI
            // 
            this.openFileDialog_ISI.FileName = "openFileDialog1";
            // 
            // panelFunctions_ISI
            // 
            this.panelFunctions_ISI.Controls.Add(this.buttonAdd_ISI);
            this.panelFunctions_ISI.Controls.Add(this.groupBoxSearch_ISI);
            this.panelFunctions_ISI.Controls.Add(this.buttonStat_ISI);
            this.panelFunctions_ISI.Controls.Add(this.buttonSort_ISI);
            this.panelFunctions_ISI.Controls.Add(this.buttonOpenFile_ISI);
            this.panelFunctions_ISI.Controls.Add(this.buttonAboutProg_ISI);
            this.panelFunctions_ISI.Controls.Add(this.buttonHelp_ISI);
            this.panelFunctions_ISI.Controls.Add(this.buttonSave_ISI);
            this.panelFunctions_ISI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFunctions_ISI.Location = new System.Drawing.Point(20, 60);
            this.panelFunctions_ISI.Name = "panelFunctions_ISI";
            this.panelFunctions_ISI.Size = new System.Drawing.Size(894, 68);
            this.panelFunctions_ISI.TabIndex = 3;
            // 
            // groupBoxSearch_ISI
            // 
            this.groupBoxSearch_ISI.Controls.Add(this.textBoxSearch_ISI);
            this.groupBoxSearch_ISI.Location = new System.Drawing.Point(307, 3);
            this.groupBoxSearch_ISI.Name = "groupBoxSearch_ISI";
            this.groupBoxSearch_ISI.Size = new System.Drawing.Size(187, 46);
            this.groupBoxSearch_ISI.TabIndex = 5;
            this.groupBoxSearch_ISI.TabStop = false;
            this.groupBoxSearch_ISI.Text = "Поиск";
            // 
            // textBoxSearch_ISI
            // 
            this.textBoxSearch_ISI.Location = new System.Drawing.Point(6, 19);
            this.textBoxSearch_ISI.Name = "textBoxSearch_ISI";
            this.textBoxSearch_ISI.Size = new System.Drawing.Size(175, 20);
            this.textBoxSearch_ISI.TabIndex = 4;
            this.textBoxSearch_ISI.TextChanged += new System.EventHandler(this.textBoxSearch_ISI_TextChanged);
            // 
            // buttonStat_ISI
            // 
            this.buttonStat_ISI.Location = new System.Drawing.Point(665, 3);
            this.buttonStat_ISI.Name = "buttonStat_ISI";
            this.buttonStat_ISI.Size = new System.Drawing.Size(116, 35);
            this.buttonStat_ISI.TabIndex = 3;
            this.buttonStat_ISI.Text = "Статистика";
            this.metroToolTip_ISI.SetToolTip(this.buttonStat_ISI, "Выводит элементы статистики таблицы");
            this.buttonStat_ISI.UseVisualStyleBackColor = true;
            this.buttonStat_ISI.Click += new System.EventHandler(this.buttonStat_ISI_Click);
            // 
            // buttonSave_ISI
            // 
            this.buttonSave_ISI.Location = new System.Drawing.Point(543, 3);
            this.buttonSave_ISI.Name = "buttonSave_ISI";
            this.buttonSave_ISI.Size = new System.Drawing.Size(116, 35);
            this.buttonSave_ISI.TabIndex = 2;
            this.buttonSave_ISI.Text = "Сохранить ";
            this.metroToolTip_ISI.SetToolTip(this.buttonSave_ISI, "Сохранить файл в формате CSV");
            this.buttonSave_ISI.UseVisualStyleBackColor = true;
            this.buttonSave_ISI.Click += new System.EventHandler(this.buttonSave_ISI_Click);
            // 
            // panelGrid_ISI
            // 
            this.panelGrid_ISI.Controls.Add(this.groupBoxGrid_ISI);
            this.panelGrid_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid_ISI.Location = new System.Drawing.Point(20, 128);
            this.panelGrid_ISI.Name = "panelGrid_ISI";
            this.panelGrid_ISI.Padding = new System.Windows.Forms.Padding(5);
            this.panelGrid_ISI.Size = new System.Drawing.Size(894, 484);
            this.panelGrid_ISI.TabIndex = 4;
            // 
            // groupBoxGrid_ISI
            // 
            this.groupBoxGrid_ISI.Controls.Add(this.dataGridViewIn_ISI);
            this.groupBoxGrid_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGrid_ISI.Location = new System.Drawing.Point(5, 5);
            this.groupBoxGrid_ISI.Name = "groupBoxGrid_ISI";
            this.groupBoxGrid_ISI.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxGrid_ISI.Size = new System.Drawing.Size(884, 474);
            this.groupBoxGrid_ISI.TabIndex = 0;
            this.groupBoxGrid_ISI.TabStop = false;
            this.groupBoxGrid_ISI.Text = "База данных";
            // 
            // dataGridViewIn_ISI
            // 
            this.dataGridViewIn_ISI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_ISI.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewIn_ISI.Name = "dataGridViewIn_ISI";
            this.dataGridViewIn_ISI.Size = new System.Drawing.Size(874, 451);
            this.dataGridViewIn_ISI.TabIndex = 0;
            // 
            // contextMenuStrip_ISI
            // 
            this.contextMenuStrip_ISI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ценаToolStripMenuItem,
            this.номерToolStripMenuItem,
            this.адресМагазинаToolStripMenuItem,
            this.фИОПоставщикаToolStripMenuItem});
            this.contextMenuStrip_ISI.Name = "contextMenuStrip_ISI";
            this.contextMenuStrip_ISI.Size = new System.Drawing.Size(181, 92);
            // 
            // ценаToolStripMenuItem
            // 
            this.ценаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВозрастаниюToolStripMenuItem,
            this.поУбываниюToolStripMenuItem});
            this.ценаToolStripMenuItem.Name = "ценаToolStripMenuItem";
            this.ценаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ценаToolStripMenuItem.Text = "Цена";
            // 
            // поВозрастаниюToolStripMenuItem
            // 
            this.поВозрастаниюToolStripMenuItem.Name = "поВозрастаниюToolStripMenuItem";
            this.поВозрастаниюToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.поВозрастаниюToolStripMenuItem.Text = "По возрастанию";
            this.поВозрастаниюToolStripMenuItem.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem_Click);
            // 
            // поУбываниюToolStripMenuItem
            // 
            this.поУбываниюToolStripMenuItem.Name = "поУбываниюToolStripMenuItem";
            this.поУбываниюToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.поУбываниюToolStripMenuItem.Text = "По убыванию";
            this.поУбываниюToolStripMenuItem.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem_Click);
            // 
            // номерToolStripMenuItem
            // 
            this.номерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВозрастаниюToolStripMenuItem1,
            this.поУбываниюToolStripMenuItem1});
            this.номерToolStripMenuItem.Name = "номерToolStripMenuItem";
            this.номерToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.номерToolStripMenuItem.Text = "Номер";
            // 
            // поВозрастаниюToolStripMenuItem1
            // 
            this.поВозрастаниюToolStripMenuItem1.Name = "поВозрастаниюToolStripMenuItem1";
            this.поВозрастаниюToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.поВозрастаниюToolStripMenuItem1.Text = "По возрастанию";
            this.поВозрастаниюToolStripMenuItem1.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem1_Click);
            // 
            // поУбываниюToolStripMenuItem1
            // 
            this.поУбываниюToolStripMenuItem1.Name = "поУбываниюToolStripMenuItem1";
            this.поУбываниюToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.поУбываниюToolStripMenuItem1.Text = "По убыванию";
            this.поУбываниюToolStripMenuItem1.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem1_Click);
            // 
            // адресМагазинаToolStripMenuItem
            // 
            this.адресМагазинаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аЯToolStripMenuItem,
            this.яАToolStripMenuItem});
            this.адресМагазинаToolStripMenuItem.Name = "адресМагазинаToolStripMenuItem";
            this.адресМагазинаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.адресМагазинаToolStripMenuItem.Text = "Название магазина";
            // 
            // аЯToolStripMenuItem
            // 
            this.аЯToolStripMenuItem.Name = "аЯToolStripMenuItem";
            this.аЯToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.аЯToolStripMenuItem.Text = "А-Я";
            this.аЯToolStripMenuItem.Click += new System.EventHandler(this.аЯToolStripMenuItem_Click);
            // 
            // яАToolStripMenuItem
            // 
            this.яАToolStripMenuItem.Name = "яАToolStripMenuItem";
            this.яАToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.яАToolStripMenuItem.Text = "Я-А";
            this.яАToolStripMenuItem.Click += new System.EventHandler(this.яАToolStripMenuItem_Click);
            // 
            // фИОПоставщикаToolStripMenuItem
            // 
            this.фИОПоставщикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аЯToolStripMenuItem1,
            this.яАToolStripMenuItem1});
            this.фИОПоставщикаToolStripMenuItem.Name = "фИОПоставщикаToolStripMenuItem";
            this.фИОПоставщикаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фИОПоставщикаToolStripMenuItem.Text = "ФИО поставщика";
            // 
            // аЯToolStripMenuItem1
            // 
            this.аЯToolStripMenuItem1.Name = "аЯToolStripMenuItem1";
            this.аЯToolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.аЯToolStripMenuItem1.Text = "А-Я";
            this.аЯToolStripMenuItem1.Click += new System.EventHandler(this.аЯToolStripMenuItem1_Click);
            // 
            // яАToolStripMenuItem1
            // 
            this.яАToolStripMenuItem1.Name = "яАToolStripMenuItem1";
            this.яАToolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.яАToolStripMenuItem1.Text = "Я-А";
            this.яАToolStripMenuItem1.Click += new System.EventHandler(this.яАToolStripMenuItem1_Click);
            // 
            // metroToolTip_ISI
            // 
            this.metroToolTip_ISI.Style = MetroFramework.MetroColorStyle.White;
            this.metroToolTip_ISI.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // buttonAdd_ISI
            // 
            this.buttonAdd_ISI.Image = global::Tyuiu.IvanovSI.Sprint7.Project0.V2.Properties.Resources.application_form_add1;
            this.buttonAdd_ISI.Location = new System.Drawing.Point(157, 3);
            this.buttonAdd_ISI.Name = "buttonAdd_ISI";
            this.buttonAdd_ISI.Size = new System.Drawing.Size(49, 46);
            this.buttonAdd_ISI.TabIndex = 6;
            this.metroToolTip_ISI.SetToolTip(this.buttonAdd_ISI, "Добавление новых данных в таблицу");
            this.buttonAdd_ISI.UseVisualStyleBackColor = true;
            this.buttonAdd_ISI.Click += new System.EventHandler(this.buttonAdd_ISI_Click);
            // 
            // buttonSort_ISI
            // 
            this.buttonSort_ISI.Image = global::Tyuiu.IvanovSI.Sprint7.Project0.V2.Properties.Resources.table_sort;
            this.buttonSort_ISI.Location = new System.Drawing.Point(102, 3);
            this.buttonSort_ISI.Name = "buttonSort_ISI";
            this.buttonSort_ISI.Size = new System.Drawing.Size(49, 46);
            this.buttonSort_ISI.TabIndex = 2;
            this.metroToolTip_ISI.SetToolTip(this.buttonSort_ISI, "Сортировка по столбцам таблицы");
            this.buttonSort_ISI.UseVisualStyleBackColor = true;
            this.buttonSort_ISI.Click += new System.EventHandler(this.buttonSort_ISI_Click);
            // 
            // buttonOpenFile_ISI
            // 
            this.buttonOpenFile_ISI.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonOpenFile_ISI.Image = global::Tyuiu.IvanovSI.Sprint7.Project0.V2.Properties.Resources.application_add;
            this.buttonOpenFile_ISI.Location = new System.Drawing.Point(5, 3);
            this.buttonOpenFile_ISI.Name = "buttonOpenFile_ISI";
            this.buttonOpenFile_ISI.Size = new System.Drawing.Size(49, 46);
            this.buttonOpenFile_ISI.TabIndex = 2;
            this.metroToolTip_ISI.SetToolTip(this.buttonOpenFile_ISI, "Открывает файл формата CSV");
            this.buttonOpenFile_ISI.UseVisualStyleBackColor = false;
            this.buttonOpenFile_ISI.Click += new System.EventHandler(this.buttonOpenFile_ISI_Click);
            // 
            // buttonAboutProg_ISI
            // 
            this.buttonAboutProg_ISI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAboutProg_ISI.Image = global::Tyuiu.IvanovSI.Sprint7.Project0.V2.Properties.Resources.information;
            this.buttonAboutProg_ISI.Location = new System.Drawing.Point(787, 3);
            this.buttonAboutProg_ISI.Name = "buttonAboutProg_ISI";
            this.buttonAboutProg_ISI.Size = new System.Drawing.Size(49, 46);
            this.buttonAboutProg_ISI.TabIndex = 2;
            this.metroToolTip_ISI.SetToolTip(this.buttonAboutProg_ISI, "Краткое руководство по использованию программы");
            this.buttonAboutProg_ISI.UseVisualStyleBackColor = true;
            this.buttonAboutProg_ISI.Click += new System.EventHandler(this.buttonAboutProg_ISI_Click);
            // 
            // buttonHelp_ISI
            // 
            this.buttonHelp_ISI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ISI.Image = global::Tyuiu.IvanovSI.Sprint7.Project0.V2.Properties.Resources.help;
            this.buttonHelp_ISI.Location = new System.Drawing.Point(842, 3);
            this.buttonHelp_ISI.Name = "buttonHelp_ISI";
            this.buttonHelp_ISI.Size = new System.Drawing.Size(49, 46);
            this.buttonHelp_ISI.TabIndex = 2;
            this.metroToolTip_ISI.SetToolTip(this.buttonHelp_ISI, "О программе");
            this.buttonHelp_ISI.UseVisualStyleBackColor = true;
            this.buttonHelp_ISI.Click += new System.EventHandler(this.buttonHelp_ISI_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(934, 632);
            this.Controls.Add(this.panelGrid_ISI);
            this.Controls.Add(this.panelFunctions_ISI);
            this.Name = "FormMain";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Сеть магазинов";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelFunctions_ISI.ResumeLayout(false);
            this.groupBoxSearch_ISI.ResumeLayout(false);
            this.groupBoxSearch_ISI.PerformLayout();
            this.panelGrid_ISI.ResumeLayout(false);
            this.groupBoxGrid_ISI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_ISI)).EndInit();
            this.contextMenuStrip_ISI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonHelp_ISI;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ISI;
        private System.Windows.Forms.Panel panelFunctions_ISI;
        private System.Windows.Forms.Button buttonSave_ISI;
        private System.Windows.Forms.Panel panelGrid_ISI;
        private System.Windows.Forms.GroupBox groupBoxGrid_ISI;
        private System.Windows.Forms.DataGridView dataGridViewIn_ISI;
        private System.Windows.Forms.Button buttonStat_ISI;
        private System.Windows.Forms.Button buttonSort_ISI;
        private System.Windows.Forms.Button buttonOpenFile_ISI;
        private System.Windows.Forms.Button buttonAboutProg_ISI;
        private System.Windows.Forms.TextBox textBoxSearch_ISI;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_ISI;
        private System.Windows.Forms.GroupBox groupBoxSearch_ISI;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ISI;
        private System.Windows.Forms.ToolStripMenuItem ценаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адресМагазинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фИОПоставщикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem аЯToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аЯToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem яАToolStripMenuItem1;
        private MetroFramework.Components.MetroToolTip metroToolTip_ISI;
        private System.Windows.Forms.Button buttonAdd_ISI;
    }
}

