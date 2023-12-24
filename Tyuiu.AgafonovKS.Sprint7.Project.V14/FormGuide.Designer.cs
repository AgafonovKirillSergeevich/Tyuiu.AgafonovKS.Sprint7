
namespace Tyuiu.AgafonovKS.Sprint7.Project.V14
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.labelGuide_AKS = new System.Windows.Forms.Label();
            this.buttonClose_AKS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGuide_AKS
            // 
            this.labelGuide_AKS.AutoSize = true;
            this.labelGuide_AKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuide_AKS.Location = new System.Drawing.Point(7, 8);
            this.labelGuide_AKS.Name = "labelGuide_AKS";
            this.labelGuide_AKS.Size = new System.Drawing.Size(762, 360);
            this.labelGuide_AKS.TabIndex = 0;
            this.labelGuide_AKS.Text = resources.GetString("labelGuide_AKS.Text");
            // 
            // buttonClose_AKS
            // 
            this.buttonClose_AKS.Location = new System.Drawing.Point(610, 342);
            this.buttonClose_AKS.Name = "buttonClose_AKS";
            this.buttonClose_AKS.Size = new System.Drawing.Size(198, 49);
            this.buttonClose_AKS.TabIndex = 1;
            this.buttonClose_AKS.Text = "Закрыть";
            this.buttonClose_AKS.UseVisualStyleBackColor = true;
            this.buttonClose_AKS.Click += new System.EventHandler(this.buttonClose_AKS_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 403);
            this.Controls.Add(this.buttonClose_AKS);
            this.Controls.Add(this.labelGuide_AKS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(865, 450);
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о проекте";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGuide_AKS;
        private System.Windows.Forms.Button buttonClose_AKS;
    }
}