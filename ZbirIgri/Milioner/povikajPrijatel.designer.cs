namespace ZbirIgri
{
    partial class povikajPrijatel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelaProcent = new System.Windows.Forms.Label();
            this.labelOdgovor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // labelaProcent
            // 
            this.labelaProcent.AutoSize = true;
            this.labelaProcent.Location = new System.Drawing.Point(12, 142);
            this.labelaProcent.Name = "labelaProcent";
            this.labelaProcent.Size = new System.Drawing.Size(0, 17);
            this.labelaProcent.TabIndex = 2;
            // 
            // labelOdgovor
            // 
            this.labelOdgovor.AutoSize = true;
            this.labelOdgovor.Location = new System.Drawing.Point(332, 40);
            this.labelOdgovor.Name = "labelOdgovor";
            this.labelOdgovor.Size = new System.Drawing.Size(0, 17);
            this.labelOdgovor.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Откажи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // povikajPrijatel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelOdgovor);
            this.Controls.Add(this.labelaProcent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "povikajPrijatel";
            this.Text = "Повикај Пријател";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelaProcent;
        private System.Windows.Forms.Label labelOdgovor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}