
namespace KoPapirOllo
{
    partial class frmFo
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
            this.lblEredmeny = new System.Windows.Forms.Label();
            this.lblKorCimke = new System.Windows.Forms.Label();
            this.lblKor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOllo = new System.Windows.Forms.Button();
            this.btnPapir = new System.Windows.Forms.Button();
            this.btnKo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEredmeny
            // 
            this.lblEredmeny.Location = new System.Drawing.Point(1, 9);
            this.lblEredmeny.Name = "lblEredmeny";
            this.lblEredmeny.Size = new System.Drawing.Size(468, 26);
            this.lblEredmeny.TabIndex = 1;
            this.lblEredmeny.Text = "Játékeredmények: 0 - 0";
            this.lblEredmeny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKorCimke
            // 
            this.lblKorCimke.Location = new System.Drawing.Point(1, 199);
            this.lblKorCimke.Name = "lblKorCimke";
            this.lblKorCimke.Size = new System.Drawing.Size(468, 26);
            this.lblKorCimke.TabIndex = 1;
            this.lblKorCimke.Text = "Kör:";
            this.lblKorCimke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKor
            // 
            this.lblKor.Location = new System.Drawing.Point(1, 243);
            this.lblKor.Name = "lblKor";
            this.lblKor.Size = new System.Drawing.Size(468, 26);
            this.lblKor.TabIndex = 1;
            this.lblKor.Text = "Kő - Olló";
            this.lblKor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KoPapirOllo.Properties.Resources.human;
            this.pictureBox1.Location = new System.Drawing.Point(175, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnOllo
            // 
            this.btnOllo.BackgroundImage = global::KoPapirOllo.Properties.Resources.ollo;
            this.btnOllo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOllo.Location = new System.Drawing.Point(312, 66);
            this.btnOllo.Name = "btnOllo";
            this.btnOllo.Size = new System.Drawing.Size(100, 100);
            this.btnOllo.TabIndex = 0;
            this.btnOllo.UseVisualStyleBackColor = true;
            // 
            // btnPapir
            // 
            this.btnPapir.BackgroundImage = global::KoPapirOllo.Properties.Resources.papir;
            this.btnPapir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapir.Location = new System.Drawing.Point(184, 66);
            this.btnPapir.Name = "btnPapir";
            this.btnPapir.Size = new System.Drawing.Size(100, 100);
            this.btnPapir.TabIndex = 0;
            this.btnPapir.UseVisualStyleBackColor = true;
            // 
            // btnKo
            // 
            this.btnKo.BackgroundImage = global::KoPapirOllo.Properties.Resources.ko;
            this.btnKo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKo.Location = new System.Drawing.Point(59, 66);
            this.btnKo.Name = "btnKo";
            this.btnKo.Size = new System.Drawing.Size(100, 100);
            this.btnKo.TabIndex = 0;
            this.btnKo.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KoPapirOllo.Properties.Resources.machine;
            this.pictureBox2.Location = new System.Drawing.Point(245, 284);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 356);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKor);
            this.Controls.Add(this.lblKorCimke);
            this.Controls.Add(this.lblEredmeny);
            this.Controls.Add(this.btnOllo);
            this.Controls.Add(this.btnPapir);
            this.Controls.Add(this.btnKo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kő - Papír - Olló";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKo;
        private System.Windows.Forms.Button btnPapir;
        private System.Windows.Forms.Button btnOllo;
        private System.Windows.Forms.Label lblEredmeny;
        private System.Windows.Forms.Label lblKorCimke;
        private System.Windows.Forms.Label lblKor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

