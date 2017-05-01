using System;
using System.Windows.Forms;
using PlanningDay.Model;
using System.Collections.Generic;

namespace PlanningDay
{
    public partial class FormAdd : Form
    {
        
        public FormAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            List<TableTask> listGrid = new List<TableTask>();
            using (DBConnect db = new DBConnect())
            {
                int hour = Int32.Parse(numericUpDown_hour.Value.ToString());
                int minutes = Int32.Parse(numericUpDown_minunes.Value.ToString());
                bool every_day = false;
                if (checkBox1.Checked)
                {
                    every_day = true;
                }
                DateTime date = DateTime.Now;
                if(textBox_event.Text != String.Empty)
                {
                    TableTask task = new TableTask()
                    {
                        Date = dateTime_Date.Value,
                        Time = new DateTime(date.Year, date.Month, date.Day, hour, minutes, 0),
                        Work = textBox_event.Text,
                        Information = textBox_inform.Text,
                        EveryDay = every_day
                    };
                    db.AllWork.Add(task);
                    db.SaveChanges();
                } else {
                    MessageBox.Show("Введите событие: ");
                }
                
                foreach (var grid in db.AllWork)
                {
                    listGrid.Add(grid);
                }
            }
            MainForm.WriteDataGrid();
            MainForm.ListGrid = listGrid;
            this.Close();
        }
    }
}
