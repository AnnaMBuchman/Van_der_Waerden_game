﻿namespace Van_der_Waerdena_game
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.whoStarts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberChips = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.computerStrategy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberChips)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(78, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start new game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startButton_MouseClick);
            // 
            // whoStarts
            // 
            this.whoStarts.FormattingEnabled = true;
            this.whoStarts.Items.AddRange(new object[] {
            "Computer",
            "Human"});
            this.whoStarts.Location = new System.Drawing.Point(78, 196);
            this.whoStarts.Name = "whoStarts";
            this.whoStarts.Size = new System.Drawing.Size(169, 28);
            this.whoStarts.TabIndex = 1;
            this.whoStarts.Text = "Computer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Who starts the game?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max k chips in sequence:";
            // 
            // numberChips
            // 
            this.numberChips.Location = new System.Drawing.Point(78, 98);
            this.numberChips.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numberChips.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numberChips.Name = "numberChips";
            this.numberChips.Size = new System.Drawing.Size(169, 27);
            this.numberChips.TabIndex = 4;
            this.numberChips.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Computer strategy:";
            // 
            // computerStrategy
            // 
            this.computerStrategy.FormattingEnabled = true;
            this.computerStrategy.Items.AddRange(new object[] {
            "Random",
            "K minus one",
            "Winning"});
            this.computerStrategy.Location = new System.Drawing.Point(80, 284);
            this.computerStrategy.Name = "computerStrategy";
            this.computerStrategy.Size = new System.Drawing.Size(169, 28);
            this.computerStrategy.TabIndex = 6;
            this.computerStrategy.Text = "Random";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.computerStrategy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberChips);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.whoStarts);
            this.Controls.Add(this.button1);
            this.Name = "StartForm";
            this.Text = "StartGame";
            ((System.ComponentModel.ISupportInitialize)(this.numberChips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ComboBox whoStarts;
        private Label label1;
        private Label label2;
        private NumericUpDown numberChips;
        private Label label3;
        private ComboBox computerStrategy;
    }
}