
namespace Tyuiu.AgafonovKS.Sprint7.Project.V14
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
            this.panelTop_AKS = new System.Windows.Forms.Panel();
            this.textBoxTask_AKS = new System.Windows.Forms.TextBox();
            this.panelLeft_AKS = new System.Windows.Forms.Panel();
            this.groupBoxBus_AKS = new System.Windows.Forms.GroupBox();
            this.comboBoxBus_AKS = new System.Windows.Forms.ComboBox();
            this.panelRight_AKS = new System.Windows.Forms.Panel();
            this.dataGridView_AKS = new System.Windows.Forms.DataGridView();
            this.ColumnNumber_AKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStart_AKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnd_AKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDistance_AKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPay_AKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStop_AKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBus_AKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate_AKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime_AKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip_AKS = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_AKS = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_AKS = new System.Windows.Forms.SaveFileDialog();
            this.buttonDelete_AKS = new System.Windows.Forms.Button();
            this.buttonAdd_AKS = new System.Windows.Forms.Button();
            this.buttonSave_AKS = new System.Windows.Forms.Button();
            this.buttonOpen_AKS = new System.Windows.Forms.Button();
            this.buttonHelp_AKS = new System.Windows.Forms.Button();
            this.panelTop_AKS.SuspendLayout();
            this.panelLeft_AKS.SuspendLayout();
            this.groupBoxBus_AKS.SuspendLayout();
            this.panelRight_AKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AKS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_AKS
            // 
            this.panelTop_AKS.Controls.Add(this.buttonHelp_AKS);
            this.panelTop_AKS.Controls.Add(this.textBoxTask_AKS);
            this.panelTop_AKS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_AKS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AKS.Name = "panelTop_AKS";
            this.panelTop_AKS.Size = new System.Drawing.Size(800, 105);
            this.panelTop_AKS.TabIndex = 0;
            // 
            // textBoxTask_AKS
            // 
            this.textBoxTask_AKS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_AKS.Location = new System.Drawing.Point(116, 46);
            this.textBoxTask_AKS.Multiline = true;
            this.textBoxTask_AKS.Name = "textBoxTask_AKS";
            this.textBoxTask_AKS.Size = new System.Drawing.Size(574, 26);
            this.textBoxTask_AKS.TabIndex = 0;
            this.textBoxTask_AKS.TabStop = false;
            this.textBoxTask_AKS.Text = "Тюменская Транспортная Система";
            this.textBoxTask_AKS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelLeft_AKS
            // 
            this.panelLeft_AKS.Controls.Add(this.groupBoxBus_AKS);
            this.panelLeft_AKS.Controls.Add(this.buttonDelete_AKS);
            this.panelLeft_AKS.Controls.Add(this.buttonAdd_AKS);
            this.panelLeft_AKS.Controls.Add(this.buttonSave_AKS);
            this.panelLeft_AKS.Controls.Add(this.buttonOpen_AKS);
            this.panelLeft_AKS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_AKS.Location = new System.Drawing.Point(0, 105);
            this.panelLeft_AKS.Name = "panelLeft_AKS";
            this.panelLeft_AKS.Size = new System.Drawing.Size(222, 345);
            this.panelLeft_AKS.TabIndex = 1;
            // 
            // groupBoxBus_AKS
            // 
            this.groupBoxBus_AKS.Controls.Add(this.comboBoxBus_AKS);
            this.groupBoxBus_AKS.Location = new System.Drawing.Point(10, 158);
            this.groupBoxBus_AKS.Name = "groupBoxBus_AKS";
            this.groupBoxBus_AKS.Size = new System.Drawing.Size(206, 51);
            this.groupBoxBus_AKS.TabIndex = 4;
            this.groupBoxBus_AKS.TabStop = false;
            this.groupBoxBus_AKS.Text = "Выбор маршрута:";
            // 
            // comboBoxBus_AKS
            // 
            this.comboBoxBus_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxBus_AKS.FormattingEnabled = true;
            this.comboBoxBus_AKS.Location = new System.Drawing.Point(3, 18);
            this.comboBoxBus_AKS.Name = "comboBoxBus_AKS";
            this.comboBoxBus_AKS.Size = new System.Drawing.Size(200, 24);
            this.comboBoxBus_AKS.TabIndex = 0;
            this.comboBoxBus_AKS.SelectedIndexChanged += new System.EventHandler(this.comboBoxBus_AKS_SelectedIndexChanged);
            // 
            // panelRight_AKS
            // 
            this.panelRight_AKS.Controls.Add(this.dataGridView_AKS);
            this.panelRight_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_AKS.Location = new System.Drawing.Point(222, 105);
            this.panelRight_AKS.Name = "panelRight_AKS";
            this.panelRight_AKS.Size = new System.Drawing.Size(578, 345);
            this.panelRight_AKS.TabIndex = 2;
            // 
            // dataGridView_AKS
            // 
            this.dataGridView_AKS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_AKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AKS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber_AKS,
            this.ColumnStart_AKS,
            this.ColumnEnd_AKS,
            this.ColumnDistance_AKS,
            this.ColumnPay_AKS,
            this.ColumnStop_AKS,
            this.ColumnBus_AKS,
            this.ColumnDate_AKS,
            this.ColumnTime_AKS});
            this.dataGridView_AKS.Location = new System.Drawing.Point(4, 6);
            this.dataGridView_AKS.Name = "dataGridView_AKS";
            this.dataGridView_AKS.RowHeadersVisible = false;
            this.dataGridView_AKS.RowHeadersWidth = 51;
            this.dataGridView_AKS.RowTemplate.Height = 24;
            this.dataGridView_AKS.Size = new System.Drawing.Size(573, 338);
            this.dataGridView_AKS.TabIndex = 0;
            // 
            // ColumnNumber_AKS
            // 
            this.ColumnNumber_AKS.HeaderText = "Номер маршрута";
            this.ColumnNumber_AKS.MinimumWidth = 6;
            this.ColumnNumber_AKS.Name = "ColumnNumber_AKS";
            this.ColumnNumber_AKS.Width = 125;
            // 
            // ColumnStart_AKS
            // 
            this.ColumnStart_AKS.HeaderText = "Начало маршрута";
            this.ColumnStart_AKS.MinimumWidth = 6;
            this.ColumnStart_AKS.Name = "ColumnStart_AKS";
            this.ColumnStart_AKS.Width = 125;
            // 
            // ColumnEnd_AKS
            // 
            this.ColumnEnd_AKS.HeaderText = "Конец маршрута";
            this.ColumnEnd_AKS.MinimumWidth = 6;
            this.ColumnEnd_AKS.Name = "ColumnEnd_AKS";
            this.ColumnEnd_AKS.Width = 125;
            // 
            // ColumnDistance_AKS
            // 
            this.ColumnDistance_AKS.HeaderText = "Протяженость маршрута";
            this.ColumnDistance_AKS.MinimumWidth = 6;
            this.ColumnDistance_AKS.Name = "ColumnDistance_AKS";
            this.ColumnDistance_AKS.Width = 125;
            // 
            // ColumnPay_AKS
            // 
            this.ColumnPay_AKS.HeaderText = "Наличие системы безналичной оплаты проезда";
            this.ColumnPay_AKS.MinimumWidth = 6;
            this.ColumnPay_AKS.Name = "ColumnPay_AKS";
            this.ColumnPay_AKS.Width = 125;
            // 
            // ColumnStop_AKS
            // 
            this.ColumnStop_AKS.HeaderText = "Наличие автоматического объявления остановки";
            this.ColumnStop_AKS.MinimumWidth = 6;
            this.ColumnStop_AKS.Name = "ColumnStop_AKS";
            this.ColumnStop_AKS.Width = 125;
            // 
            // ColumnBus_AKS
            // 
            this.ColumnBus_AKS.HeaderText = "Вид транспорта";
            this.ColumnBus_AKS.MinimumWidth = 6;
            this.ColumnBus_AKS.Name = "ColumnBus_AKS";
            this.ColumnBus_AKS.Width = 125;
            // 
            // ColumnDate_AKS
            // 
            this.ColumnDate_AKS.HeaderText = "Дата введения маршрута";
            this.ColumnDate_AKS.MinimumWidth = 6;
            this.ColumnDate_AKS.Name = "ColumnDate_AKS";
            this.ColumnDate_AKS.Width = 125;
            // 
            // ColumnTime_AKS
            // 
            this.ColumnTime_AKS.HeaderText = "Время в пути";
            this.ColumnTime_AKS.MinimumWidth = 6;
            this.ColumnTime_AKS.Name = "ColumnTime_AKS";
            this.ColumnTime_AKS.Width = 125;
            // 
            // toolTip_AKS
            // 
            this.toolTip_AKS.ToolTipTitle = "Справка";
            // 
            // openFileDialog_AKS
            // 
            this.openFileDialog_AKS.FileName = "openFileDialog1";
            // 
            // buttonDelete_AKS
            // 
            this.buttonDelete_AKS.Image = global::Tyuiu.AgafonovKS.Sprint7.Project.V14.Properties.Resources.table_delete;
            this.buttonDelete_AKS.Location = new System.Drawing.Point(116, 82);
            this.buttonDelete_AKS.Name = "buttonDelete_AKS";
            this.buttonDelete_AKS.Size = new System.Drawing.Size(100, 70);
            this.buttonDelete_AKS.TabIndex = 3;
            this.toolTip_AKS.SetToolTip(this.buttonDelete_AKS, "Удаление строки");
            this.buttonDelete_AKS.UseVisualStyleBackColor = true;
            this.buttonDelete_AKS.Click += new System.EventHandler(this.buttonDelete_AKS_Click);
            // 
            // buttonAdd_AKS
            // 
            this.buttonAdd_AKS.Image = global::Tyuiu.AgafonovKS.Sprint7.Project.V14.Properties.Resources.table_add;
            this.buttonAdd_AKS.Location = new System.Drawing.Point(116, 6);
            this.buttonAdd_AKS.Name = "buttonAdd_AKS";
            this.buttonAdd_AKS.Size = new System.Drawing.Size(100, 70);
            this.buttonAdd_AKS.TabIndex = 2;
            this.toolTip_AKS.SetToolTip(this.buttonAdd_AKS, "Добавление строки");
            this.buttonAdd_AKS.UseVisualStyleBackColor = true;
            this.buttonAdd_AKS.Click += new System.EventHandler(this.buttonAdd_AKS_Click);
            // 
            // buttonSave_AKS
            // 
            this.buttonSave_AKS.Image = global::Tyuiu.AgafonovKS.Sprint7.Project.V14.Properties.Resources.page_save;
            this.buttonSave_AKS.Location = new System.Drawing.Point(10, 82);
            this.buttonSave_AKS.Name = "buttonSave_AKS";
            this.buttonSave_AKS.Size = new System.Drawing.Size(100, 70);
            this.buttonSave_AKS.TabIndex = 1;
            this.toolTip_AKS.SetToolTip(this.buttonSave_AKS, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSave_AKS.UseVisualStyleBackColor = true;
            this.buttonSave_AKS.Click += new System.EventHandler(this.buttonSave_AKS_Click);
            // 
            // buttonOpen_AKS
            // 
            this.buttonOpen_AKS.Image = global::Tyuiu.AgafonovKS.Sprint7.Project.V14.Properties.Resources.folder_page_white;
            this.buttonOpen_AKS.Location = new System.Drawing.Point(10, 6);
            this.buttonOpen_AKS.Name = "buttonOpen_AKS";
            this.buttonOpen_AKS.Size = new System.Drawing.Size(100, 70);
            this.buttonOpen_AKS.TabIndex = 0;
            this.toolTip_AKS.SetToolTip(this.buttonOpen_AKS, "Открыть файл\r\nВыберите нужный файл для обработки ");
            this.buttonOpen_AKS.UseVisualStyleBackColor = true;
            this.buttonOpen_AKS.Click += new System.EventHandler(this.buttonOpen_AKS_Click);
            // 
            // buttonHelp_AKS
            // 
            this.buttonHelp_AKS.Image = global::Tyuiu.AgafonovKS.Sprint7.Project.V14.Properties.Resources.information;
            this.buttonHelp_AKS.Location = new System.Drawing.Point(707, 25);
            this.buttonHelp_AKS.Name = "buttonHelp_AKS";
            this.buttonHelp_AKS.Size = new System.Drawing.Size(81, 59);
            this.buttonHelp_AKS.TabIndex = 1;
            this.toolTip_AKS.SetToolTip(this.buttonHelp_AKS, "Сведения о программе");
            this.buttonHelp_AKS.UseVisualStyleBackColor = true;
            this.buttonHelp_AKS.Click += new System.EventHandler(this.buttonHelp_AKS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRight_AKS);
            this.Controls.Add(this.panelLeft_AKS);
            this.Controls.Add(this.panelTop_AKS);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 7 | Проект | Вариант 14 | Агафонов К.С.";
            this.panelTop_AKS.ResumeLayout(false);
            this.panelTop_AKS.PerformLayout();
            this.panelLeft_AKS.ResumeLayout(false);
            this.groupBoxBus_AKS.ResumeLayout(false);
            this.panelRight_AKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AKS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_AKS;
        private System.Windows.Forms.Button buttonHelp_AKS;
        private System.Windows.Forms.TextBox textBoxTask_AKS;
        private System.Windows.Forms.Panel panelLeft_AKS;
        private System.Windows.Forms.GroupBox groupBoxBus_AKS;
        private System.Windows.Forms.ComboBox comboBoxBus_AKS;
        private System.Windows.Forms.Button buttonDelete_AKS;
        private System.Windows.Forms.Button buttonAdd_AKS;
        private System.Windows.Forms.Button buttonSave_AKS;
        private System.Windows.Forms.Button buttonOpen_AKS;
        private System.Windows.Forms.Panel panelRight_AKS;
        private System.Windows.Forms.DataGridView dataGridView_AKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber_AKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStart_AKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnd_AKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDistance_AKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPay_AKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStop_AKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBus_AKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate_AKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime_AKS;
        private System.Windows.Forms.ToolTip toolTip_AKS;
        private System.Windows.Forms.OpenFileDialog openFileDialog_AKS;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_AKS;
    }
}

