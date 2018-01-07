namespace MemoryGame
{
    partial class PlochaHry
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
            this.components = new System.ComponentModel.Container();
            this.Karty = new System.Windows.Forms.Panel();
            this.karta12 = new System.Windows.Forms.PictureBox();
            this.karta11 = new System.Windows.Forms.PictureBox();
            this.karta10 = new System.Windows.Forms.PictureBox();
            this.karta9 = new System.Windows.Forms.PictureBox();
            this.karta8 = new System.Windows.Forms.PictureBox();
            this.karta7 = new System.Windows.Forms.PictureBox();
            this.karta6 = new System.Windows.Forms.PictureBox();
            this.karta5 = new System.Windows.Forms.PictureBox();
            this.karta4 = new System.Windows.Forms.PictureBox();
            this.karta3 = new System.Windows.Forms.PictureBox();
            this.karta2 = new System.Windows.Forms.PictureBox();
            this.karta1 = new System.Windows.Forms.PictureBox();
            this.hraciGrid = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.skoreLabel = new System.Windows.Forms.Label();
            this.skoreCislo = new System.Windows.Forms.Label();
            this.zbyvajiciCasLabel = new System.Windows.Forms.Label();
            this.obtiznostLabel = new System.Windows.Forms.Label();
            this.obtiznostTextLabel = new System.Windows.Forms.Label();
            this.odpocetLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.Karty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karta12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hraciGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Karty
            // 
            this.Karty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Karty.Controls.Add(this.karta12);
            this.Karty.Controls.Add(this.karta11);
            this.Karty.Controls.Add(this.karta10);
            this.Karty.Controls.Add(this.karta9);
            this.Karty.Controls.Add(this.karta8);
            this.Karty.Controls.Add(this.karta7);
            this.Karty.Controls.Add(this.karta6);
            this.Karty.Controls.Add(this.karta5);
            this.Karty.Controls.Add(this.karta4);
            this.Karty.Controls.Add(this.karta3);
            this.Karty.Controls.Add(this.karta2);
            this.Karty.Controls.Add(this.karta1);
            this.Karty.Location = new System.Drawing.Point(12, 5);
            this.Karty.Name = "Karty";
            this.Karty.Size = new System.Drawing.Size(525, 399);
            this.Karty.TabIndex = 0;
            // 
            // karta12
            // 
            this.karta12.Location = new System.Drawing.Point(396, 265);
            this.karta12.Name = "karta12";
            this.karta12.Size = new System.Drawing.Size(125, 125);
            this.karta12.TabIndex = 11;
            this.karta12.TabStop = false;
            this.karta12.Tag = "0";
            this.karta12.Click += new System.EventHandler(this.klikNaKartu);
            // 
            // karta11
            // 
            this.karta11.Location = new System.Drawing.Point(265, 265);
            this.karta11.Name = "karta11";
            this.karta11.Size = new System.Drawing.Size(125, 125);
            this.karta11.TabIndex = 10;
            this.karta11.TabStop = false;
            this.karta11.Tag = "0";
            this.karta11.Click += new System.EventHandler(this.klikNaKartu);
            // 
            // karta10
            // 
            this.karta10.Location = new System.Drawing.Point(134, 264);
            this.karta10.Name = "karta10";
            this.karta10.Size = new System.Drawing.Size(125, 125);
            this.karta10.TabIndex = 9;
            this.karta10.TabStop = false;
            this.karta10.Tag = "0";
            this.karta10.Click += new System.EventHandler(this.klikNaKartu);
            // 
            // karta9
            // 
            this.karta9.Location = new System.Drawing.Point(3, 265);
            this.karta9.Name = "karta9";
            this.karta9.Size = new System.Drawing.Size(125, 125);
            this.karta9.TabIndex = 8;
            this.karta9.TabStop = false;
            this.karta9.Tag = "0";
            this.karta9.Click += new System.EventHandler(this.klikNaKartu);
            // 
            // karta8
            // 
            this.karta8.Location = new System.Drawing.Point(396, 134);
            this.karta8.Name = "karta8";
            this.karta8.Size = new System.Drawing.Size(125, 125);
            this.karta8.TabIndex = 7;
            this.karta8.TabStop = false;
            this.karta8.Tag = "0";
            this.karta8.Click += new System.EventHandler(this.klikNaKartu);
            // 
            // karta7
            // 
            this.karta7.Location = new System.Drawing.Point(265, 134);
            this.karta7.Name = "karta7";
            this.karta7.Size = new System.Drawing.Size(125, 125);
            this.karta7.TabIndex = 6;
            this.karta7.TabStop = false;
            this.karta7.Tag = "0";
            this.karta7.Click += new System.EventHandler(this.klikNaKartu);
            // 
            // karta6
            // 
            this.karta6.Location = new System.Drawing.Point(134, 134);
            this.karta6.Name = "karta6";
            this.karta6.Size = new System.Drawing.Size(125, 125);
            this.karta6.TabIndex = 5;
            this.karta6.TabStop = false;
            this.karta6.Tag = "0";
            this.karta6.Click += new System.EventHandler(this.klikNaKartu);
            // 
            // karta5
            // 
            this.karta5.Location = new System.Drawing.Point(3, 134);
            this.karta5.Name = "karta5";
            this.karta5.Size = new System.Drawing.Size(125, 125);
            this.karta5.TabIndex = 4;
            this.karta5.TabStop = false;
            this.karta5.Tag = "0";
            this.karta5.Click += new System.EventHandler(this.klikNaKartu);
            // 
            // karta4
            // 
            this.karta4.Location = new System.Drawing.Point(396, 3);
            this.karta4.Name = "karta4";
            this.karta4.Size = new System.Drawing.Size(125, 125);
            this.karta4.TabIndex = 3;
            this.karta4.TabStop = false;
            this.karta4.Tag = "0";
            this.karta4.Click += new System.EventHandler(this.klikNaKartu);
            // 
            // karta3
            // 
            this.karta3.Location = new System.Drawing.Point(265, 3);
            this.karta3.Name = "karta3";
            this.karta3.Size = new System.Drawing.Size(125, 125);
            this.karta3.TabIndex = 2;
            this.karta3.TabStop = false;
            this.karta3.Tag = "0";
            this.karta3.Click += new System.EventHandler(this.klikNaKartu);
            // 
            // karta2
            // 
            this.karta2.Location = new System.Drawing.Point(134, 3);
            this.karta2.Name = "karta2";
            this.karta2.Size = new System.Drawing.Size(125, 125);
            this.karta2.TabIndex = 1;
            this.karta2.TabStop = false;
            this.karta2.Tag = "0";
            this.karta2.Click += new System.EventHandler(this.klikNaKartu);
            // 
            // karta1
            // 
            this.karta1.Location = new System.Drawing.Point(3, 3);
            this.karta1.Name = "karta1";
            this.karta1.Size = new System.Drawing.Size(125, 125);
            this.karta1.TabIndex = 0;
            this.karta1.TabStop = false;
            this.karta1.Tag = "0";
            this.karta1.Click += new System.EventHandler(this.klikNaKartu);
            // 
            // hraciGrid
            // 
            this.hraciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hraciGrid.Location = new System.Drawing.Point(804, 5);
            this.hraciGrid.Name = "hraciGrid";
            this.hraciGrid.ReadOnly = true;
            this.hraciGrid.Size = new System.Drawing.Size(662, 399);
            this.hraciGrid.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(590, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(103, 43);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // skoreLabel
            // 
            this.skoreLabel.AutoSize = true;
            this.skoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skoreLabel.Location = new System.Drawing.Point(543, 109);
            this.skoreLabel.Name = "skoreLabel";
            this.skoreLabel.Size = new System.Drawing.Size(75, 25);
            this.skoreLabel.TabIndex = 3;
            this.skoreLabel.Text = "Skóre: ";
            // 
            // skoreCislo
            // 
            this.skoreCislo.AutoSize = true;
            this.skoreCislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skoreCislo.Location = new System.Drawing.Point(606, 109);
            this.skoreCislo.Name = "skoreCislo";
            this.skoreCislo.Size = new System.Drawing.Size(23, 25);
            this.skoreCislo.TabIndex = 4;
            this.skoreCislo.Text = "0";
            // 
            // zbyvajiciCasLabel
            // 
            this.zbyvajiciCasLabel.AutoSize = true;
            this.zbyvajiciCasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zbyvajiciCasLabel.Location = new System.Drawing.Point(540, 137);
            this.zbyvajiciCasLabel.Name = "zbyvajiciCasLabel";
            this.zbyvajiciCasLabel.Size = new System.Drawing.Size(130, 25);
            this.zbyvajiciCasLabel.TabIndex = 5;
            this.zbyvajiciCasLabel.Text = "Zbývající čas:";
            // 
            // obtiznostLabel
            // 
            this.obtiznostLabel.AutoSize = true;
            this.obtiznostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obtiznostLabel.Location = new System.Drawing.Point(543, 165);
            this.obtiznostLabel.Name = "obtiznostLabel";
            this.obtiznostLabel.Size = new System.Drawing.Size(101, 25);
            this.obtiznostLabel.TabIndex = 6;
            this.obtiznostLabel.Text = "Obtížnost:";
            // 
            // obtiznostTextLabel
            // 
            this.obtiznostTextLabel.AutoSize = true;
            this.obtiznostTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obtiznostTextLabel.Location = new System.Drawing.Point(653, 165);
            this.obtiznostTextLabel.Name = "obtiznostTextLabel";
            this.obtiznostTextLabel.Size = new System.Drawing.Size(0, 25);
            this.obtiznostTextLabel.TabIndex = 7;
            // 
            // odpocetLabel
            // 
            this.odpocetLabel.AutoSize = true;
            this.odpocetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odpocetLabel.Location = new System.Drawing.Point(679, 137);
            this.odpocetLabel.Name = "odpocetLabel";
            this.odpocetLabel.Size = new System.Drawing.Size(0, 25);
            this.odpocetLabel.TabIndex = 8;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(590, 54);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(103, 38);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Resetuj Hru";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.PlochaHry_Load);
            // 
            // PlochaHry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 422);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.odpocetLabel);
            this.Controls.Add(this.obtiznostTextLabel);
            this.Controls.Add(this.obtiznostLabel);
            this.Controls.Add(this.zbyvajiciCasLabel);
            this.Controls.Add(this.skoreCislo);
            this.Controls.Add(this.skoreLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.hraciGrid);
            this.Controls.Add(this.Karty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PlochaHry";
            this.Text = "Pexeso";
            this.Load += new System.EventHandler(this.PlochaHry_Load);
            this.Karty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.karta12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hraciGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Karty;
        private System.Windows.Forms.PictureBox karta12;
        private System.Windows.Forms.PictureBox karta11;
        private System.Windows.Forms.PictureBox karta10;
        private System.Windows.Forms.PictureBox karta9;
        private System.Windows.Forms.PictureBox karta8;
        private System.Windows.Forms.PictureBox karta7;
        private System.Windows.Forms.PictureBox karta6;
        private System.Windows.Forms.PictureBox karta5;
        private System.Windows.Forms.PictureBox karta4;
        private System.Windows.Forms.PictureBox karta3;
        private System.Windows.Forms.PictureBox karta2;
        private System.Windows.Forms.PictureBox karta1;
        private System.Windows.Forms.DataGridView hraciGrid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label skoreLabel;
        private System.Windows.Forms.Label skoreCislo;
        private System.Windows.Forms.Label zbyvajiciCasLabel;
        private System.Windows.Forms.Label obtiznostLabel;
        private System.Windows.Forms.Label obtiznostTextLabel;
        private System.Windows.Forms.Label odpocetLabel;
        private System.Windows.Forms.Button resetButton;
    }
}

