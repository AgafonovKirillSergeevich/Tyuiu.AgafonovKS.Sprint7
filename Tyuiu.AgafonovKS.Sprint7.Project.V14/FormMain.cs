using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AgafonovKS.Sprint7.Project.V14.Lib;
using System.IO;

namespace Tyuiu.AgafonovKS.Sprint7.Project.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void buttonOpen_AKS_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_AKS.ShowDialog();
                openFilePath = openFileDialog_AKS.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridView_AKS.RowCount = rows + 1;
                dataGridView_AKS.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView_AKS.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridView_AKS.AutoResizeColumns();
                dataGridView_AKS.ScrollBars = ScrollBars.Both;
                buttonSave_AKS.Enabled = true;
                buttonAdd_AKS.Enabled = true;
                buttonDelete_AKS.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_AKS_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_AKS.FileName = ".csv";
                saveFileDialog_AKS.InitialDirectory = @":L";
                if (saveFileDialog_AKS.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialog_AKS.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridView_AKS.RowCount;
                    int columns = dataGridView_AKS.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridView_AKS.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(";");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_AKS_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_AKS.Rows.Add();
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_AKS_Click(object sender, EventArgs e)
        {
            if (dataGridView_AKS.RowCount != 0)
            {
                int valueDel = 0;
                var res = MessageBox.Show($"{"Удалить данную строку?"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) valueDel = 1;
                if (valueDel == 1)
                {
                    int del = dataGridView_AKS.CurrentCell.RowIndex;
                    dataGridView_AKS.Rows.Remove(dataGridView_AKS.Rows[del]);
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxBus_AKS_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueFilt = comboBoxBus_AKS.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента ComboBox
            if (!string.IsNullOrEmpty(valueFilt))
            {
                foreach (DataGridViewRow row in dataGridView_AKS.Rows)
                {
                    if (!row.IsNewRow) // проверка новая ли строка
                    {
                        if (row.Cells["Number_CSR"].Value != null && row.Cells["Number_CSR"].Value.ToString() == valueFilt)
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
        }

        private void buttonHelp_AKS_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
    }
}
