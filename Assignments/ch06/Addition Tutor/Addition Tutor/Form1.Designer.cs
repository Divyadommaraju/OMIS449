namespace Addition_Tutor
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
            this.genButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.chButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Labelnum1 = new System.Windows.Forms.Label();
            this.ansTextbox = new System.Windows.Forms.TextBox();
            this.Labelnum2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // genButton
            // 
            this.genButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genButton.Location = new System.Drawing.Point(32, 308);
            this.genButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(204, 53);
            this.genButton.TabIndex = 17;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(570, 308);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(167, 53);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // chButton
            // 
            this.chButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chButton.Location = new System.Drawing.Point(289, 308);
            this.chButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chButton.Name = "chButton";
            this.chButton.Size = new System.Drawing.Size(222, 53);
            this.chButton.TabIndex = 15;
            this.chButton.Text = "Check Answer";
            this.chButton.UseVisualStyleBackColor = true;
            this.chButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "+";
            // 
            // Labelnum1
            // 
            this.Labelnum1.AutoSize = true;
            this.Labelnum1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelnum1.Location = new System.Drawing.Point(166, 155);
            this.Labelnum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Labelnum1.Name = "Labelnum1";
            this.Labelnum1.Size = new System.Drawing.Size(52, 27);
            this.Labelnum1.TabIndex = 13;
            this.Labelnum1.Text = "????";
            // 
            // ansTextbox
            // 
            this.ansTextbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansTextbox.Location = new System.Drawing.Point(523, 147);
            this.ansTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ansTextbox.Name = "ansTextbox";
            this.ansTextbox.Size = new System.Drawing.Size(148, 35);
            this.ansTextbox.TabIndex = 12;
            // 
            // Labelnum2
            // 
            this.Labelnum2.AutoSize = true;
            this.Labelnum2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelnum2.Location = new System.Drawing.Point(346, 155);
            this.Labelnum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Labelnum2.Name = "Labelnum2";
            this.Labelnum2.Size = new System.Drawing.Size(52, 27);
            this.Labelnum2.TabIndex = 11;
            this.Labelnum2.Text = "????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.chButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Labelnum1);
            this.Controls.Add(this.ansTextbox);
            this.Controls.Add(this.Labelnum2);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button chButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Labelnum1;
        private System.Windows.Forms.TextBox ansTextbox;
        private System.Windows.Forms.Label Labelnum2;
        private System.Windows.Forms.Label label2;
    }
}

