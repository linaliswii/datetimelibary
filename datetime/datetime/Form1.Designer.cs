namespace datetime
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.btnCalculateDifference = new System.Windows.Forms.Button();
            this.btnIsLeapYear = new System.Windows.Forms.Button();
            this.btnGetTimeOfDay = new System.Windows.Forms.Button();
            this.btnFormatDateTime = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.dateTimePickerFormat = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(43, 75);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(136, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(269, 48);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(133, 29);
            this.txtYear.TabIndex = 2;
            this.txtYear.UseSystemPasswordChar = true;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Location = new System.Drawing.Point(43, 209);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(136, 22);
            this.dateTimePickerTime.TabIndex = 3;
            // 
            // btnCalculateDifference
            // 
            this.btnCalculateDifference.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCalculateDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculateDifference.Location = new System.Drawing.Point(43, 112);
            this.btnCalculateDifference.Name = "btnCalculateDifference";
            this.btnCalculateDifference.Size = new System.Drawing.Size(136, 35);
            this.btnCalculateDifference.TabIndex = 5;
            this.btnCalculateDifference.Text = "Разница";
            this.btnCalculateDifference.UseVisualStyleBackColor = false;
            this.btnCalculateDifference.Click += new System.EventHandler(this.btnCalculateDifference_Click);
            // 
            // btnIsLeapYear
            // 
            this.btnIsLeapYear.BackColor = System.Drawing.Color.PeachPuff;
            this.btnIsLeapYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIsLeapYear.Location = new System.Drawing.Point(269, 83);
            this.btnIsLeapYear.Name = "btnIsLeapYear";
            this.btnIsLeapYear.Size = new System.Drawing.Size(133, 35);
            this.btnIsLeapYear.TabIndex = 6;
            this.btnIsLeapYear.Text = "Определить год";
            this.btnIsLeapYear.UseVisualStyleBackColor = false;
            this.btnIsLeapYear.Click += new System.EventHandler(this.btnIsLeapYear_Click);
            // 
            // btnGetTimeOfDay
            // 
            this.btnGetTimeOfDay.BackColor = System.Drawing.Color.PeachPuff;
            this.btnGetTimeOfDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetTimeOfDay.Location = new System.Drawing.Point(43, 237);
            this.btnGetTimeOfDay.Name = "btnGetTimeOfDay";
            this.btnGetTimeOfDay.Size = new System.Drawing.Size(136, 33);
            this.btnGetTimeOfDay.TabIndex = 7;
            this.btnGetTimeOfDay.Text = "Время суток";
            this.btnGetTimeOfDay.UseVisualStyleBackColor = false;
            this.btnGetTimeOfDay.Click += new System.EventHandler(this.btnGetTimeOfDay_Click);
            // 
            // btnFormatDateTime
            // 
            this.btnFormatDateTime.BackColor = System.Drawing.Color.PeachPuff;
            this.btnFormatDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFormatDateTime.Location = new System.Drawing.Point(304, 246);
            this.btnFormatDateTime.Name = "btnFormatDateTime";
            this.btnFormatDateTime.Size = new System.Drawing.Size(134, 35);
            this.btnFormatDateTime.TabIndex = 8;
            this.btnFormatDateTime.Text = "Формат даты";
            this.btnFormatDateTime.UseVisualStyleBackColor = false;
            this.btnFormatDateTime.Click += new System.EventHandler(this.btnFormatDateTime_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(618, 215);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 9;
            // 
            // dateTimePickerFormat
            // 
            this.dateTimePickerFormat.Location = new System.Drawing.Point(269, 218);
            this.dateTimePickerFormat.Name = "dateTimePickerFormat";
            this.dateTimePickerFormat.Size = new System.Drawing.Size(169, 22);
            this.dateTimePickerFormat.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(266, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите год:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(266, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите формат даты:";
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult1.Location = new System.Drawing.Point(40, 310);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(46, 18);
            this.lblResult1.TabIndex = 13;
            this.lblResult1.Text = "label3";
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(269, 179);
            this.txtFormat.Multiline = true;
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(166, 33);
            this.txtFormat.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(482, 348);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFormat);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnFormatDateTime);
            this.Controls.Add(this.btnGetTimeOfDay);
            this.Controls.Add(this.btnIsLeapYear);
            this.Controls.Add(this.btnCalculateDifference);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Button btnCalculateDifference;
        private System.Windows.Forms.Button btnIsLeapYear;
        private System.Windows.Forms.Button btnGetTimeOfDay;
        private System.Windows.Forms.Button btnFormatDateTime;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DateTimePicker dateTimePickerFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.TextBox txtFormat;
    }
}

