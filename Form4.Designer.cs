namespace Otomata_Proje
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label_head = new System.Windows.Forms.Label();
            this.label_emptyLots = new System.Windows.Forms.Label();
            this.label_stayedHours = new System.Windows.Forms.Label();
            this.label_stayedHours2 = new System.Windows.Forms.Label();
            this.button_pay = new System.Windows.Forms.Button();
            this.label_chargingHours = new System.Windows.Forms.Label();
            this.label_chargingHours2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label_head.Font = new System.Drawing.Font("Stencil", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_head.Location = new System.Drawing.Point(12, 9);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(342, 56);
            this.label_head.TabIndex = 3;
            this.label_head.Text = "Parking App";
            // 
            // label_emptyLots
            // 
            this.label_emptyLots.AutoSize = true;
            this.label_emptyLots.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emptyLots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label_emptyLots.Location = new System.Drawing.Point(46, 96);
            this.label_emptyLots.Name = "label_emptyLots";
            this.label_emptyLots.Size = new System.Drawing.Size(43, 22);
            this.label_emptyLots.TabIndex = 4;
            this.label_emptyLots.Text = "Fee";
            // 
            // label_stayedHours
            // 
            this.label_stayedHours.AutoSize = true;
            this.label_stayedHours.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stayedHours.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_stayedHours.Location = new System.Drawing.Point(46, 243);
            this.label_stayedHours.Name = "label_stayedHours";
            this.label_stayedHours.Size = new System.Drawing.Size(182, 22);
            this.label_stayedHours.TabIndex = 5;
            this.label_stayedHours.Text = "You stayed 0 hours";
            // 
            // label_stayedHours2
            // 
            this.label_stayedHours2.AutoSize = true;
            this.label_stayedHours2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stayedHours2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_stayedHours2.Location = new System.Drawing.Point(274, 241);
            this.label_stayedHours2.Name = "label_stayedHours2";
            this.label_stayedHours2.Size = new System.Drawing.Size(37, 22);
            this.label_stayedHours2.TabIndex = 6;
            this.label_stayedHours2.Text = "0 $";
            // 
            // button_pay
            // 
            this.button_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_pay.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pay.Location = new System.Drawing.Point(229, 424);
            this.button_pay.Name = "button_pay";
            this.button_pay.Size = new System.Drawing.Size(121, 46);
            this.button_pay.TabIndex = 7;
            this.button_pay.Text = "Pay";
            this.button_pay.UseVisualStyleBackColor = false;
            // 
            // label_chargingHours
            // 
            this.label_chargingHours.AutoSize = true;
            this.label_chargingHours.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chargingHours.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_chargingHours.Location = new System.Drawing.Point(46, 289);
            this.label_chargingHours.Name = "label_chargingHours";
            this.label_chargingHours.Size = new System.Drawing.Size(169, 22);
            this.label_chargingHours.TabIndex = 8;
            this.label_chargingHours.Text = "Charging 0 hours";
            // 
            // label_chargingHours2
            // 
            this.label_chargingHours2.AutoSize = true;
            this.label_chargingHours2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chargingHours2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_chargingHours2.Location = new System.Drawing.Point(274, 289);
            this.label_chargingHours2.Name = "label_chargingHours2";
            this.label_chargingHours2.Size = new System.Drawing.Size(37, 22);
            this.label_chargingHours2.TabIndex = 9;
            this.label_chargingHours2.Text = "0 $";
            this.label_chargingHours2.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(213, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "__________";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_total.Location = new System.Drawing.Point(213, 361);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(98, 22);
            this.label_total.TabIndex = 11;
            this.label_total.Text = "Total : 0 $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(60, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "1 hour parking fee: 2$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(60, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "1 hour charging fee: 1$";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(405, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_chargingHours2);
            this.Controls.Add(this.label_chargingHours);
            this.Controls.Add(this.button_pay);
            this.Controls.Add(this.label_stayedHours2);
            this.Controls.Add(this.label_stayedHours);
            this.Controls.Add(this.label_emptyLots);
            this.Controls.Add(this.label_head);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.Label label_emptyLots;
        private System.Windows.Forms.Button button_pay;
        public System.Windows.Forms.Label label_stayedHours;
        public System.Windows.Forms.Label label_stayedHours2;
        public System.Windows.Forms.Label label_chargingHours;
        public System.Windows.Forms.Label label_chargingHours2;
        public System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}