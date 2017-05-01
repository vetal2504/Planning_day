using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanningDay.Model;

namespace PlanningDay
{
    public partial class FormUpdate : Form
    {
        public int Row { get; set; }
        public FormUpdate(int rows)
        {
            InitializeComponent();
            Row = rows;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            using (DBConnect db = new DBConnect())
            {
                List<TableTask> list = db.AllWork.ToList();
                int count = 0;
                DateTime date = DateTime.Now;
                int hour = Int32.Parse(numericUpDown1.Value.ToString());
                int minutes = Int32.Parse(numericUpDown2.Value.ToString());
                bool every_day = false;

                if (checkBox1.Checked)
                {
                    every_day = true;
                }

                foreach (TableTask task in list)
                {
                    if(count == Row)
                    {
                        if (textBox1.Text != String.Empty)
                        {
                            task.Date = dateTimePicker1.Value;
                            task.Time = new DateTime(date.Year, date.Month, date.Day, hour, minutes, 0);
                            task.Work = textBox1.Text;
                            task.Information = textBox2.Text;
                            task.EveryDay = every_day;
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Введите событие: ");
                        }
                    }
                    count++;
                }
            }
            MainForm.WriteDataGrid();
            this.Close();
        }
    }
}
