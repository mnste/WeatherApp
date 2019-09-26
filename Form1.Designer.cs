namespace WeatherApp
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sunset = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.lbl_sunrise = new System.Windows.Forms.Label();
            this.lbl_sunset = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_humidity = new System.Windows.Forms.Label();
            this.lbl_windspeed = new System.Windows.Forms.Label();
            this.lbl_pressure = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_icon = new System.Windows.Forms.PictureBox();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_dateTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Title.Location = new System.Drawing.Point(13, 13);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(97, 51);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "ILM";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.48148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_sunrise, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_sunset, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sunrise, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sunset, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(556, 243);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 51);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // sunset
            // 
            this.sunset.AutoSize = true;
            this.sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunset.Location = new System.Drawing.Point(3, 25);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(130, 25);
            this.sunset.TabIndex = 0;
            this.sunset.Text = "Päike loojub";
            // 
            // sunrise
            // 
            this.sunrise.AutoSize = true;
            this.sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunrise.Location = new System.Drawing.Point(3, 0);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(137, 25);
            this.sunrise.TabIndex = 1;
            this.sunrise.Text = "Päike tõuseb";
            // 
            // lbl_sunrise
            // 
            this.lbl_sunrise.AutoSize = true;
            this.lbl_sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sunrise.Location = new System.Drawing.Point(180, 0);
            this.lbl_sunrise.Name = "lbl_sunrise";
            this.lbl_sunrise.Size = new System.Drawing.Size(67, 25);
            this.lbl_sunrise.TabIndex = 2;
            this.lbl_sunrise.Text = "06:50";
            // 
            // lbl_sunset
            // 
            this.lbl_sunset.AutoSize = true;
            this.lbl_sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sunset.Location = new System.Drawing.Point(180, 25);
            this.lbl_sunset.Name = "lbl_sunset";
            this.lbl_sunset.Size = new System.Drawing.Size(67, 25);
            this.lbl_sunset.TabIndex = 3;
            this.lbl_sunset.Text = "20:02";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.58823F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.41177F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_humidity, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_windspeed);
            this.tableLayoutPanel2.Controls.Add(this.lbl_pressure, 1, 2);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(556, 329);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.72727F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.27273F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(340, 169);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Õhuniiskus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tuul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Õhurõhk";
            // 
            // lbl_humidity
            // 
            this.lbl_humidity.AutoSize = true;
            this.lbl_humidity.Location = new System.Drawing.Point(174, 0);
            this.lbl_humidity.Name = "lbl_humidity";
            this.lbl_humidity.Size = new System.Drawing.Size(70, 25);
            this.lbl_humidity.TabIndex = 3;
            this.lbl_humidity.Text = "label5";
            // 
            // lbl_windspeed
            // 
            this.lbl_windspeed.AutoSize = true;
            this.lbl_windspeed.Location = new System.Drawing.Point(174, 29);
            this.lbl_windspeed.Name = "lbl_windspeed";
            this.lbl_windspeed.Size = new System.Drawing.Size(70, 25);
            this.lbl_windspeed.TabIndex = 4;
            this.lbl_windspeed.Text = "label6";
            // 
            // lbl_pressure
            // 
            this.lbl_pressure.AutoSize = true;
            this.lbl_pressure.Location = new System.Drawing.Point(174, 55);
            this.lbl_pressure.Name = "lbl_pressure";
            this.lbl_pressure.Size = new System.Drawing.Size(70, 25);
            this.lbl_pressure.TabIndex = 5;
            this.lbl_pressure.Text = "label7";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.BackColor = System.Drawing.Color.Transparent;
            this.lbl_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_City.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_City.Location = new System.Drawing.Point(23, 112);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(96, 44);
            this.lbl_City.TabIndex = 3;
            this.lbl_City.Text = "Linn";
            // 
            // lbl_icon
            // 
            this.lbl_icon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_icon.BackgroundImage = global::WeatherApp.Properties.Resources.Sun_Behind_Clouds;
            this.lbl_icon.Image = global::WeatherApp.Properties.Resources.Cloud___Lightning;
            this.lbl_icon.Location = new System.Drawing.Point(3, 162);
            this.lbl_icon.Name = "lbl_icon";
            this.lbl_icon.Size = new System.Drawing.Size(215, 159);
            this.lbl_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbl_icon.TabIndex = 5;
            this.lbl_icon.TabStop = false;
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_temp.Location = new System.Drawing.Point(3, 115);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(64, 44);
            this.lbl_temp.TabIndex = 3;
            this.lbl_temp.Text = "18";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_desc.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_desc.Location = new System.Drawing.Point(-3, 31);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(108, 32);
            this.lbl_desc.TabIndex = 6;
            this.lbl_desc.Text = "Pilvine";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_temp);
            this.panel1.Controls.Add(this.lbl_desc);
            this.panel1.Controls.Add(this.lbl_icon);
            this.panel1.Location = new System.Drawing.Point(31, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 323);
            this.panel1.TabIndex = 7;
            // 
            // lbl_dateTime
            // 
            this.lbl_dateTime.AutoSize = true;
            this.lbl_dateTime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_dateTime.Location = new System.Drawing.Point(31, 160);
            this.lbl_dateTime.Name = "lbl_dateTime";
            this.lbl_dateTime.Size = new System.Drawing.Size(52, 18);
            this.lbl_dateTime.TabIndex = 8;
            this.lbl_dateTime.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WeatherApp.Properties.Resources.Sky;
            this.ClientSize = new System.Drawing.Size(925, 635);
            this.Controls.Add(this.lbl_dateTime);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.PictureBox lbl_icon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label lbl_sunrise;
        private System.Windows.Forms.Label lbl_sunset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_humidity;
        private System.Windows.Forms.Label lbl_windspeed;
        private System.Windows.Forms.Label lbl_pressure;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_dateTime;
    }
}

