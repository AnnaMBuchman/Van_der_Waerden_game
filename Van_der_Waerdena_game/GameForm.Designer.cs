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
            this.SuspendLayout();
            // 
            // new_game_button
            // 
            this.new_game_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.new_game_button.Location = new System.Drawing.Point(103, 362);
            this.new_game_button.Name = "new_game_button";
            this.new_game_button.Size = new System.Drawing.Size(175, 50);
            this.new_game_button.TabIndex = 0;
            this.new_game_button.Text = "New game";
            this.new_game_button.UseVisualStyleBackColor = false;
            this.new_game_button.Click += new System.EventHandler(this.new_game_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.new_game_button);
            this.Name = "GameForm";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button new_game_button;
    }
}