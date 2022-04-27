using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Van_der_Waerdena_game
{
    public partial class WhowinsForms : Form
    {
        public WhowinsForms(string label, StartForm startForm, GameForm gameForm)
        {
            InitializeComponent();
            this.whowin_label.Text = label;
            StartForm = startForm;
            GameForm = gameForm;
        }

        public string Label { get; }
        public StartForm StartForm { get; }
        public GameForm GameForm { get; }

        private void new_game_button_Click(object sender, EventArgs e)
        {
            StartForm.Show();
            GameForm.Close();
            this.Close();
        }
    }
}
