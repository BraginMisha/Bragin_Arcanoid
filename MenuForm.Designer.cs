namespace Bragin_Arcanoid
{
    partial class MenuForm
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
            this.butStart = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butStart
            // 
            this.butStart.BackColor = System.Drawing.SystemColors.Control;
            this.butStart.FlatAppearance.BorderSize = 0;
            this.butStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butStart.Location = new System.Drawing.Point(12, 12);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(322, 72);
            this.butStart.TabIndex = 6;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = false;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.SystemColors.Control;
            this.butExit.FlatAppearance.BorderSize = 0;
            this.butExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExit.Location = new System.Drawing.Point(12, 168);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(322, 72);
            this.butExit.TabIndex = 9;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.textBox1.Location = new System.Drawing.Point(340, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(428, 233);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "\r\nКогда нажмете на кнопку Start вы начнете игру!\r\n\r\nНажмите на кнопку мыши, чтобы" +
    " запустить мячик!\r\n\r\nЧтобы выйти из игры нажмите кнопку Esc!\r\n\r\nПриятной игры!!!" +
    "";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 257);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(800, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.TextBox textBox1;
    }
}