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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ambientColorButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.diffuseColorButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.specularColorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diffuse Lighting:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ambient Lighting:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ambientColorButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.diffuseColorButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 64);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.specularColorButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 64);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Specular Lighting:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(12, 299);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 35);
            this.panel4.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(202, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LightingColorForm";
            this.Text = "LightingColorForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Panel panel4;
        private Button button2;
        private Button button1;
        private ColorDialog colorDialog1;
        public Button ambientColorButton;
        public Button diffuseColorButton;
        public Button specularColorButton;
    }
}