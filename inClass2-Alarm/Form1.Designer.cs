namespace inClass2_Alarm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.stopAlarmButton = new System.Windows.Forms.Button();
            this.alarmSetBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.alarmCheck = new System.Windows.Forms.CheckBox();
            this.alarmTimer = new System.Windows.Forms.Timer(this.components);
            this.labelImage = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.Location = new System.Drawing.Point(35, 35);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(431, 101);
            this.currentTimeLabel.TabIndex = 0;
            this.currentTimeLabel.Text = "00 : 00 : 00";
            this.currentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopAlarmButton
            // 
            this.stopAlarmButton.BackColor = System.Drawing.SystemColors.Control;
            this.stopAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopAlarmButton.Location = new System.Drawing.Point(515, 253);
            this.stopAlarmButton.Name = "stopAlarmButton";
            this.stopAlarmButton.Size = new System.Drawing.Size(248, 94);
            this.stopAlarmButton.TabIndex = 1;
            this.stopAlarmButton.Text = "Stop Alarm";
            this.stopAlarmButton.UseVisualStyleBackColor = false;
            this.stopAlarmButton.Click += new System.EventHandler(this.stopAlarmButton_Click);
            // 
            // alarmSetBox
            // 
            this.alarmSetBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alarmSetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmSetBox.Location = new System.Drawing.Point(106, 29);
            this.alarmSetBox.Name = "alarmSetBox";
            this.alarmSetBox.Size = new System.Drawing.Size(193, 35);
            this.alarmSetBox.TabIndex = 3;
            this.alarmSetBox.Text = "00:00:00";
            this.alarmSetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alarmSetBox.TextChanged += new System.EventHandler(this.alarmSetBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.alarmCheck);
            this.groupBox2.Controls.Add(this.alarmSetBox);
            this.groupBox2.Location = new System.Drawing.Point(35, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 187);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // alarmCheck
            // 
            this.alarmCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmCheck.Location = new System.Drawing.Point(133, 93);
            this.alarmCheck.Name = "alarmCheck";
            this.alarmCheck.Size = new System.Drawing.Size(133, 33);
            this.alarmCheck.TabIndex = 5;
            this.alarmCheck.Text = "Alarm On";
            this.alarmCheck.UseVisualStyleBackColor = true;
            this.alarmCheck.CheckedChanged += new System.EventHandler(this.alarmOnCheck_CheckedChanged);
            // 
            // alarmTimer
            // 
            this.alarmTimer.Interval = 3000;
            this.alarmTimer.Tick += new System.EventHandler(this.alarmTimer_Tick);
            // 
            // labelImage
            // 
            this.labelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelImage.Image = ((System.Drawing.Image)(resources.GetObject("labelImage.Image")));
            this.labelImage.Location = new System.Drawing.Point(515, 25);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(248, 214);
            this.labelImage.TabIndex = 2;
            this.labelImage.ClientSizeChanged += new System.EventHandler(this.alarmTimer_Tick);
            this.labelImage.DockChanged += new System.EventHandler(this.alarmTimer_Tick);
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.stopAlarmButton);
            this.Controls.Add(this.currentTimeLabel);
            this.Name = "Form1";
            this.Text = "Alarm Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Button stopAlarmButton;
        private System.Windows.Forms.TextBox alarmSetBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox alarmCheck;
        private System.Windows.Forms.Timer alarmTimer;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Timer clockTimer;
    }
}

