namespace Van_der_Waerdena_game
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void startButton_MouseClick(object sender, MouseEventArgs e)
        {
            Game game = new Game(this.whoStarts.Text == "Computer", this.numberChips.Value);
            GameForm gameForm = new GameForm(this, game, this.computerStrategy.Text);
            gameForm.Show();
            this.Hide();
        }
    }
}