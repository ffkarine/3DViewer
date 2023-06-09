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
            this.wireframeColorGroup = new System.Windows.Forms.GroupBox();
            this.wireframeColorButton = new System.Windows.Forms.Button();
            this.wireframeColorLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lightingColorGroup = new System.Windows.Forms.GroupBox();
            this.lightingColorButton = new System.Windows.Forms.Button();
            this.lightingColorLabel = new System.Windows.Forms.Label();
            this.backgroundColorGroup.SuspendLayout();
            this.panel4.SuspendLayout();
            this.wireframeColorGroup.SuspendLayout();
            this.lightingColorGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundColorGroup
            // 
            this.backgroundColorGroup.Controls.Add(this.BackgroundColorButton);
            this.backgroundColorGroup.Controls.Add(this.backgroundColorLabel);
            this.backgroundColorGroup.Location = new System.Drawing.Point(12, 12);
            this.backgroundColorGroup.Name = "backgroundColorGroup";
            this.backgroundColorGroup.Size = new System.Drawing.Size(352, 64);
            this.backgroundColorGroup.TabIndex = 3;
            this.backgroundColorGroup.TabStop = false;
            // 
            // BackgroundColorButton
            // 
            this.BackgroundColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BackgroundColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundColorButton.Location = new System.Drawing.Point(315, 23);
            this.BackgroundColorButton.Name = "BackgroundColorButton";
            this.BackgroundColorButton.Size = new System.Drawing.Size(31, 30);
            this.BackgroundColorButton.TabIndex = 7;
            this.BackgroundColorButton.UseVisualStyleBackColor = true;
            this.BackgroundColorButton.Click += new System.EventHandler(this.ColorButton_Click);
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
            this.panel4.Size = new System.Drawing.Size(352, 35);
            this.panel4.TabIndex = 6;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(252, 3);
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
            // wireframeColorGroup
            // 
            this.wireframeColorGroup.Controls.Add(this.wireframeColorButton);
            this.wireframeColorGroup.Controls.Add(this.wireframeColorLabel);
            this.wireframeColorGroup.Location = new System.Drawing.Point(12, 82);
            this.wireframeColorGroup.Name = "wireframeColorGroup";
            this.wireframeColorGroup.Size = new System.Drawing.Size(352, 64);
            this.wireframeColorGroup.TabIndex = 8;
            this.wireframeColorGroup.TabStop = false;
            // 
            // wireframeColorButton
            // 
            this.wireframeColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.wireframeColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.wireframeColorButton.Location = new System.Drawing.Point(315, 23);
            this.wireframeColorButton.Name = "wireframeColorButton";
            this.wireframeColorButton.Size = new System.Drawing.Size(31, 30);
            this.wireframeColorButton.TabIndex = 7;
            this.wireframeColorButton.UseVisualStyleBackColor = true;
            this.wireframeColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // wireframeColorLabel
            // 
            this.wireframeColorLabel.AutoSize = true;
            this.wireframeColorLabel.Location = new System.Drawing.Point(6, 23);
            this.wireframeColorLabel.Name = "wireframeColorLabel";
            this.wireframeColorLabel.Size = new System.Drawing.Size(119, 20);
            this.wireframeColorLabel.TabIndex = 1;
            this.wireframeColorLabel.Text = "Wireframe Color";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // lightingColorGroup
            // 
            this.lightingColorGroup.Controls.Add(this.lightingColorButton);
            this.lightingColorGroup.Controls.Add(this.lightingColorLabel);
            this.lightingColorGroup.Location = new System.Drawing.Point(12, 152);
            this.lightingColorGroup.Name = "lightingColorGroup";
            this.lightingColorGroup.Size = new System.Drawing.Size(352, 64);
            this.lightingColorGroup.TabIndex = 9;
            this.lightingColorGroup.TabStop = false;
            // 
            // lightingColorButton
            // 
            this.lightingColorButton.BackgroundImage = global::Viewer3D.Properties.Resources.rainbow_palette_256x256;
            this.lightingColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lightingColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lightingColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lightingColorButton.Location = new System.Drawing.Point(315, 23);
            this.lightingColorButton.Name = "lightingColorButton";
            this.lightingColorButton.Size = new System.Drawing.Size(31, 30);
            this.lightingColorButton.TabIndex = 7;
            this.lightingColorButton.UseVisualStyleBackColor = true;
            this.lightingColorButton.Click += new System.EventHandler(this.lightingColorButton_Click);
            // 
            // lightingColorLabel
            // 
            this.lightingColorLabel.AutoSize = true;
            this.lightingColorLabel.Location = new System.Drawing.Point(6, 23);
            this.lightingColorLabel.Name = "lightingColorLabel";
            this.lightingColorLabel.Size = new System.Drawing.Size(103, 20);
            this.lightingColorLabel.TabIndex = 1;
            this.lightingColorLabel.Text = "Lighting Color";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 346);
            this.Controls.Add(this.lightingColorGroup);
            this.Controls.Add(this.wireframeColorGroup);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.backgroundColorGroup);
            this.MinimumSize = new System.Drawing.Size(394, 393);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.backgroundColorGroup.ResumeLayout(false);
            this.backgroundColorGroup.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.wireframeColorGroup.ResumeLayout(false);
            this.wireframeColorGroup.PerformLayout();
            this.lightingColorGroup.ResumeLayout(false);
            this.lightingColorGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox backgroundColorGroup;
        public Button BackgroundColorButton;
        private Label backgroundColorLabel;
        private Panel panel4;
        private Button okButton;
        private Button cancelButton;
        private GroupBox wireframeColorGroup;
        public Button wireframeColorButton;
        private Label wireframeColorLabel;
        private ColorDialog colorDialog1;
        private GroupBox lightingColorGroup;
        public Button lightingColorButton;
        private Label lightingColorLabel;
    }
}