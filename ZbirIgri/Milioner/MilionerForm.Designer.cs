namespace ZbirIgri
{
    partial class MilionerForm
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
            this.listaSumi = new System.Windows.Forms.ListBox();
            this.buttonNovaIgra = new System.Windows.Forms.Button();
            this.buttonSlednoPrasanje = new System.Windows.Forms.Button();
            this.buttonPovikajPrijatel = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelaPrasanje = new System.Windows.Forms.Label();
            this.buttonOdgovor4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOdgovor3 = new System.Windows.Forms.Button();
            this.buttonOdgovor2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOdgovor1 = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.buttonSeOtkazuva = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // listaSumi
            // 
            this.listaSumi.Enabled = false;
            this.listaSumi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listaSumi.FormattingEnabled = true;
            this.listaSumi.ItemHeight = 20;
            this.listaSumi.Items.AddRange(new object[] {
            "3 000 000",
            "1 000 000",
            "   750 000",
            "   500 000",
            "   200 000",
            "   100 000",
            "     50 000",
            "     35 000",
            "     18 000",
            "     12 000",
            "       5 000",
            "       3 000",
            "       2 000",
            "       1 000",
            "          750"});
            this.listaSumi.Location = new System.Drawing.Point(865, 30);
            this.listaSumi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaSumi.Name = "listaSumi";
            this.listaSumi.Size = new System.Drawing.Size(115, 304);
            this.listaSumi.TabIndex = 0;
            // 
            // buttonNovaIgra
            // 
            this.buttonNovaIgra.Location = new System.Drawing.Point(25, 30);
            this.buttonNovaIgra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNovaIgra.Name = "buttonNovaIgra";
            this.buttonNovaIgra.Size = new System.Drawing.Size(139, 31);
            this.buttonNovaIgra.TabIndex = 2;
            this.buttonNovaIgra.Text = "Нова Игра?";
            this.buttonNovaIgra.UseVisualStyleBackColor = true;
            this.buttonNovaIgra.Click += new System.EventHandler(this.buttonNovaIgra_Click);
            // 
            // buttonSlednoPrasanje
            // 
            this.buttonSlednoPrasanje.Enabled = false;
            this.buttonSlednoPrasanje.Location = new System.Drawing.Point(841, 379);
            this.buttonSlednoPrasanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSlednoPrasanje.Name = "buttonSlednoPrasanje";
            this.buttonSlednoPrasanje.Size = new System.Drawing.Size(139, 52);
            this.buttonSlednoPrasanje.TabIndex = 3;
            this.buttonSlednoPrasanje.Text = "Следно Прашање";
            this.buttonSlednoPrasanje.UseVisualStyleBackColor = true;
            this.buttonSlednoPrasanje.Click += new System.EventHandler(this.buttonSlednoPrasanje_Click);
            this.buttonSlednoPrasanje.MouseEnter += new System.EventHandler(this.buttonSlednoPrasanje_MouseEnter);
            this.buttonSlednoPrasanje.MouseLeave += new System.EventHandler(this.buttonSlednoPrasanje_MouseLeave);
            // 
            // buttonPovikajPrijatel
            // 
            this.buttonPovikajPrijatel.Enabled = false;
            this.buttonPovikajPrijatel.Location = new System.Drawing.Point(693, 185);
            this.buttonPovikajPrijatel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPovikajPrijatel.Name = "buttonPovikajPrijatel";
            this.buttonPovikajPrijatel.Size = new System.Drawing.Size(151, 31);
            this.buttonPovikajPrijatel.TabIndex = 4;
            this.buttonPovikajPrijatel.Text = "Повикај го Томче";
            this.buttonPovikajPrijatel.UseVisualStyleBackColor = true;
            this.buttonPovikajPrijatel.Click += new System.EventHandler(this.buttonPovikajPrijatel_Click);
            this.buttonPovikajPrijatel.MouseHover += new System.EventHandler(this.buttonPovikajPrijatel_MouseHover);
            this.buttonPovikajPrijatel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonPovikajPrijatel_MouseMove);
            // 
            // button50
            // 
            this.button50.Enabled = false;
            this.button50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button50.Location = new System.Drawing.Point(693, 126);
            this.button50.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(151, 31);
            this.button50.TabIndex = 5;
            this.button50.Text = "50:50";
            this.button50.UseVisualStyleBackColor = true;
            this.button50.Click += new System.EventHandler(this.button50_Click);
            this.button50.MouseHover += new System.EventHandler(this.button50_MouseHover);
            this.button50.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button50_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelaPrasanje
            // 
            this.labelaPrasanje.AutoSize = true;
            this.labelaPrasanje.BackColor = System.Drawing.Color.GhostWhite;
            this.labelaPrasanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelaPrasanje.Location = new System.Drawing.Point(232, 295);
            this.labelaPrasanje.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.labelaPrasanje.MaximumSize = new System.Drawing.Size(600, 62);
            this.labelaPrasanje.MinimumSize = new System.Drawing.Size(100, 10);
            this.labelaPrasanje.Name = "labelaPrasanje";
            this.labelaPrasanje.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.labelaPrasanje.Size = new System.Drawing.Size(100, 32);
            this.labelaPrasanje.TabIndex = 10;
            this.labelaPrasanje.Text = "label1";
            this.labelaPrasanje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOdgovor4
            // 
            this.buttonOdgovor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOdgovor4.Location = new System.Drawing.Point(531, 432);
            this.buttonOdgovor4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOdgovor4.Name = "buttonOdgovor4";
            this.buttonOdgovor4.Size = new System.Drawing.Size(240, 48);
            this.buttonOdgovor4.TabIndex = 9;
            this.buttonOdgovor4.Text = "button6";
            this.buttonOdgovor4.UseVisualStyleBackColor = true;
            this.buttonOdgovor4.Click += new System.EventHandler(this.buttonOdgovor4_Click);
            this.buttonOdgovor4.MouseLeave += new System.EventHandler(this.buttonOdgovor4_MouseLeave);
            this.buttonOdgovor4.MouseHover += new System.EventHandler(this.buttonOdgovor4_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(485, 372);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label1.Size = new System.Drawing.Size(39, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "B:";
            // 
            // buttonOdgovor3
            // 
            this.buttonOdgovor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOdgovor3.Location = new System.Drawing.Point(531, 362);
            this.buttonOdgovor3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOdgovor3.Name = "buttonOdgovor3";
            this.buttonOdgovor3.Size = new System.Drawing.Size(240, 48);
            this.buttonOdgovor3.TabIndex = 7;
            this.buttonOdgovor3.Text = "button4";
            this.buttonOdgovor3.UseVisualStyleBackColor = true;
            this.buttonOdgovor3.Click += new System.EventHandler(this.buttonOdgovor3_Click);
            this.buttonOdgovor3.MouseLeave += new System.EventHandler(this.buttonOdgovor3_MouseLeave);
            this.buttonOdgovor3.MouseHover += new System.EventHandler(this.buttonOdgovor3_MouseHover);
            // 
            // buttonOdgovor2
            // 
            this.buttonOdgovor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOdgovor2.Location = new System.Drawing.Point(188, 436);
            this.buttonOdgovor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOdgovor2.Name = "buttonOdgovor2";
            this.buttonOdgovor2.Size = new System.Drawing.Size(213, 48);
            this.buttonOdgovor2.TabIndex = 8;
            this.buttonOdgovor2.Text = "button5";
            this.buttonOdgovor2.UseVisualStyleBackColor = true;
            this.buttonOdgovor2.Click += new System.EventHandler(this.buttonOdgovor2_Click);
            this.buttonOdgovor2.MouseLeave += new System.EventHandler(this.buttonOdgovor2_MouseLeave);
            this.buttonOdgovor2.MouseHover += new System.EventHandler(this.buttonOdgovor2_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.GhostWhite;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(485, 442);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label2.Size = new System.Drawing.Size(40, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "D:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GhostWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(143, 372);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label4.Size = new System.Drawing.Size(39, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "А:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.GhostWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(143, 444);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label3.Size = new System.Drawing.Size(41, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "C:";
            // 
            // buttonOdgovor1
            // 
            this.buttonOdgovor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOdgovor1.Location = new System.Drawing.Point(188, 362);
            this.buttonOdgovor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOdgovor1.Name = "buttonOdgovor1";
            this.buttonOdgovor1.Size = new System.Drawing.Size(213, 48);
            this.buttonOdgovor1.TabIndex = 6;
            this.buttonOdgovor1.Text = "button3";
            this.buttonOdgovor1.UseVisualStyleBackColor = true;
            this.buttonOdgovor1.Click += new System.EventHandler(this.buttonOdgovor1_Click);
            this.buttonOdgovor1.MouseLeave += new System.EventHandler(this.buttonOdgovor1_MouseLeave);
            this.buttonOdgovor1.MouseHover += new System.EventHandler(this.buttonOdgovor1_MouseHover);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(25, 84);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(139, 31);
            this.btnZatvori.TabIndex = 15;
            this.btnZatvori.Text = "Затвори прозорец";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // buttonSeOtkazuva
            // 
            this.buttonSeOtkazuva.Location = new System.Drawing.Point(25, 137);
            this.buttonSeOtkazuva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSeOtkazuva.Name = "buttonSeOtkazuva";
            this.buttonSeOtkazuva.Size = new System.Drawing.Size(137, 32);
            this.buttonSeOtkazuva.TabIndex = 16;
            this.buttonSeOtkazuva.Text = "Се откажувам";
            this.buttonSeOtkazuva.UseVisualStyleBackColor = true;
            this.buttonSeOtkazuva.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Прашај судии";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // pbSlika
            // 
            this.pbSlika.BackgroundImage = global::ZbirIgri.Properties.Resources.fin_mil;
            this.pbSlika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSlika.Location = new System.Drawing.Point(236, 14);
            this.pbSlika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(445, 279);
            this.pbSlika.TabIndex = 1;
            this.pbSlika.TabStop = false;
            // 
            // MilionerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1012, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSeOtkazuva);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelaPrasanje);
            this.Controls.Add(this.buttonOdgovor4);
            this.Controls.Add(this.buttonOdgovor2);
            this.Controls.Add(this.buttonOdgovor3);
            this.Controls.Add(this.buttonOdgovor1);
            this.Controls.Add(this.button50);
            this.Controls.Add(this.buttonPovikajPrijatel);
            this.Controls.Add(this.buttonSlednoPrasanje);
            this.Controls.Add(this.buttonNovaIgra);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.listaSumi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MilionerForm";
            this.Text = "ФИНКИ Милионер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MilionerForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaSumi;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button buttonNovaIgra;
        private System.Windows.Forms.Button buttonSlednoPrasanje;
        private System.Windows.Forms.Button buttonPovikajPrijatel;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelaPrasanje;
        private System.Windows.Forms.Button buttonOdgovor4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOdgovor3;
        private System.Windows.Forms.Button buttonOdgovor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOdgovor1;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button buttonSeOtkazuva;
        private System.Windows.Forms.Button button1;
    }
}