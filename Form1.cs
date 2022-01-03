/*
 * Media File Player
 * by Peter Hutchison
 * Converted from VB version
 * 13/07/2019
 * NB: Add following reference:
 * Windows Media Player = C:\Windows\System32\wmp.dll
 *
 * Toolbox, Choose Items, Windows Media Player for AxWMPLib component.
  */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open form and set media player size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set Media Player window relative to Form window size
            axWindowsMediaPlayer1.Height = this.Height * 80 / 100;
            axWindowsMediaPlayer1.Width = this.Width * 80 / 100;
            axWindowsMediaPlayer1.Refresh();
            // Moved Load file dialog in relation too
            button1.Top = this.Height * 85 / 100;
        }

        /// <summary>
        /// Reize player window if form size changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Resize Media Player window if Form window is resized
            axWindowsMediaPlayer1.Height = this.Height * 80 / 100;
            axWindowsMediaPlayer1.Width = this.Width * 80 / 100;
            axWindowsMediaPlayer1.Refresh();
            // Moved Load file dialog in relation too
            button1.Top = this.Height * 85 / 100;
        }

        /// <summary>
        /// Load a media file and set it on media player.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string mediaFile;

            openFileDialog1.ShowDialog();
            mediaFile = openFileDialog1.FileName;
            axWindowsMediaPlayer1.URL = mediaFile;
        }
    }
}
