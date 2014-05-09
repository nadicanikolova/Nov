namespace ZbirIgri
{
    partial class ZmijaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZmijaForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.nova = new System.Windows.Forms.Label();
            this.zatvori = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(502, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поени:";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPoeni.Location = new System.Drawing.Point(558, 136);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(15, 24);
            this.lblPoeni.TabIndex = 2;
            this.lblPoeni.Text = " ";
            // 
            // nova
            // 
            this.nova.AutoSize = true;
            this.nova.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nova.Image = ((System.Drawing.Image)(resources.GetObject("nova.Image")));
            this.nova.Location = new System.Drawing.Point(454, 390);
            this.nova.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nova.Name = "nova";
            this.nova.Padding = new System.Windows.Forms.Padding(5);
            this.nova.Size = new System.Drawing.Size(96, 30);
            this.nova.TabIndex = 3;
            this.nova.Text = "Нова игра";
            this.nova.Click += new System.EventHandler(this.nova_Click);
            this.nova.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zatvori_MouseDown);
            this.nova.MouseEnter += new System.EventHandler(this.nova_MouseEnter);
            this.nova.MouseLeave += new System.EventHandler(this.nova_MouseLeave);
            this.nova.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zatvori_MouseUp);
            // 
            // zatvori
            // 
            this.zatvori.AutoSize = true;
            this.zatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zatvori.Image = ((System.Drawing.Image)(resources.GetObject("zatvori.Image")));
            this.zatvori.Location = new System.Drawing.Point(598, 390);
            this.zatvori.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.zatvori.Name = "zatvori";
            this.zatvori.Padding = new System.Windows.Forms.Padding(5);
            this.zatvori.Size = new System.Drawing.Size(84, 30);
            this.zatvori.TabIndex = 5;
            this.zatvori.Text = "Затвори";
            this.zatvori.Click += new System.EventHandler(this.zatvori_Click);
            this.zatvori.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zatvori_MouseDown);
            this.zatvori.MouseEnter += new System.EventHandler(this.nova_MouseEnter);
            this.zatvori.MouseLeave += new System.EventHandler(this.nova_MouseLeave);
            this.zatvori.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zatvori_MouseUp);
            // 
            // ZmijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 444);
            this.Controls.Add(this.zatvori);
            this.Controls.Add(this.nova);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ZmijaForm";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoeni;
        
        private System.Windows.Forms.Label nova;
        private System.Windows.Forms.Label zatvori;
    }
}