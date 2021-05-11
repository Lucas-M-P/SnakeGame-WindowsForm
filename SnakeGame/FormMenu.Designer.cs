
namespace SnakeGame
{
    partial class FormMenu
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
            this.EasyRadioButton = new System.Windows.Forms.RadioButton();
            this.MidiumRadioButton = new System.Windows.Forms.RadioButton();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.HardRadioButton = new System.Windows.Forms.RadioButton();
            this.Title = new System.Windows.Forms.Label();
            this.DifficultyTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EasyRadioButton
            // 
            this.EasyRadioButton.AutoSize = true;
            this.EasyRadioButton.Location = new System.Drawing.Point(153, 87);
            this.EasyRadioButton.Name = "EasyRadioButton";
            this.EasyRadioButton.Size = new System.Drawing.Size(48, 19);
            this.EasyRadioButton.TabIndex = 0;
            this.EasyRadioButton.TabStop = true;
            this.EasyRadioButton.Text = "Easy";
            this.EasyRadioButton.UseVisualStyleBackColor = true;
            // 
            // MidiumRadioButton
            // 
            this.MidiumRadioButton.AutoSize = true;
            this.MidiumRadioButton.Location = new System.Drawing.Point(153, 112);
            this.MidiumRadioButton.Name = "MidiumRadioButton";
            this.MidiumRadioButton.Size = new System.Drawing.Size(67, 19);
            this.MidiumRadioButton.TabIndex = 1;
            this.MidiumRadioButton.TabStop = true;
            this.MidiumRadioButton.Text = "Midium";
            this.MidiumRadioButton.UseVisualStyleBackColor = true;
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Location = new System.Drawing.Point(153, 196);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(85, 35);
            this.ButtonPlay.TabIndex = 2;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.UseVisualStyleBackColor = true;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // HardRadioButton
            // 
            this.HardRadioButton.AutoSize = true;
            this.HardRadioButton.Location = new System.Drawing.Point(153, 137);
            this.HardRadioButton.Name = "HardRadioButton";
            this.HardRadioButton.Size = new System.Drawing.Size(51, 19);
            this.HardRadioButton.TabIndex = 3;
            this.HardRadioButton.TabStop = true;
            this.HardRadioButton.Text = "Hard";
            this.HardRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HardRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HardRadioButton.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(126, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(147, 32);
            this.Title.TabIndex = 4;
            this.Title.Text = "Snake Game";
            // 
            // DifficultyTitle
            // 
            this.DifficultyTitle.AutoSize = true;
            this.DifficultyTitle.Location = new System.Drawing.Point(153, 69);
            this.DifficultyTitle.Name = "DifficultyTitle";
            this.DifficultyTitle.Size = new System.Drawing.Size(58, 15);
            this.DifficultyTitle.TabIndex = 5;
            this.DifficultyTitle.Text = "Difficulty:";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.DifficultyTitle);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.HardRadioButton);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.MidiumRadioButton);
            this.Controls.Add(this.EasyRadioButton);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Shown += new System.EventHandler(this.FormMenu_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton EasyRadioButton;
        private System.Windows.Forms.RadioButton MidiumRadioButton;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.RadioButton HardRadioButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label DifficultyTitle;
    }
}