namespace TimePuncher
{
    partial class TimerPuncherForm
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
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lunchStartLabel = new System.Windows.Forms.Label();
            this.lunchStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lunchEndlabel = new System.Windows.Forms.Label();
            this.lunchEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lunchMinutesLabel = new System.Windows.Forms.Label();
            this.reportTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hoursWorkedLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(7, 181);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(179, 45);
            this.hoursWorkedLabel.TabIndex = 0;
            this.hoursWorkedLabel.Text = "Hours: 0.00";
            this.hoursWorkedLabel.Click += new System.EventHandler(this.hoursWorkedLabel_Click);
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "hh:mm tt";
            this.startTimePicker.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(146, 4);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(132, 39);
            this.startTimePicker.TabIndex = 1;
            this.startTimePicker.ValueChanged += new System.EventHandler(this.startTimePicker_ValueChanged);
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startTimeLabel.Location = new System.Drawing.Point(78, 9);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(67, 32);
            this.startTimeLabel.TabIndex = 2;
            this.startTimeLabel.Text = "Start:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endLabel.Location = new System.Drawing.Point(81, 144);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(59, 32);
            this.endLabel.TabIndex = 4;
            this.endLabel.Text = "End:";
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "hh:mm tt";
            this.endTimePicker.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(146, 139);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(132, 39);
            this.endTimePicker.TabIndex = 3;
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
            // 
            // lunchStartLabel
            // 
            this.lunchStartLabel.AutoSize = true;
            this.lunchStartLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lunchStartLabel.Location = new System.Drawing.Point(7, 54);
            this.lunchStartLabel.Name = "lunchStartLabel";
            this.lunchStartLabel.Size = new System.Drawing.Size(138, 32);
            this.lunchStartLabel.TabIndex = 6;
            this.lunchStartLabel.Text = "Lunch Start:";
            // 
            // lunchStartTimePicker
            // 
            this.lunchStartTimePicker.CustomFormat = "hh:mm tt";
            this.lunchStartTimePicker.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lunchStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lunchStartTimePicker.Location = new System.Drawing.Point(146, 49);
            this.lunchStartTimePicker.Name = "lunchStartTimePicker";
            this.lunchStartTimePicker.ShowUpDown = true;
            this.lunchStartTimePicker.Size = new System.Drawing.Size(132, 39);
            this.lunchStartTimePicker.TabIndex = 5;
            this.lunchStartTimePicker.ValueChanged += new System.EventHandler(this.lunchStartTimePicker_ValueChanged);
            // 
            // lunchEndlabel
            // 
            this.lunchEndlabel.AutoSize = true;
            this.lunchEndlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lunchEndlabel.Location = new System.Drawing.Point(15, 99);
            this.lunchEndlabel.Name = "lunchEndlabel";
            this.lunchEndlabel.Size = new System.Drawing.Size(130, 32);
            this.lunchEndlabel.TabIndex = 8;
            this.lunchEndlabel.Text = "Lunch End:";
            // 
            // lunchEndTimePicker
            // 
            this.lunchEndTimePicker.CustomFormat = "hh:mm tt";
            this.lunchEndTimePicker.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lunchEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lunchEndTimePicker.Location = new System.Drawing.Point(146, 94);
            this.lunchEndTimePicker.Name = "lunchEndTimePicker";
            this.lunchEndTimePicker.ShowUpDown = true;
            this.lunchEndTimePicker.Size = new System.Drawing.Size(132, 39);
            this.lunchEndTimePicker.TabIndex = 7;
            this.lunchEndTimePicker.ValueChanged += new System.EventHandler(this.lunchEndTimePicker_ValueChanged);
            // 
            // lunchMinutesLabel
            // 
            this.lunchMinutesLabel.AutoSize = true;
            this.lunchMinutesLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lunchMinutesLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.lunchMinutesLabel.Location = new System.Drawing.Point(7, 226);
            this.lunchMinutesLabel.Name = "lunchMinutesLabel";
            this.lunchMinutesLabel.Size = new System.Drawing.Size(178, 45);
            this.lunchMinutesLabel.TabIndex = 9;
            this.lunchMinutesLabel.Text = "Lunch: 0.00";
            // 
            // reportTextBox
            // 
            this.reportTextBox.Location = new System.Drawing.Point(15, 274);
            this.reportTextBox.Multiline = true;
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.ReadOnly = true;
            this.reportTextBox.Size = new System.Drawing.Size(314, 125);
            this.reportTextBox.TabIndex = 10;
            // 
            // TimerPuncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 411);
            this.Controls.Add(this.reportTextBox);
            this.Controls.Add(this.lunchMinutesLabel);
            this.Controls.Add(this.lunchEndlabel);
            this.Controls.Add(this.lunchEndTimePicker);
            this.Controls.Add(this.lunchStartLabel);
            this.Controls.Add(this.lunchStartTimePicker);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.hoursWorkedLabel);
            this.MaximumSize = new System.Drawing.Size(355, 450);
            this.MinimumSize = new System.Drawing.Size(355, 450);
            this.Name = "TimerPuncherForm";
            this.Text = "Timer Puncher";
            this.Load += new System.EventHandler(this.TimerPuncherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label hoursWorkedLabel;
        private DateTimePicker startTimePicker;
        private Label startTimeLabel;
        private Label endLabel;
        private DateTimePicker endTimePicker;
        private Label lunchStartLabel;
        private DateTimePicker lunchStartTimePicker;
        private Label lunchEndlabel;
        private DateTimePicker lunchEndTimePicker;
        private Label lunchMinutesLabel;
        private TextBox reportTextBox;
    }
}