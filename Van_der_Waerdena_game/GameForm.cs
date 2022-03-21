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
    public partial class GameForm : Form
    {
        StartForm startForm;
        private readonly Game game;

        public GameForm(StartForm startForm, Game game)
        {
            InitializeComponent();
            this.startForm = startForm;
            this.game = game;
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            startForm.Show();
            this.Close();
        }
    }
}
