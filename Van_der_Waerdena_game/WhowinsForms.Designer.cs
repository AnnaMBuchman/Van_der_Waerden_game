namespace Van_der_Waerdena_game
{
    partial class WhowinsForms
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
            this.whowin_label = new System.Windows.Forms.Label();
            this.new_game_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // whowin_label
            // 
            this.whowin_label.AutoSize = true;
            this.whowin_label.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whowin_label.Location = new System.Drawing.Point(103, 129);
            this.whowin_label.Name = "whowin_label";
            this.whowin_label.Size = new System.Drawing.Size(174, 26);
            this.whowin_label.TabIndex = 0;
            this.whowin_label.Text = "wins the game!";
            // 
            // new_game_button
            // 
            this.new_game_button.BackColor = System.Drawing.Color.LimeGreen;
            this.new_game_button.Location = new System.Drawing.Point(140, 211);
            this.new_game_button.Name = "new_game_button";
            this.new_game_button.Size = new System.Drawing.Size(175, 50);
            this.new_game_button.TabIndex = 1;
            this.new_game_button.Text = "New game";
            this.new_game_button.UseVisualStyleBackColor = false;
            this.new_game_button.Click += new System.EventHandler(this.new_game_button_Click);
            // 
            // WhowinsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 302);
            this.Controls.Add(this.new_game_button);
            this.Controls.Add(this.whowin_label);
            this.Name = "WhowinsForms";
            this.Text = "WhowinsForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label whowin_label;
        private Button new_game_button;
    }
}