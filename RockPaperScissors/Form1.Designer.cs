namespace RockPaperScissors
{
    partial class Form1
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
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorButton = new System.Windows.Forms.Button();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerchoiceLabel = new System.Windows.Forms.Label();
            this.computerLabel = new System.Windows.Forms.Label();
            this.computerchoiceLabel = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rockButton
            // 
            this.rockButton.Location = new System.Drawing.Point(32, 381);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(75, 23);
            this.rockButton.TabIndex = 0;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Location = new System.Drawing.Point(113, 381);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(75, 23);
            this.paperButton.TabIndex = 1;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorButton
            // 
            this.scissorButton.Location = new System.Drawing.Point(194, 381);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(75, 23);
            this.scissorButton.TabIndex = 2;
            this.scissorButton.Text = "Scissors";
            this.scissorButton.UseVisualStyleBackColor = true;
            this.scissorButton.Click += new System.EventHandler(this.scissorButton_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(71, 84);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(49, 13);
            this.playerLabel.TabIndex = 3;
            this.playerLabel.Text = "PLAYER";
            // 
            // playerchoiceLabel
            // 
            this.playerchoiceLabel.AutoSize = true;
            this.playerchoiceLabel.Location = new System.Drawing.Point(72, 123);
            this.playerchoiceLabel.Name = "playerchoiceLabel";
            this.playerchoiceLabel.Size = new System.Drawing.Size(0, 13);
            this.playerchoiceLabel.TabIndex = 4;
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Location = new System.Drawing.Point(651, 84);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(68, 13);
            this.computerLabel.TabIndex = 5;
            this.computerLabel.Text = "COMPUTER";
            // 
            // computerchoiceLabel
            // 
            this.computerchoiceLabel.AutoSize = true;
            this.computerchoiceLabel.Location = new System.Drawing.Point(651, 134);
            this.computerchoiceLabel.Name = "computerchoiceLabel";
            this.computerchoiceLabel.Size = new System.Drawing.Size(0, 13);
            this.computerchoiceLabel.TabIndex = 6;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Location = new System.Drawing.Point(373, 13);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(0, 13);
            this.winnerLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.computerchoiceLabel);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.playerchoiceLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label playerchoiceLabel;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label computerchoiceLabel;
        private System.Windows.Forms.Label winnerLabel;
    }
}

