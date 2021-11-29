
namespace BilgiYarismasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonsonraki = new System.Windows.Forms.Button();
            this.labelyanlıs = new System.Windows.Forms.Label();
            this.labeldogru = new System.Windows.Forms.Label();
            this.labelsoruno = new System.Windows.Forms.Label();
            this.picturedogru = new System.Windows.Forms.PictureBox();
            this.pictureyanlis = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturedogru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureyanlis)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.IndianRed;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.richTextBox1.Location = new System.Drawing.Point(40, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(541, 147);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.IndianRed;
            this.buttonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonA.Location = new System.Drawing.Point(70, 184);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(173, 34);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.IndianRed;
            this.buttonB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonB.Location = new System.Drawing.Point(324, 184);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(176, 34);
            this.buttonB.TabIndex = 2;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.IndianRed;
            this.buttonD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonD.Location = new System.Drawing.Point(324, 238);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(176, 34);
            this.buttonD.TabIndex = 3;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.IndianRed;
            this.buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonC.Location = new System.Drawing.Point(70, 238);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(173, 34);
            this.buttonC.TabIndex = 4;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(661, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(661, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(661, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış:";
            // 
            // buttonsonraki
            // 
            this.buttonsonraki.BackColor = System.Drawing.Color.IndianRed;
            this.buttonsonraki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonsonraki.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonsonraki.Location = new System.Drawing.Point(666, 144);
            this.buttonsonraki.Name = "buttonsonraki";
            this.buttonsonraki.Size = new System.Drawing.Size(80, 34);
            this.buttonsonraki.TabIndex = 8;
            this.buttonsonraki.Text = "Sonraki";
            this.buttonsonraki.UseVisualStyleBackColor = false;
            this.buttonsonraki.Click += new System.EventHandler(this.buttonsonraki_Click);
            // 
            // labelyanlıs
            // 
            this.labelyanlıs.AutoSize = true;
            this.labelyanlıs.BackColor = System.Drawing.Color.IndianRed;
            this.labelyanlıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelyanlıs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelyanlıs.Location = new System.Drawing.Point(751, 102);
            this.labelyanlıs.Name = "labelyanlıs";
            this.labelyanlıs.Size = new System.Drawing.Size(24, 25);
            this.labelyanlıs.TabIndex = 11;
            this.labelyanlıs.Text = "0";
            // 
            // labeldogru
            // 
            this.labeldogru.AutoSize = true;
            this.labeldogru.BackColor = System.Drawing.Color.IndianRed;
            this.labeldogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldogru.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labeldogru.Location = new System.Drawing.Point(751, 68);
            this.labeldogru.Name = "labeldogru";
            this.labeldogru.Size = new System.Drawing.Size(24, 25);
            this.labeldogru.TabIndex = 10;
            this.labeldogru.Text = "0";
            // 
            // labelsoruno
            // 
            this.labelsoruno.AutoSize = true;
            this.labelsoruno.BackColor = System.Drawing.Color.IndianRed;
            this.labelsoruno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsoruno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelsoruno.Location = new System.Drawing.Point(751, 32);
            this.labelsoruno.Name = "labelsoruno";
            this.labelsoruno.Size = new System.Drawing.Size(24, 25);
            this.labelsoruno.TabIndex = 9;
            this.labelsoruno.Text = "0";
            // 
            // picturedogru
            // 
            this.picturedogru.BackColor = System.Drawing.Color.Transparent;
            this.picturedogru.Image = ((System.Drawing.Image)(resources.GetObject("picturedogru.Image")));
            this.picturedogru.Location = new System.Drawing.Point(589, 200);
            this.picturedogru.Name = "picturedogru";
            this.picturedogru.Size = new System.Drawing.Size(101, 89);
            this.picturedogru.TabIndex = 12;
            this.picturedogru.TabStop = false;
            this.picturedogru.Visible = false;
            // 
            // pictureyanlis
            // 
            this.pictureyanlis.BackColor = System.Drawing.Color.Transparent;
            this.pictureyanlis.Image = ((System.Drawing.Image)(resources.GetObject("pictureyanlis.Image")));
            this.pictureyanlis.Location = new System.Drawing.Point(720, 200);
            this.pictureyanlis.Name = "pictureyanlis";
            this.pictureyanlis.Size = new System.Drawing.Size(101, 89);
            this.pictureyanlis.TabIndex = 13;
            this.pictureyanlis.TabStop = false;
            this.pictureyanlis.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Location = new System.Drawing.Point(420, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Location = new System.Drawing.Point(497, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(862, 349);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureyanlis);
            this.Controls.Add(this.picturedogru);
            this.Controls.Add(this.labelyanlıs);
            this.Controls.Add(this.labeldogru);
            this.Controls.Add(this.labelsoruno);
            this.Controls.Add(this.buttonsonraki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.richTextBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturedogru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureyanlis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonsonraki;
        private System.Windows.Forms.Label labelyanlıs;
        private System.Windows.Forms.Label labeldogru;
        private System.Windows.Forms.Label labelsoruno;
        private System.Windows.Forms.PictureBox picturedogru;
        private System.Windows.Forms.PictureBox pictureyanlis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

