namespace MemoryGame
{
    partial class Zacatek
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
            this.jmenoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prijmeniTextBox = new System.Windows.Forms.TextBox();
            this.jmenoTextBox = new System.Windows.Forms.TextBox();
            this.hrajButton = new System.Windows.Forms.Button();
            this.opustitHruButton = new System.Windows.Forms.Button();
            this.obtiznostDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.casLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jmenoLabel
            // 
            this.jmenoLabel.AutoSize = true;
            this.jmenoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jmenoLabel.Location = new System.Drawing.Point(12, 29);
            this.jmenoLabel.Name = "jmenoLabel";
            this.jmenoLabel.Size = new System.Drawing.Size(61, 20);
            this.jmenoLabel.TabIndex = 0;
            this.jmenoLabel.Text = "Jmeno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prijmeni: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Obtiznost:";
            // 
            // prijmeniTextBox
            // 
            this.prijmeniTextBox.Location = new System.Drawing.Point(108, 80);
            this.prijmeniTextBox.Name = "prijmeniTextBox";
            this.prijmeniTextBox.Size = new System.Drawing.Size(164, 20);
            this.prijmeniTextBox.TabIndex = 2;
            // 
            // jmenoTextBox
            // 
            this.jmenoTextBox.Location = new System.Drawing.Point(108, 29);
            this.jmenoTextBox.Name = "jmenoTextBox";
            this.jmenoTextBox.Size = new System.Drawing.Size(164, 20);
            this.jmenoTextBox.TabIndex = 1;
            // 
            // hrajButton
            // 
            this.hrajButton.Location = new System.Drawing.Point(16, 201);
            this.hrajButton.Name = "hrajButton";
            this.hrajButton.Size = new System.Drawing.Size(93, 48);
            this.hrajButton.TabIndex = 4;
            this.hrajButton.Text = "Hraj!";
            this.hrajButton.UseVisualStyleBackColor = true;
            this.hrajButton.Click += new System.EventHandler(this.hrajButton_Click);
            // 
            // opustitHruButton
            // 
            this.opustitHruButton.Location = new System.Drawing.Point(169, 201);
            this.opustitHruButton.Name = "opustitHruButton";
            this.opustitHruButton.Size = new System.Drawing.Size(103, 48);
            this.opustitHruButton.TabIndex = 5;
            this.opustitHruButton.Text = "Opustit hru";
            this.opustitHruButton.UseVisualStyleBackColor = true;
            this.opustitHruButton.Click += new System.EventHandler(this.opustitHruButton_Click);
            // 
            // obtiznostDomainUpDown
            // 
            this.obtiznostDomainUpDown.Location = new System.Drawing.Point(108, 132);
            this.obtiznostDomainUpDown.Name = "obtiznostDomainUpDown";
            this.obtiznostDomainUpDown.Size = new System.Drawing.Size(103, 20);
            this.obtiznostDomainUpDown.TabIndex = 3;
            this.obtiznostDomainUpDown.Text = "Vyber obtiznost";
            this.obtiznostDomainUpDown.SelectedItemChanged += new System.EventHandler(this.obtiznostDomainUpDown_SelectedItemChanged);
            // 
            // casLabel
            // 
            this.casLabel.AutoSize = true;
            this.casLabel.Location = new System.Drawing.Point(172, 155);
            this.casLabel.Name = "casLabel";
            this.casLabel.Size = new System.Drawing.Size(0, 13);
            this.casLabel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cas na hru:";
            // 
            // Zacatek
            // 
            this.AcceptButton = this.hrajButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.casLabel);
            this.Controls.Add(this.obtiznostDomainUpDown);
            this.Controls.Add(this.opustitHruButton);
            this.Controls.Add(this.hrajButton);
            this.Controls.Add(this.jmenoTextBox);
            this.Controls.Add(this.prijmeniTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jmenoLabel);
            this.Name = "Zacatek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zacatek";
            this.Load += new System.EventHandler(this.Zacatek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jmenoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prijmeniTextBox;
        private System.Windows.Forms.TextBox jmenoTextBox;
        private System.Windows.Forms.Button hrajButton;
        private System.Windows.Forms.Button opustitHruButton;
        private System.Windows.Forms.DomainUpDown obtiznostDomainUpDown;
        private System.Windows.Forms.Label casLabel;
        private System.Windows.Forms.Label label1;
    }
}