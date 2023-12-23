
namespace Tyuiu.AgafonovKS.Sprint7.Project.V14
{
    partial class FormAbout
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
            this.pictureBoxAvatar_AKS = new System.Windows.Forms.PictureBox();
            this.buttonOK_AKS = new System.Windows.Forms.Button();
            this.labelInfo_AKS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_AKS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_AKS
            // 
            this.pictureBoxAvatar_AKS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxAvatar_AKS.ImageLocation = "C:\\Users\\Kirya\\source\\repos\\Tyuiu.AgafonovKS.Sprint7\\Avatar.jpg";
            this.pictureBoxAvatar_AKS.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_AKS.Name = "pictureBoxAvatar_AKS";
            this.pictureBoxAvatar_AKS.Size = new System.Drawing.Size(150, 200);
            this.pictureBoxAvatar_AKS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_AKS.TabIndex = 0;
            this.pictureBoxAvatar_AKS.TabStop = false;
            // 
            // buttonOK_AKS
            // 
            this.buttonOK_AKS.Location = new System.Drawing.Point(380, 162);
            this.buttonOK_AKS.Name = "buttonOK_AKS";
            this.buttonOK_AKS.Size = new System.Drawing.Size(150, 50);
            this.buttonOK_AKS.TabIndex = 1;
            this.buttonOK_AKS.Text = "OK";
            this.buttonOK_AKS.UseVisualStyleBackColor = true;
            this.buttonOK_AKS.Click += new System.EventHandler(this.buttonOK_AKS_Click);
            // 
            // labelInfo_AKS
            // 
            this.labelInfo_AKS.AutoSize = true;
            this.labelInfo_AKS.Location = new System.Drawing.Point(168, 12);
            this.labelInfo_AKS.Name = "labelInfo_AKS";
            this.labelInfo_AKS.Size = new System.Drawing.Size(363, 119);
            this.labelInfo_AKS.TabIndex = 2;
            this.labelInfo_AKS.Text = "Разработчик: Агафонов К.С.\r\nгруппа ИИПБ-23-1\r\n\r\nПрограмма разработана в рамках из" +
    "учения языка С#\r\n\r\nТюменский индустриальный университет (с)2023\r\nВысшая школа ци" +
    "фровых технологий (с)2023\r\n";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 223);
            this.Controls.Add(this.labelInfo_AKS);
            this.Controls.Add(this.buttonOK_AKS);
            this.Controls.Add(this.pictureBoxAvatar_AKS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 270);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_AKS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_AKS;
        private System.Windows.Forms.Button buttonOK_AKS;
        private System.Windows.Forms.Label labelInfo_AKS;
    }
}