﻿namespace Viewer3D
{
    partial class SettingsForm
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
            this.backgroundColorGroup = new System.Windows.Forms.GroupBox();
            this.BackgroundColorButton = new System.Windows.Forms.Button();
            this.backgroundColorLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backgroundColorGroup.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundColorGroup
            // 
            this.backgroundColorGroup.Controls.Add(this.BackgroundColorButton);
            this.backgroundColorGroup.Controls.Add(this.backgroundColorLabel);
            this.backgroundColorGroup.Location = new System.Drawing.Point(12, 12);
            this.backgroundColorGroup.Name = "backgroundColorGroup";
            this.backgroundColorGroup.Size = new System.Drawing.Size(299, 64);
            this.backgroundColorGroup.TabIndex = 3;
            this.backgroundColorGroup.TabStop = false;
            // 
            // BackgroundColorButton
            // 
            this.BackgroundColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BackgroundColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundColorButton.Location = new System.Drawing.Point(262, 23);
            this.BackgroundColorButton.Name = "BackgroundColorButton";
            this.BackgroundColorButton.Size = new System.Drawing.Size(31, 30);
            this.BackgroundColorButton.TabIndex = 7;
            this.BackgroundColorButton.UseVisualStyleBackColor = true;
            // 
            // backgroundColorLabel
            // 
            this.backgroundColorLabel.AutoSize = true;
            this.backgroundColorLabel.Location = new System.Drawing.Point(6, 23);
            this.backgroundColorLabel.Name = "backgroundColorLabel";
            this.backgroundColorLabel.Size = new System.Drawing.Size(128, 20);
            this.backgroundColorLabel.TabIndex = 1;
            this.backgroundColorLabel.Text = "Background Color";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.okButton);
            this.panel4.Controls.Add(this.cancelButton);
            this.panel4.Location = new System.Drawing.Point(12, 299);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 35);
            this.panel4.TabIndex = 6;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(202, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 29);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 346);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.backgroundColorGroup);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.backgroundColorGroup.ResumeLayout(false);
            this.backgroundColorGroup.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox backgroundColorGroup;
        public Button BackgroundColorButton;
        private Label backgroundColorLabel;
        private Panel panel4;
        private Button okButton;
        private Button cancelButton;
    }
}