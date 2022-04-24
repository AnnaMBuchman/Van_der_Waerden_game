namespace Van_der_Waerdena_game
{
    partial class GameForm
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
            this.new_game_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.whare_put_coin = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.put_coin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.whare_put_coin)).BeginInit();
            this.SuspendLayout();
            // 
            // new_game_button
            // 
            this.new_game_button.BackColor = System.Drawing.Color.LimeGreen;
            this.new_game_button.Location = new System.Drawing.Point(77, 832);
            this.new_game_button.Name = "new_game_button";
            this.new_game_button.Size = new System.Drawing.Size(175, 50);
            this.new_game_button.TabIndex = 0;
            this.new_game_button.Text = "New game";
            this.new_game_button.UseVisualStyleBackColor = false;
            this.new_game_button.Click += new System.EventHandler(this.new_game_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(749, 852);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "On which place put a coin?";
            // 
            // whare_put_coin
            // 
            this.whare_put_coin.Location = new System.Drawing.Point(1009, 845);
            this.whare_put_coin.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.whare_put_coin.Name = "whare_put_coin";
            this.whare_put_coin.Size = new System.Drawing.Size(150, 27);
            this.whare_put_coin.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1690, 800);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // put_coin
            // 
            this.put_coin.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.put_coin.BackColor = System.Drawing.Color.HotPink;
            this.put_coin.Location = new System.Drawing.Point(1210, 832);
            this.put_coin.Name = "put_coin";
            this.put_coin.Size = new System.Drawing.Size(175, 50);
            this.put_coin.TabIndex = 4;
            this.put_coin.Text = "Put a coin";
            this.put_coin.UseVisualStyleBackColor = false;
            this.put_coin.Click += new System.EventHandler(this.put_coin_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 953);
            this.Controls.Add(this.put_coin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.whare_put_coin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_game_button);
            this.MaximumSize = new System.Drawing.Size(1700, 1000);
            this.MinimumSize = new System.Drawing.Size(1700, 1000);
            this.Name = "GameForm";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.whare_put_coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button new_game_button;
        private Label label1;
        private NumericUpDown whare_put_coin;
        private Panel panel1;
        private Button put_coin;
    }
}