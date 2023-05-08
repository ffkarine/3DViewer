namespace Viewer3D
{
    partial class LightingColorForm
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
            this.diffuseLightingLabel = new System.Windows.Forms.Label();
            this.ambientLightingLabel = new System.Windows.Forms.Label();
            this.ambientLightingGroup = new System.Windows.Forms.GroupBox();
            this.ambientColorButton = new System.Windows.Forms.Button();
            this.diffuseLightingGroup = new System.Windows.Forms.GroupBox();
            this.diffuseColorButton = new System.Windows.Forms.Button();
            this.specularLightingGroup = new System.Windows.Forms.GroupBox();
            this.specularColorButton = new System.Windows.Forms.Button();
            this.specularLightingLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ambientLightingGroup.SuspendLayout();
            this.diffuseLightingGroup.SuspendLayout();
            this.specularLightingGroup.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // diffuseLightingLabel
            // 
            this.diffuseLightingLabel.AutoSize = true;
            this.diffuseLightingLabel.Location = new System.Drawing.Point(6, 23);
            this.diffuseLightingLabel.Name = "diffuseLightingLabel";
            this.diffuseLightingLabel.Size = new System.Drawing.Size(117, 20);
            this.diffuseLightingLabel.TabIndex = 0;
            this.diffuseLightingLabel.Text = "Diffuse Lighting:";
            // 
            // ambientLightingLabel
            // 
            this.ambientLightingLabel.AutoSize = true;
            this.ambientLightingLabel.Location = new System.Drawing.Point(6, 23);
            this.ambientLightingLabel.Name = "ambientLightingLabel";
            this.ambientLightingLabel.Size = new System.Drawing.Size(127, 20);
            this.ambientLightingLabel.TabIndex = 1;
            this.ambientLightingLabel.Text = "Ambient Lighting:";
            // 
            // ambientLightingGroup
            // 
            this.ambientLightingGroup.Controls.Add(this.ambientColorButton);
            this.ambientLightingGroup.Controls.Add(this.ambientLightingLabel);
            this.ambientLightingGroup.Location = new System.Drawing.Point(12, 12);
            this.ambientLightingGroup.Name = "ambientLightingGroup";
            this.ambientLightingGroup.Size = new System.Drawing.Size(299, 64);
            this.ambientLightingGroup.TabIndex = 2;
            this.ambientLightingGroup.TabStop = false;
            // 
            // ambientColorButton
            // 
            this.ambientColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ambientColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ambientColorButton.Location = new System.Drawing.Point(262, 23);
            this.ambientColorButton.Name = "ambientColorButton";
            this.ambientColorButton.Size = new System.Drawing.Size(31, 30);
            this.ambientColorButton.TabIndex = 7;
            this.ambientColorButton.UseVisualStyleBackColor = true;
            this.ambientColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // diffuseLightingGroup
            // 
            this.diffuseLightingGroup.Controls.Add(this.diffuseColorButton);
            this.diffuseLightingGroup.Controls.Add(this.diffuseLightingLabel);
            this.diffuseLightingGroup.Location = new System.Drawing.Point(12, 82);
            this.diffuseLightingGroup.Name = "diffuseLightingGroup";
            this.diffuseLightingGroup.Size = new System.Drawing.Size(299, 64);
            this.diffuseLightingGroup.TabIndex = 3;
            this.diffuseLightingGroup.TabStop = false;
            // 
            // diffuseColorButton
            // 
            this.diffuseColorButton.Location = new System.Drawing.Point(262, 23);
            this.diffuseColorButton.Name = "diffuseColorButton";
            this.diffuseColorButton.Size = new System.Drawing.Size(31, 30);
            this.diffuseColorButton.TabIndex = 7;
            this.diffuseColorButton.UseVisualStyleBackColor = true;
            this.diffuseColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // specularLightingGroup
            // 
            this.specularLightingGroup.Controls.Add(this.specularColorButton);
            this.specularLightingGroup.Controls.Add(this.specularLightingLabel);
            this.specularLightingGroup.Location = new System.Drawing.Point(12, 152);
            this.specularLightingGroup.Name = "specularLightingGroup";
            this.specularLightingGroup.Size = new System.Drawing.Size(299, 64);
            this.specularLightingGroup.TabIndex = 4;
            this.specularLightingGroup.TabStop = false;
            // 
            // specularColorButton
            // 
            this.specularColorButton.Location = new System.Drawing.Point(262, 23);
            this.specularColorButton.Name = "specularColorButton";
            this.specularColorButton.Size = new System.Drawing.Size(31, 30);
            this.specularColorButton.TabIndex = 6;
            this.specularColorButton.UseVisualStyleBackColor = true;
            this.specularColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // specularLightingLabel
            // 
            this.specularLightingLabel.AutoSize = true;
            this.specularLightingLabel.Location = new System.Drawing.Point(6, 23);
            this.specularLightingLabel.Name = "specularLightingLabel";
            this.specularLightingLabel.Size = new System.Drawing.Size(127, 20);
            this.specularLightingLabel.TabIndex = 0;
            this.specularLightingLabel.Text = "Specular Lighting:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.okButton);
            this.panel4.Controls.Add(this.cancelButton);
            this.panel4.Location = new System.Drawing.Point(12, 299);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 35);
            this.panel4.TabIndex = 5;
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
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // LightingColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 346);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.specularLightingGroup);
            this.Controls.Add(this.diffuseLightingGroup);
            this.Controls.Add(this.ambientLightingGroup);
            this.Name = "LightingColorForm";
            this.Text = "LightingColorForm";
            this.ambientLightingGroup.ResumeLayout(false);
            this.ambientLightingGroup.PerformLayout();
            this.diffuseLightingGroup.ResumeLayout(false);
            this.diffuseLightingGroup.PerformLayout();
            this.specularLightingGroup.ResumeLayout(false);
            this.specularLightingGroup.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label diffuseLightingLabel;
        private Label ambientLightingLabel;
        private GroupBox ambientLightingGroup;
        private GroupBox diffuseLightingGroup;
        private GroupBox specularLightingGroup;
        private Label specularLightingLabel;
        private Panel panel4;
        private Button okButton;
        private Button cancelButton;
        private ColorDialog colorDialog1;
        public Button ambientColorButton;
        public Button diffuseColorButton;
        public Button specularColorButton;
    }
}