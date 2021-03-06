﻿namespace Harvester.GUI
{
    partial class CMD
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
            this.LoadProfileButton = new System.Windows.Forms.Button();
            this.LoadProfileOFD = new System.Windows.Forms.OpenFileDialog();
            this.Herbs = new System.Windows.Forms.CheckedListBox();
            this.Mines = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // LoadProfileButton
            // 
            this.LoadProfileButton.Location = new System.Drawing.Point(264, 248);
            this.LoadProfileButton.Name = "LoadProfileButton";
            this.LoadProfileButton.Size = new System.Drawing.Size(75, 23);
            this.LoadProfileButton.TabIndex = 0;
            this.LoadProfileButton.Text = "Load Profile";
            this.LoadProfileButton.UseVisualStyleBackColor = true;
            this.LoadProfileButton.Click += new System.EventHandler(this.LoadProfileButton_Click);
            // 
            // LoadProfileOFD
            // 
            this.LoadProfileOFD.FileName = "LoadProfileOFD";
            this.LoadProfileOFD.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadProfileOFD_FileOk);
            // 
            // Herbs
            // 
            this.Herbs.CheckOnClick = true;
            this.Herbs.FormattingEnabled = true;
            this.Herbs.Items.AddRange(new object[] {
            "Peacebloom",
            "Silverleaf",
            "Earthroot",
            "Mageroyal",
            "Briarthorn",
            "Stranglekelp",
            "Bruiseweed",
            "Wild Steelbloom",
            "Grave Moss",
            "Kingsblood",
            "Liferoot",
            "Fadeleaf",
            "Goldthorn",
            "Khadgar\'s Whisker",
            "Wintersbite",
            "Firebloom",
            "Purple Lotus",
            "Arthas\' Tears",
            "Sungrass",
            "Blindweed",
            "Ghost Mushroom",
            "Gromsblood",
            "Golden Sansam",
            "Dreamfoil",
            "Mountain Silversage",
            "Plaguebloom",
            "Icecap",
            "Black Lotus"});
            this.Herbs.Location = new System.Drawing.Point(12, 12);
            this.Herbs.Name = "Herbs";
            this.Herbs.Size = new System.Drawing.Size(120, 259);
            this.Herbs.TabIndex = 1;
            this.Herbs.MouseLeave += new System.EventHandler(this.HerbCheckListBox_MouseLeave);
            // 
            // Mines
            // 
            this.Mines.CheckOnClick = true;
            this.Mines.FormattingEnabled = true;
            this.Mines.Items.AddRange(new object[] {
            "Copper",
            "Tin",
            "Silver",
            "Ooze Silver",
            "Iron",
            "Gold",
            "Ooze Gold",
            "Mithril",
            "Ooze Mithril",
            "Truesilver",
            "Ooze Truesilver",
            "Small Thorium",
            "Ooze Small Thorium",
            "Rich Thorium",
            "Ooze Rich Thorium"});
            this.Mines.Location = new System.Drawing.Point(138, 12);
            this.Mines.Name = "Mines";
            this.Mines.ScrollAlwaysVisible = true;
            this.Mines.Size = new System.Drawing.Size(120, 259);
            this.Mines.TabIndex = 2;
            this.Mines.MouseLeave += new System.EventHandler(this.MineCheckListBox_MouseLeave);
            // 
            // CMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 283);
            this.Controls.Add(this.Mines);
            this.Controls.Add(this.Herbs);
            this.Controls.Add(this.LoadProfileButton);
            this.Name = "CMD";
            this.Text = "CMD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadProfileButton;
        private System.Windows.Forms.OpenFileDialog LoadProfileOFD;
        private System.Windows.Forms.CheckedListBox Herbs;
        private System.Windows.Forms.CheckedListBox Mines;
    }
}