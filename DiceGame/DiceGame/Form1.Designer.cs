
namespace DiceGame
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
            this.txtf_puan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_oyuncu1 = new System.Windows.Forms.Button();
            this.button_oyuncu2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_oyncu1 = new System.Windows.Forms.Label();
            this.label_oyncu2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_tekrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyun Kaç Puanda Bitsin?";
            // 
            // txtf_puan
            // 
            this.txtf_puan.Location = new System.Drawing.Point(287, 12);
            this.txtf_puan.Name = "txtf_puan";
            this.txtf_puan.Size = new System.Drawing.Size(100, 20);
            this.txtf_puan.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 140);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(255, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 140);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button_oyuncu1
            // 
            this.button_oyuncu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_oyuncu1.Location = new System.Drawing.Point(33, 278);
            this.button_oyuncu1.Name = "button_oyuncu1";
            this.button_oyuncu1.Size = new System.Drawing.Size(158, 36);
            this.button_oyuncu1.TabIndex = 4;
            this.button_oyuncu1.Text = "Oyuncu 1";
            this.button_oyuncu1.UseVisualStyleBackColor = true;
            this.button_oyuncu1.Click += new System.EventHandler(this.button_oyuncu1_Click);
            // 
            // button_oyuncu2
            // 
            this.button_oyuncu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_oyuncu2.Location = new System.Drawing.Point(255, 278);
            this.button_oyuncu2.Name = "button_oyuncu2";
            this.button_oyuncu2.Size = new System.Drawing.Size(158, 36);
            this.button_oyuncu2.TabIndex = 5;
            this.button_oyuncu2.Text = "Oyuncu 2";
            this.button_oyuncu2.UseVisualStyleBackColor = true;
            this.button_oyuncu2.Click += new System.EventHandler(this.button_oyuncu2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Oyuncu 1: ";
            // 
            // label_oyncu1
            // 
            this.label_oyncu1.AutoSize = true;
            this.label_oyncu1.Location = new System.Drawing.Point(156, 259);
            this.label_oyncu1.Name = "label_oyncu1";
            this.label_oyncu1.Size = new System.Drawing.Size(13, 13);
            this.label_oyncu1.TabIndex = 7;
            this.label_oyncu1.Text = "0";
            // 
            // label_oyncu2
            // 
            this.label_oyncu2.AutoSize = true;
            this.label_oyncu2.Location = new System.Drawing.Point(375, 259);
            this.label_oyncu2.Name = "label_oyncu2";
            this.label_oyncu2.Size = new System.Drawing.Size(13, 13);
            this.label_oyncu2.TabIndex = 9;
            this.label_oyncu2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Oyuncu 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(141, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Oyuncu 1 Kazandı";
            // 
            // button_tekrar
            // 
            this.button_tekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_tekrar.Location = new System.Drawing.Point(121, 368);
            this.button_tekrar.Name = "button_tekrar";
            this.button_tekrar.Size = new System.Drawing.Size(199, 36);
            this.button_tekrar.TabIndex = 11;
            this.button_tekrar.Text = "Oyuna Tekrar Başla";
            this.button_tekrar.UseVisualStyleBackColor = true;
            this.button_tekrar.Click += new System.EventHandler(this.button_tekrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 433);
            this.Controls.Add(this.button_tekrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_oyncu2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_oyncu1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_oyuncu2);
            this.Controls.Add(this.button_oyuncu1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtf_puan);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtf_puan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_oyuncu1;
        private System.Windows.Forms.Button button_oyuncu2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_oyncu1;
        private System.Windows.Forms.Label label_oyncu2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_tekrar;
    }
}

