﻿using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer3D
{
    public partial class SettingsForm : Form
    {
        private Action<object, EventArgs> lightingColorForm;
        public SettingsForm()
        {
            InitializeComponent();
        }
        public SettingsForm(Action<object, EventArgs> lightingColorForm, Color4 backgroundColor, Color4 wireframeColor)
        {
            InitializeComponent();

            this.lightingColorForm = lightingColorForm;
            this.BackgroundColorButton.BackColor = ((Color)backgroundColor);
            this.wireframeColorButton.BackColor = ((Color)wireframeColor);
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            var colorBtn = (Button)sender;
            colorDialog1.Color = colorBtn.BackColor;

            if (colorDialog1.ShowDialog() != DialogResult.OK)
                return;

            colorBtn.BackColor = colorDialog1.Color;
        }

        private void lightingColorButton_Click(object sender, EventArgs e)
        {
            lightingColorForm.Invoke(sender, e);
        }
    }
}
