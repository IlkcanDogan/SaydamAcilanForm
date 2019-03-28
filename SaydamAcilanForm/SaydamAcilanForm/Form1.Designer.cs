namespace SaydamAcilanForm
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
            this.components = new System.ComponentModel.Container();
            this.timerAcilis = new System.Windows.Forms.Timer(this.components);
            this.timerKapanis = new System.Windows.Forms.Timer(this.components);
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerAcilis
            // 
            this.timerAcilis.Tick += new System.EventHandler(this.timerAcilis_Tick);
            // 
            // timerKapanis
            // 
            this.timerKapanis.Tick += new System.EventHandler(this.timerKapanis_Tick);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(58, 62);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(161, 79);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Programı Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 203);
            this.Controls.Add(this.btnKapat);
            this.Name = "Form1";
            this.Opacity = 0D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerAcilis;
        private System.Windows.Forms.Timer timerKapanis;
        private System.Windows.Forms.Button btnKapat;
    }
}

