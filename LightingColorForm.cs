using OpenTK.Mathematics;
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
    public partial class LightingColorForm : Form
    {
        public LightingColorForm()
        {
            InitializeComponent();
        }

        public LightingColorForm(Color4 ambientColor, Color4 diffuseColor, Color4 specularColor)
        {
            InitializeComponent();

            this.ambientColorButton.BackColor = ((Color)ambientColor);

            this.diffuseColorButton.BackColor = ((Color)diffuseColor);

            this.specularColorButton.BackColor = ((Color)specularColor);
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            var colorBtn = (Button)sender;
            colorDialog1.Color = colorBtn.BackColor;

            if (colorDialog1.ShowDialog() != DialogResult.OK)
                return;

            colorBtn.BackColor = colorDialog1.Color;
        }
    }
}
