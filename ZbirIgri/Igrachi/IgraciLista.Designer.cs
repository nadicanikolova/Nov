namespace ZbirIgri
{
    partial class IgraciLista
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSimon = new System.Windows.Forms.ListView();
            this.n1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMilioner = new System.Windows.Forms.ListView();
            this.n2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstZmija = new System.Windows.Forms.ListView();
            this.n3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstKamen = new System.Windows.Forms.ListView();
            this.n4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Затвори";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Повторување";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(352, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Милионер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(87, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Змија";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(302, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Камен, лист, ножици";
            // 
            // lstSimon
            // 
            this.lstSimon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.n1,
            this.p1});
            this.lstSimon.Location = new System.Drawing.Point(12, 46);
            this.lstSimon.Name = "lstSimon";
            this.lstSimon.Size = new System.Drawing.Size(230, 168);
            this.lstSimon.TabIndex = 9;
            this.lstSimon.UseCompatibleStateImageBehavior = false;
            this.lstSimon.View = System.Windows.Forms.View.Details;
            // 
            // n1
            // 
            this.n1.Text = "Име";
            this.n1.Width = 136;
            // 
            // p1
            // 
            this.p1.Text = "Поени";
            this.p1.Width = 87;
            // 
            // lstMilioner
            // 
            this.lstMilioner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.n2,
            this.p2});
            this.lstMilioner.Location = new System.Drawing.Point(287, 46);
            this.lstMilioner.Name = "lstMilioner";
            this.lstMilioner.Size = new System.Drawing.Size(230, 168);
            this.lstMilioner.TabIndex = 10;
            this.lstMilioner.UseCompatibleStateImageBehavior = false;
            this.lstMilioner.View = System.Windows.Forms.View.Details;
            // 
            // n2
            // 
            this.n2.Text = "Име";
            this.n2.Width = 130;
            // 
            // p2
            // 
            this.p2.Text = "Поени";
            this.p2.Width = 95;
            // 
            // lstZmija
            // 
            this.lstZmija.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.n3,
            this.p3});
            this.lstZmija.Location = new System.Drawing.Point(12, 262);
            this.lstZmija.Name = "lstZmija";
            this.lstZmija.Size = new System.Drawing.Size(230, 168);
            this.lstZmija.TabIndex = 11;
            this.lstZmija.UseCompatibleStateImageBehavior = false;
            this.lstZmija.View = System.Windows.Forms.View.Details;
            // 
            // n3
            // 
            this.n3.Text = "Име";
            this.n3.Width = 130;
            // 
            // p3
            // 
            this.p3.Text = "Поени";
            this.p3.Width = 95;
            // 
            // lstKamen
            // 
            this.lstKamen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.n4,
            this.p4});
            this.lstKamen.Location = new System.Drawing.Point(287, 262);
            this.lstKamen.Name = "lstKamen";
            this.lstKamen.Size = new System.Drawing.Size(230, 168);
            this.lstKamen.TabIndex = 12;
            this.lstKamen.UseCompatibleStateImageBehavior = false;
            this.lstKamen.View = System.Windows.Forms.View.Details;
            // 
            // n4
            // 
            this.n4.Text = "Име";
            this.n4.Width = 130;
            // 
            // p4
            // 
            this.p4.Text = "Поени";
            this.p4.Width = 95;
            // 
            // IgraciLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 482);
            this.Controls.Add(this.lstKamen);
            this.Controls.Add(this.lstZmija);
            this.Controls.Add(this.lstMilioner);
            this.Controls.Add(this.lstSimon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "IgraciLista";
            this.Text = "IgraciLista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstSimon;
        private System.Windows.Forms.ListView lstMilioner;
        private System.Windows.Forms.ListView lstZmija;
        private System.Windows.Forms.ListView lstKamen;
        private System.Windows.Forms.ColumnHeader n2;
        private System.Windows.Forms.ColumnHeader p2;
        private System.Windows.Forms.ColumnHeader n3;
        private System.Windows.Forms.ColumnHeader p3;
        private System.Windows.Forms.ColumnHeader n4;
        private System.Windows.Forms.ColumnHeader p4;
        private System.Windows.Forms.ColumnHeader n1;
        private System.Windows.Forms.ColumnHeader p1;
    }
}