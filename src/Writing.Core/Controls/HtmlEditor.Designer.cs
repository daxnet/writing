﻿namespace Writing.Core.Controls
{
    partial class HtmlEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editingSurface = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // editingSurface
            // 
            this.editingSurface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editingSurface.Location = new System.Drawing.Point(0, 0);
            this.editingSurface.MinimumSize = new System.Drawing.Size(20, 20);
            this.editingSurface.Name = "editingSurface";
            this.editingSurface.Size = new System.Drawing.Size(453, 444);
            this.editingSurface.TabIndex = 0;
            // 
            // HtmlEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editingSurface);
            this.Name = "HtmlEditor";
            this.Size = new System.Drawing.Size(453, 444);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser editingSurface;
    }
}
