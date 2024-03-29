﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulletHell {
    public partial class AddServerControl : UserControl {
        private SoundPlayer buttonSound;

        public AddServerControl() {
            InitializeComponent();
            buttonSound = new SoundPlayer(GetResoucePath("buttonSound.wav"));

        }
        private string GetResoucePath(string file) {
            string currentPath = Path.GetDirectoryName(Application.ExecutablePath);
            return Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(currentPath)), "Resources", file);
        }

        private void done_option_MouseHover(object sender, EventArgs e) {
            done_option.Image = Properties.Resources.DoneHighlight;
            buttonSound.Play();
        }

        private void done_option_MouseLeave(object sender, EventArgs e) {
            done_option.Image = Properties.Resources.Done;
        }

        private void cancel2_option_MouseHover(object sender, EventArgs e) {
            cancel2_option.Image = Properties.Resources.CancelHighlight2;
            buttonSound.Play();
        }

        private void cancel2_option_MouseLeave(object sender, EventArgs e) {
            cancel2_option.Image = Properties.Resources.Cancel2;
        }

        private void cancel2_option_Click(object sender, EventArgs e) {
            GameMenu.Instance.PnlContainer.Controls["MainControl"].BringToFront();
        }

        private void done_option_Click(object sender, EventArgs e) {
            ParentForm.Hide();
            GameArea game = new GameArea(ParentForm, textAddr.Text, int.Parse(waterMarkTextBox1.Text));
            game.Show();
        }


    }
}
