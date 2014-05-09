namespace ZbirIgri
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
            this.label1 = new System.Windows.Forms.Label();
            this.simon = new System.Windows.Forms.Button();
            this.milioner = new System.Windows.Forms.Button();
            this.snake = new System.Windows.Forms.Button();
            this.rps = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIgrachi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(159, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добредојдовте!";
            // 
            // simon
            // 
            this.simon.BackColor = System.Drawing.Color.HotPink;
            this.simon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simon.ForeColor = System.Drawing.Color.Black;
            this.simon.Location = new System.Drawing.Point(37, 214);
            this.simon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simon.Name = "simon";
            this.simon.Size = new System.Drawing.Size(209, 47);
            this.simon.TabIndex = 1;
            this.simon.Text = "Повторување";
            this.simon.UseVisualStyleBackColor = false;
            this.simon.Click += new System.EventHandler(this.simon_Click);
            // 
            // milioner
            // 
            this.milioner.BackColor = System.Drawing.Color.RoyalBlue;
            this.milioner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.milioner.Location = new System.Drawing.Point(289, 214);
            this.milioner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.milioner.Name = "milioner";
            this.milioner.Size = new System.Drawing.Size(209, 47);
            this.milioner.TabIndex = 2;
            this.milioner.Text = "ФИНКИ Милионер";
            this.milioner.UseVisualStyleBackColor = false;
            this.milioner.Click += new System.EventHandler(this.milioner_Click);
            // 
            // snake
            // 
            this.snake.BackColor = System.Drawing.Color.Lime;
            this.snake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.snake.Location = new System.Drawing.Point(37, 298);
            this.snake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.snake.Name = "snake";
            this.snake.Size = new System.Drawing.Size(209, 47);
            this.snake.TabIndex = 3;
            this.snake.Text = "Змија";
            this.snake.UseVisualStyleBackColor = false;
            this.snake.Click += new System.EventHandler(this.snake_Click);
            // 
            // rps
            // 
            this.rps.BackColor = System.Drawing.Color.Salmon;
            this.rps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rps.Location = new System.Drawing.Point(289, 298);
            this.rps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rps.Name = "rps";
            this.rps.Size = new System.Drawing.Size(209, 47);
            this.rps.TabIndex = 4;
            this.rps.Text = "Камен, лист, ножици";
            this.rps.UseVisualStyleBackColor = false;
            this.rps.Click += new System.EventHandler(this.rps_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(51, 142);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(195, 22);
            this.txtIme.TabIndex = 5;
            this.txtIme.Text = "Player";
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Внеси име";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(64, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Внесете име и одберете игра";
            // 
            // btnIgrachi
            // 
            this.btnIgrachi.Location = new System.Drawing.Point(37, 364);
            this.btnIgrachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIgrachi.Name = "btnIgrachi";
            this.btnIgrachi.Size = new System.Drawing.Size(209, 28);
            this.btnIgrachi.TabIndex = 8;
            this.btnIgrachi.Text = "Најдобри играчи";
            this.btnIgrachi.UseVisualStyleBackColor = true;
            this.btnIgrachi.Click += new System.EventHandler(this.btnIgrachi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(289, 364);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(209, 28);
            this.btnZatvori.TabIndex = 9;
            this.btnZatvori.Text = "Затвори";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 407);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnIgrachi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.rps);
            this.Controls.Add(this.snake);
            this.Controls.Add(this.milioner);
            this.Controls.Add(this.simon);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button simon;
        private System.Windows.Forms.Button milioner;
        private System.Windows.Forms.Button snake;
        private System.Windows.Forms.Button rps;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIgrachi;
        private System.Windows.Forms.Button btnZatvori;
    }
}

