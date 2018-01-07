namespace MemoryGame
{
    partial class NovyHrac
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
            this.novyJmenoLabel = new System.Windows.Forms.Label();
            this.novyPrijmeniLabel = new System.Windows.Forms.Label();
            this.novyObtiznostLabel = new System.Windows.Forms.Label();
            this.novyCasNaHru = new System.Windows.Forms.Label();
            this.novyHrajButton = new System.Windows.Forms.Button();
            this.novyJmenoTextBox = new System.Windows.Forms.TextBox();
            this.novyPrijmeniTextBox = new System.Windows.Forms.TextBox();
            this.novyObtiznostDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.novyCasNaHruLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // novyJmenoLabel
            // 
            this.novyJmenoLabel.AutoSize = true;
            this.novyJmenoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novyJmenoLabel.Location = new System.Drawing.Point(12, 29);
            this.novyJmenoLabel.Name = "novyJmenoLabel";
            this.novyJmenoLabel.Size = new System.Drawing.Size(61, 20);
            this.novyJmenoLabel.TabIndex = 0;
            this.novyJmenoLabel.Text = "Jmeno:";
            // 
            // novyPrijmeniLabel
            // 
            this.novyPrijmeniLabel.AutoSize = true;
            this.novyPrijmeniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novyPrijmeniLabel.Location = new System.Drawing.Point(12, 80);
            this.novyPrijmeniLabel.Name = "novyPrijmeniLabel";
            this.novyPrijmeniLabel.Size = new System.Drawing.Size(68, 20);
            this.novyPrijmeniLabel.TabIndex = 1;
            this.novyPrijmeniLabel.Text = "Prijmeni:";
            // 
            // novyObtiznostLabel
            // 
            this.novyObtiznostLabel.AutoSize = true;
            this.novyObtiznostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novyObtiznostLabel.Location = new System.Drawing.Point(12, 132);
            this.novyObtiznostLabel.Name = "novyObtiznostLabel";
            this.novyObtiznostLabel.Size = new System.Drawing.Size(81, 20);
            this.novyObtiznostLabel.TabIndex = 2;
            this.novyObtiznostLabel.Text = "Obtiznost:";
            // 
            // novyCasNaHru
            // 
            this.novyCasNaHru.AutoSize = true;
            this.novyCasNaHru.Location = new System.Drawing.Point(105, 155);
            this.novyCasNaHru.Name = "novyCasNaHru";
            this.novyCasNaHru.Size = new System.Drawing.Size(61, 13);
            this.novyCasNaHru.TabIndex = 3;
            this.novyCasNaHru.Text = "Cas na hru:";
            // 
            // novyHrajButton
            // 
            this.novyHrajButton.Location = new System.Drawing.Point(99, 188);
            this.novyHrajButton.Name = "novyHrajButton";
            this.novyHrajButton.Size = new System.Drawing.Size(93, 48);
            this.novyHrajButton.TabIndex = 4;
            this.novyHrajButton.Text = "Hraj!";
            this.novyHrajButton.UseVisualStyleBackColor = true;
            this.novyHrajButton.Click += new System.EventHandler(this.novyHrajButton_Click_1);
            // 
            // novyJmenoTextBox
            // 
            this.novyJmenoTextBox.Location = new System.Drawing.Point(108, 29);
            this.novyJmenoTextBox.Name = "novyJmenoTextBox";
            this.novyJmenoTextBox.Size = new System.Drawing.Size(164, 20);
            this.novyJmenoTextBox.TabIndex = 1;
            // 
            // novyPrijmeniTextBox
            // 
            this.novyPrijmeniTextBox.Location = new System.Drawing.Point(108, 80);
            this.novyPrijmeniTextBox.Name = "novyPrijmeniTextBox";
            this.novyPrijmeniTextBox.Size = new System.Drawing.Size(164, 20);
            this.novyPrijmeniTextBox.TabIndex = 2;
            // 
            // novyObtiznostDomainUpDown
            // 
            this.novyObtiznostDomainUpDown.Location = new System.Drawing.Point(108, 132);
            this.novyObtiznostDomainUpDown.Name = "novyObtiznostDomainUpDown";
            this.novyObtiznostDomainUpDown.Size = new System.Drawing.Size(103, 20);
            this.novyObtiznostDomainUpDown.TabIndex = 3;
            this.novyObtiznostDomainUpDown.Text = "domainUpDown1";
            this.novyObtiznostDomainUpDown.SelectedItemChanged += new System.EventHandler(this.novyObtiznostDomainUpDown_SelectedItemChanged);
            // 
            // novyCasNaHruLabel
            // 
            this.novyCasNaHruLabel.AutoSize = true;
            this.novyCasNaHruLabel.Location = new System.Drawing.Point(172, 155);
            this.novyCasNaHruLabel.Name = "novyCasNaHruLabel";
            this.novyCasNaHruLabel.Size = new System.Drawing.Size(0, 13);
            this.novyCasNaHruLabel.TabIndex = 8;
            // 
            // NovyHrac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.novyCasNaHruLabel);
            this.Controls.Add(this.novyObtiznostDomainUpDown);
            this.Controls.Add(this.novyPrijmeniTextBox);
            this.Controls.Add(this.novyJmenoTextBox);
            this.Controls.Add(this.novyHrajButton);
            this.Controls.Add(this.novyCasNaHru);
            this.Controls.Add(this.novyObtiznostLabel);
            this.Controls.Add(this.novyPrijmeniLabel);
            this.Controls.Add(this.novyJmenoLabel);
            this.Name = "NovyHrac";
            this.Text = "Nový hráč";
            this.Load += new System.EventHandler(this.NovyHrac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label novyJmenoLabel;
        private System.Windows.Forms.Label novyPrijmeniLabel;
        private System.Windows.Forms.Label novyObtiznostLabel;
        private System.Windows.Forms.Label novyCasNaHru;
        private System.Windows.Forms.Button novyHrajButton;
        private System.Windows.Forms.TextBox novyJmenoTextBox;
        private System.Windows.Forms.TextBox novyPrijmeniTextBox;
        private System.Windows.Forms.DomainUpDown novyObtiznostDomainUpDown;
        private System.Windows.Forms.Label novyCasNaHruLabel;
    }
}