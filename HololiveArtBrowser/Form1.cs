using HololiveArtBrowser.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HololiveArtBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool initialized = false;
        private int imageIndex = 0;
        private ArtResponse artRes = null;
        private async void button1_Click(object sender, EventArgs e)
        {
            string tags = null;
            if (tagsTextBox.Text != "")
            {
                tags = "+" + string.Join("+", tagsTextBox.Text.Split(','));
            }
            Console.WriteLine(lewdnessDropdown.SelectedText);
            artRes = await Client.GetArt(lewdnessDropdown.SelectedItem.ToString(), tags);
            Console.WriteLine(artRes.results[0].url);
            int width = artRes.results[0].width;
            int height = artRes.results[0].height;

            pictureBox1.Load(artRes.results[0].url);
            totalResultsLabel.Text = $"Total Results: {artRes.total}";
            initialized = true;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (initialized == true)
            {
                imageIndex++;
                pictureBox1.Load(artRes.results[imageIndex].url);
            }    
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (initialized == true && imageIndex > 0)
            {
                imageIndex--;
                pictureBox1.Load(artRes.results[imageIndex].url);
            }
        }
    }
}
