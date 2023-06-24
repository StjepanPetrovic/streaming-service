namespace streaming_service
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
            this.dgvUnwatchedMovies = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWatchMovie = new System.Windows.Forms.Button();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnwatchedMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUnwatchedMovies
            // 
            this.dgvUnwatchedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnwatchedMovies.Location = new System.Drawing.Point(28, 47);
            this.dgvUnwatchedMovies.Name = "dgvUnwatchedMovies";
            this.dgvUnwatchedMovies.RowHeadersWidth = 51;
            this.dgvUnwatchedMovies.RowTemplate.Height = 24;
            this.dgvUnwatchedMovies.Size = new System.Drawing.Size(358, 256);
            this.dgvUnwatchedMovies.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unwatched movies:";
            // 
            // btnWatchMovie
            // 
            this.btnWatchMovie.Location = new System.Drawing.Point(52, 325);
            this.btnWatchMovie.Name = "btnWatchMovie";
            this.btnWatchMovie.Size = new System.Drawing.Size(145, 44);
            this.btnWatchMovie.TabIndex = 2;
            this.btnWatchMovie.Text = "Watch movie";
            this.btnWatchMovie.UseVisualStyleBackColor = true;
            this.btnWatchMovie.Click += new System.EventHandler(this.btnWatchMovie_Click);
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Location = new System.Drawing.Point(203, 325);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(145, 44);
            this.btnRefreshTable.TabIndex = 3;
            this.btnRefreshTable.Text = "Refresh table";
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 386);
            this.Controls.Add(this.btnRefreshTable);
            this.Controls.Add(this.btnWatchMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUnwatchedMovies);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnwatchedMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUnwatchedMovies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWatchMovie;
        private System.Windows.Forms.Button btnRefreshTable;
    }
}

