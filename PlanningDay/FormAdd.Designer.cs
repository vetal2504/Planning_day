namespace PlanningDay
{
    partial class FormAdd
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
            this.button_back = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.dateTime_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_event = new System.Windows.Forms.TextBox();
            this.textBox_inform = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_hour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_minunes = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minunes)).BeginInit();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(13, 280);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 0;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(191, 280);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dateTime_Date
            // 
            this.dateTime_Date.Location = new System.Drawing.Point(13, 83);
            this.dateTime_Date.Name = "dateTime_Date";
            this.dateTime_Date.Size = new System.Drawing.Size(160, 20);
            this.dateTime_Date.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Укажите время: час";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Укажите дату:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Укажите событие";
            // 
            // textBox_event
            // 
            this.textBox_event.Location = new System.Drawing.Point(13, 126);
            this.textBox_event.Multiline = true;
            this.textBox_event.Name = "textBox_event";
            this.textBox_event.Size = new System.Drawing.Size(160, 50);
            this.textBox_event.TabIndex = 9;
            this.textBox_event.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_inform
            // 
            this.textBox_inform.Location = new System.Drawing.Point(13, 195);
            this.textBox_inform.Multiline = true;
            this.textBox_inform.Name = "textBox_inform";
            this.textBox_inform.Size = new System.Drawing.Size(163, 61);
            this.textBox_inform.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дополнительна информация";
            // 
            // numericUpDown_hour
            // 
            this.numericUpDown_hour.Location = new System.Drawing.Point(16, 30);
            this.numericUpDown_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown_hour.Name = "numericUpDown_hour";
            this.numericUpDown_hour.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_hour.TabIndex = 12;
            // 
            // numericUpDown_minunes
            // 
            this.numericUpDown_minunes.Location = new System.Drawing.Point(146, 30);
            this.numericUpDown_minunes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_minunes.Name = "numericUpDown_minunes";
            this.numericUpDown_minunes.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_minunes.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(107, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Напоминать каждый день?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown_minunes);
            this.Controls.Add(this.numericUpDown_hour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_inform);
            this.Controls.Add(this.textBox_event);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime_Date);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_back);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minunes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DateTimePicker dateTime_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_event;
        private System.Windows.Forms.TextBox textBox_inform;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_hour;
        private System.Windows.Forms.NumericUpDown numericUpDown_minunes;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}