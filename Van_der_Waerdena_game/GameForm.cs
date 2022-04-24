﻿using System;
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
        private int radius = 50;
        private readonly string computerStrategy;
        public GameForm(StartForm startForm, Game game, string computerStrategy)
        {
            InitializeComponent();
            this.startForm = startForm;
            this.game = game;
            this.computerStrategy = computerStrategy;
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            startForm.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen penPink = new Pen(Color.Pink);
            Pen penBlue = new Pen(Color.Blue);
            SolidBrush brushPink = new SolidBrush(Color.Pink);
            SolidBrush brushBlue = new SolidBrush(Color.Blue);
            int width = this.panel1.Width;
            int height = this.panel1.Height;
            for(int i = 0; i < game.coinsList.Count; i++)
            {
                
                if (!game.coinsList[i])
                {//human
                    e.Graphics.DrawEllipse(penPink,  110*i, height / 2 - radius,
                          radius + radius, radius + radius);
                    e.Graphics.FillEllipse(brushPink, 110 * i, height / 2 - radius,
                              radius + radius, radius + radius);
                }
                else
                {//comp
                    e.Graphics.DrawEllipse(penBlue, 110 * i, height / 2 - radius,
                         radius + radius, radius + radius);
                    e.Graphics.FillEllipse(brushBlue, 110 * i, height / 2 - radius,
                              radius + radius, radius + radius);
                }
            }
            
        }

        private void put_coin_Click(object sender, EventArgs e)
        {
            game.addCoin(false, (int)this.whare_put_coin.Value);
            this.panel1.Invalidate();
            this.panel1.Refresh();
            Thread.Sleep(1000);
            if(computerStrategy=="Random")
                game.addCoin(true, ComputerRandomStrategy.MakeMove(game.getConisListCount()));
            this.panel1.Invalidate();
            this.panel1.Refresh();
        }
    }
}
