namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.button = new System.Windows.Forms.Button();
            this.failsLabel = new System.Windows.Forms.Label();
            this.hitLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button.Location = new System.Drawing.Point(310, 261);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 100);
            this.button.TabIndex = 0;
            this.button.Text = "ПОЙМАЙ МЕНЯ!";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // failsLabel
            // 
            this.failsLabel.AutoSize = true;
            this.failsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.failsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.failsLabel.Location = new System.Drawing.Point(267, 9);
            this.failsLabel.Name = "failsLabel";
            this.failsLabel.Size = new System.Drawing.Size(32, 32);
            this.failsLabel.TabIndex = 1;
            this.failsLabel.Text = "0";
            this.failsLabel.Click += new System.EventHandler(this.failsLabel_Click);
            // 
            // hitLabel
            // 
            this.hitLabel.AutoSize = true;
            this.hitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hitLabel.ForeColor = System.Drawing.Color.Green;
            this.hitLabel.Location = new System.Drawing.Point(392, 9);
            this.hitLabel.Name = "hitLabel";
            this.hitLabel.Size = new System.Drawing.Size(32, 32);
            this.hitLabel.TabIndex = 2;
            this.hitLabel.Text = "0";
            this.hitLabel.Click += new System.EventHandler(this.hitLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.hitLabel);
            this.Controls.Add(this.failsLabel);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label failsLabel;
        private System.Windows.Forms.Label hitLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

