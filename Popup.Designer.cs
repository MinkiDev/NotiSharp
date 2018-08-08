using System;

namespace NotiSharp
{
    partial class Popup
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
            this.InnerPane = new System.Windows.Forms.Panel();
            this.ContentArea = new System.Windows.Forms.Label();
            this.PopupLogo = new System.Windows.Forms.PictureBox();
            this.InnerPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // InnerPane
            // 
            this.InnerPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InnerPane.Controls.Add(this.ContentArea);
            this.InnerPane.Controls.Add(this.PopupLogo);
            this.InnerPane.Location = new System.Drawing.Point(5, 5);
            this.InnerPane.Name = "InnerPane";
            this.InnerPane.Size = new System.Drawing.Size(490, 90);
            this.InnerPane.TabIndex = 0;
            this.InnerPane.Click += new System.EventHandler(this.InnerPane_Click);
            // 
            // ContentArea
            // 
            this.ContentArea.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ContentArea.ForeColor = System.Drawing.Color.White;
            this.ContentArea.Location = new System.Drawing.Point(85, 13);
            this.ContentArea.MinimumSize = new System.Drawing.Size(390, 64);
            this.ContentArea.Name = "ContentArea";
            this.ContentArea.Size = new System.Drawing.Size(390, 64);
            this.ContentArea.TabIndex = 0;
            this.ContentArea.Click += new System.EventHandler(this.ContentArea_Click);
            // 
            // PopupLogo
            // 
            this.PopupLogo.ErrorImage = null;
            this.PopupLogo.InitialImage = null;
            this.PopupLogo.Location = new System.Drawing.Point(13, 13);
            this.PopupLogo.Name = "PopupLogo";
            this.PopupLogo.Size = new System.Drawing.Size(64, 64);
            this.PopupLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PopupLogo.TabIndex = 5;
            this.PopupLogo.TabStop = false;
            this.PopupLogo.Click += new System.EventHandler(this.PopupLogo_Click);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(500, 100);
            this.Controls.Add(this.InnerPane);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Popup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PopupView";
            this.TopMost = true;
            this.InnerPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel InnerPane;
        private System.Windows.Forms.PictureBox PopupLogo;
        private System.Windows.Forms.Label ContentArea;
    }
}

