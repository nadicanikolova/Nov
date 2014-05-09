namespace ZbirIgri
{
    partial class RPSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPSForm));
            this.listaRezultati = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelaWinner = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.poeniPlayer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.poeniPC = new System.Windows.Forms.Label();
            this.zatvori = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbMyChoise = new System.Windows.Forms.PictureBox();
            this.pbComputerChoise = new System.Windows.Forms.PictureBox();
            this.btPaper = new System.Windows.Forms.Button();
            this.btScissors = new System.Windows.Forms.Button();
            this.btRock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyChoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerChoise)).BeginInit();
            this.SuspendLayout();
            // 
            // listaRezultati
            // 
            this.listaRezultati.FormattingEnabled = true;
            this.listaRezultati.Location = new System.Drawing.Point(512, 70);
            this.listaRezultati.Margin = new System.Windows.Forms.Padding(2);
            this.listaRezultati.Name = "listaRezultati";
            this.listaRezultati.Size = new System.Drawing.Size(153, 303);
            this.listaRezultati.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(482, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Резултат: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(337, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Компјутерот избра:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(85, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ти избра: ";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(215, 361);
            this.btReset.Margin = new System.Windows.Forms.Padding(2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(89, 31);
            this.btReset.TabIndex = 9;
            this.btReset.Text = "Ресетирај";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(172, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Победил:";
            // 
            // labelaWinner
            // 
            this.labelaWinner.AutoSize = true;
            this.labelaWinner.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelaWinner.Location = new System.Drawing.Point(244, 179);
            this.labelaWinner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelaWinner.Name = "labelaWinner";
            this.labelaWinner.Padding = new System.Windows.Forms.Padding(3);
            this.labelaWinner.Size = new System.Drawing.Size(6, 19);
            this.labelaWinner.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(510, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Историја на играње:";
            // 
            // poeniPlayer
            // 
            this.poeniPlayer.AutoSize = true;
            this.poeniPlayer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.poeniPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poeniPlayer.Location = new System.Drawing.Point(574, 7);
            this.poeniPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.poeniPlayer.Name = "poeniPlayer";
            this.poeniPlayer.Size = new System.Drawing.Size(15, 16);
            this.poeniPlayer.TabIndex = 13;
            this.poeniPlayer.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(609, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = ":";
            // 
            // poeniPC
            // 
            this.poeniPC.AutoSize = true;
            this.poeniPC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.poeniPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poeniPC.Location = new System.Drawing.Point(637, 7);
            this.poeniPC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.poeniPC.Name = "poeniPC";
            this.poeniPC.Size = new System.Drawing.Size(15, 16);
            this.poeniPC.TabIndex = 15;
            this.poeniPC.Text = "0";
            // 
            // zatvori
            // 
            this.zatvori.Location = new System.Drawing.Point(512, 378);
            this.zatvori.Margin = new System.Windows.Forms.Padding(2);
            this.zatvori.Name = "zatvori";
            this.zatvori.Size = new System.Drawing.Size(152, 33);
            this.zatvori.TabIndex = 16;
            this.zatvori.Text = "Затвори прозорец";
            this.zatvori.UseVisualStyleBackColor = true;
            this.zatvori.Click += new System.EventHandler(this.zatvori_Click);
            // 
            // pbMyChoise
            // 
            this.pbMyChoise.Location = new System.Drawing.Point(50, 215);
            this.pbMyChoise.Margin = new System.Windows.Forms.Padding(2);
            this.pbMyChoise.Name = "pbMyChoise";
            this.pbMyChoise.Size = new System.Drawing.Size(134, 134);
            this.pbMyChoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMyChoise.TabIndex = 8;
            this.pbMyChoise.TabStop = false;
            // 
            // pbComputerChoise
            // 
            this.pbComputerChoise.Location = new System.Drawing.Point(325, 215);
            this.pbComputerChoise.Margin = new System.Windows.Forms.Padding(2);
            this.pbComputerChoise.Name = "pbComputerChoise";
            this.pbComputerChoise.Size = new System.Drawing.Size(134, 134);
            this.pbComputerChoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComputerChoise.TabIndex = 7;
            this.pbComputerChoise.TabStop = false;
            // 
            // btPaper
            // 
            this.btPaper.Image = global::ZbirIgri.Properties.Resources.paper;
            this.btPaper.Location = new System.Drawing.Point(344, 20);
            this.btPaper.Margin = new System.Windows.Forms.Padding(2);
            this.btPaper.Name = "btPaper";
            this.btPaper.Size = new System.Drawing.Size(134, 134);
            this.btPaper.TabIndex = 2;
            this.btPaper.UseVisualStyleBackColor = true;
            this.btPaper.Click += new System.EventHandler(this.btPaper_Click);
            // 
            // btScissors
            // 
            this.btScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btScissors.Image = global::ZbirIgri.Properties.Resources.scissors;
            this.btScissors.Location = new System.Drawing.Point(174, 20);
            this.btScissors.Margin = new System.Windows.Forms.Padding(2);
            this.btScissors.Name = "btScissors";
            this.btScissors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btScissors.Size = new System.Drawing.Size(130, 134);
            this.btScissors.TabIndex = 1;
            this.btScissors.UseVisualStyleBackColor = true;
            this.btScissors.Click += new System.EventHandler(this.btScissors_Click);
            // 
            // btRock
            // 
            this.btRock.Image = global::ZbirIgri.Properties.Resources.rock;
            this.btRock.Location = new System.Drawing.Point(9, 20);
            this.btRock.Margin = new System.Windows.Forms.Padding(2);
            this.btRock.Name = "btRock";
            this.btRock.Size = new System.Drawing.Size(128, 134);
            this.btRock.TabIndex = 0;
            this.btRock.UseVisualStyleBackColor = true;
            this.btRock.Click += new System.EventHandler(this.btRock_Click);
            // 
            // RPSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 422);
            this.Controls.Add(this.zatvori);
            this.Controls.Add(this.poeniPC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.poeniPlayer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelaWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.pbMyChoise);
            this.Controls.Add(this.pbComputerChoise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaRezultati);
            this.Controls.Add(this.btPaper);
            this.Controls.Add(this.btScissors);
            this.Controls.Add(this.btRock);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RPSForm";
            this.Text = "Rock,scissors,paper";
            ((System.ComponentModel.ISupportInitialize)(this.pbMyChoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerChoise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRock;
        private System.Windows.Forms.Button btScissors;
        private System.Windows.Forms.Button btPaper;
        private System.Windows.Forms.ListBox listaRezultati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbComputerChoise;
        private System.Windows.Forms.PictureBox pbMyChoise;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelaWinner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label poeniPlayer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label poeniPC;
        private System.Windows.Forms.Button zatvori;
        private System.Windows.Forms.Timer timer1;
    }
}