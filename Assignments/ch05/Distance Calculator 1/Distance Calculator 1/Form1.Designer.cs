namespace Distance_Calculator_1
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
            this.exitButton = new System.Windows.Forms.Button();
            this.calButton = new System.Windows.Forms.Button();
            this.hoursLabel = new System.Windows.Forms.ListBox();
            this.hrTextbox = new System.Windows.Forms.TextBox();
            this.mphTextbox = new System.Windows.Forms.TextBox();
            this.hrsLabel = new System.Windows.Forms.Label();
            this.vehLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(559, 355);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 59);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calButton
            // 
            this.calButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calButton.Location = new System.Drawing.Point(168, 355);
            this.calButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(140, 59);
            this.calButton.TabIndex = 12;
            this.calButton.Text = "Calculate";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // hoursLabel
            // 
            this.hoursLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.FormattingEnabled = true;
            this.hoursLabel.ItemHeight = 27;
            this.hoursLabel.Location = new System.Drawing.Point(155, 176);
            this.hoursLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(491, 139);
            this.hoursLabel.TabIndex = 11;
            // 
            // hrTextbox
            // 
            this.hrTextbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrTextbox.Location = new System.Drawing.Point(537, 92);
            this.hrTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hrTextbox.Name = "hrTextbox";
            this.hrTextbox.Size = new System.Drawing.Size(153, 35);
            this.hrTextbox.TabIndex = 10;
            // 
            // mphTextbox
            // 
            this.mphTextbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mphTextbox.Location = new System.Drawing.Point(537, 23);
            this.mphTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mphTextbox.Name = "mphTextbox";
            this.mphTextbox.Size = new System.Drawing.Size(148, 35);
            this.mphTextbox.TabIndex = 9;
            // 
            // hrsLabel
            // 
            this.hrsLabel.AutoSize = true;
            this.hrsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrsLabel.Location = new System.Drawing.Point(150, 98);
            this.hrsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hrsLabel.Name = "hrsLabel";
            this.hrsLabel.Size = new System.Drawing.Size(160, 27);
            this.hrsLabel.TabIndex = 8;
            this.hrsLabel.Text = "Hours Traveled";
            // 
            // vehLabel
            // 
            this.vehLabel.AutoSize = true;
            this.vehLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehLabel.Location = new System.Drawing.Point(150, 29);
            this.vehLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vehLabel.Name = "vehLabel";
            this.vehLabel.Size = new System.Drawing.Size(220, 27);
            this.vehLabel.TabIndex = 7;
            this.vehLabel.Text = "Vehicle Speed in Mpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.hrTextbox);
            this.Controls.Add(this.mphTextbox);
            this.Controls.Add(this.hrsLabel);
            this.Controls.Add(this.vehLabel);
            this.Name = "Form1";
            this.Text = "Distance Calculator ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.ListBox hoursLabel;
        private System.Windows.Forms.TextBox hrTextbox;
        private System.Windows.Forms.TextBox mphTextbox;
        private System.Windows.Forms.Label hrsLabel;
        private System.Windows.Forms.Label vehLabel;
    }
}

