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
using System.Threading;
using System.Timers;

namespace PlanningDay
{
    public partial class MainForm : Form
    {
        List<TableTask> listHour;
        List<TableTask> listHourNew;
        DateTime dateTime = DateTime.Now;
        int timerCount = 0;
        public DateTime Date { set { dateTime = DateTime.Now; } get { return dateTime; } }
        public int Second { get; set; }
        public static List<TableTask> ListGrid { get; set; } 
        public MainForm()
        {
            InitializeComponent();
            this.Size = new Size(600, 500);
            WriteDataGrid();
            List<TableTask> listDay = CheckDate(DateTime.Now);
            listHour = TimeForEvent(Date, listDay);
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            Thread myThread = new Thread(new ThreadStart(CheckMinutes));
            myThread.Start();
        }
        private void CheckMinutes()
        {
            Date = DateTime.Now;
            while (true)
            {
                timerCount++;
                if (timerCount == 60000)
                {
                    timerCount = 0;
                    Thread.Sleep(10000);
                    Date = DateTime.Now;
                    timer1.Enabled = false;
                    timer1.Enabled = true;
                }
            }
        }
        private void timer1_Tick(object source, EventArgs e)
        {
            foreach(var t in listHour.ToArray())
            {
                if(t.Time.Hour == Date.Hour && t.Time.Minute == Date.Minute)
                {
                    MessageBox.Show("Урааааа действие");
                    listHour.Remove(t);
                }
            }
        }
        public List<TableTask> CheckDate(DateTime date)
        {
            List<TableTask> newList = new List<TableTask>();
            using (DBConnect db = new DBConnect())
            {
                //List<TableTask> grid = new List<TableTask>();
                //for(int i = 0; i < dataGridView1.RowCount; i++)
                //{
                //    TableTask task = new TableTask()
                //    {
                //        Time = (DateTime)dataGridView1[2, i].Value,
                //        Date = (DateTime)dataGridView1[3, i].Value,
                //        Work = dataGridView1[4, i].Value.ToString(),
                //    };
                //    grid.Add(task);
                //}
                List<TableTask> allList = db.AllWork.ToList();
                foreach (TableTask t in allList)
                {
                    if (date.Day == t.Date.Day)
                    {
                        newList.Add(t);
                    }
                }
            }
            return newList;
        }

        private List<TableTask> TimeForEvent(DateTime date, List<TableTask> list)
        {
            List<TableTask> newList = new List<TableTask>();
            foreach (TableTask t in list)
            {
                if (date.Hour == t.Date.Hour)
                {
                    newList.Add(t);
                }
            }
            return newList;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FormAdd add = new FormAdd();
            add.ShowDialog();
        }

        public static void WriteDataGrid()
        {
            using (DBConnect db = new DBConnect())
            {
                var list = db.AllWork;
                int count = 1;
                dataGridView1.Rows.Clear();
                foreach (TableTask task in list)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[count - 1].Cells[0].Value = count;
                    dataGridView1.Rows[count - 1].Cells[1].Value = task.Time;
                    dataGridView1.Rows[count - 1].Cells[2].Value = task.Date;
                    dataGridView1.Rows[count - 1].Cells[3].Value = task.Work;
                    dataGridView1.Rows[count - 1].Cells[4].Value = task.Information;
                    count++;
                }
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            int selectRow = dataGridView1.CurrentRow.Index;
            using (DBConnect db = new DBConnect())
            {
                List<TableTask> list = db.AllWork.ToList();
                int count = 0;
                foreach(TableTask task in list)
                {
                    if(selectRow == count)
                    {
                        try
                        {
                            db.AllWork.Remove(task);
                            db.SaveChanges();
                        }catch(Exception ex)
                        {
                            string s = ex.InnerException.ToString();
                        }
                        
                    }
                    count++;
                }
            }
            WriteDataGrid();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int selectRow = dataGridView1.CurrentRow.Index;
            using (DBConnect db = new DBConnect())
            {
                List<TableTask> list = db.AllWork.ToList();
                int count = 0;
                foreach (TableTask task in list)
                {
                    if (selectRow == count)
                    {
                        FormUpdate form = new FormUpdate(selectRow);
                        form.ShowDialog();
                    }
                    count++;
                }
            }
        }
    }
}
