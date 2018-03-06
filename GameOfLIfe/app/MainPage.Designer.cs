namespace GameOfLife.app
{
    partial class MainPage
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
            this.StartButton = new System.Windows.Forms.Button();
            this.lifeGrid = new GameOfLife.exDGV();
            ((System.ComponentModel.ISupportInitialize)(this.lifeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.StartButton.Location = new System.Drawing.Point(11, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(504, 60);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start the Life Game";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartCommand);
            // 
            // lifeGrid
            // 
            this.lifeGrid.AllowUserToAddRows = false;
            this.lifeGrid.AllowUserToDeleteRows = false;
            this.lifeGrid.AllowUserToResizeColumns = false;
            this.lifeGrid.AllowUserToResizeRows = false;
            this.lifeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lifeGrid.ColumnHeadersVisible = false;
            this.lifeGrid.Location = new System.Drawing.Point(11, 87);
            this.lifeGrid.Name = "lifeGrid";
            this.lifeGrid.RowHeadersVisible = false;
            this.lifeGrid.Size = new System.Drawing.Size(503, 403);
            this.lifeGrid.TabIndex = 5;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 502);
            this.Controls.Add(this.lifeGrid);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Game Of life";
            ((System.ComponentModel.ISupportInitialize)(this.lifeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button StartButton;
        private exDGV lifeGrid;
    }
}

