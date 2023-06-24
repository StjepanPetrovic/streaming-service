using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace streaming_service
{
    public partial class Form1 : Form
    {
        StreamingService streamingService = new StreamingService();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWatchMovie_Click(object sender, EventArgs e)
        {
            Movie selectedMovie = dgvUnwatchedMovies.CurrentRow.DataBoundItem as Movie;

            streamingService.watchMovie(selectedMovie);

            dgvUnwatchedMovies.CurrentRow.DefaultCellStyle.ForeColor = Color.Red;
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            dgvUnwatchedMovies.DataSource = streamingService.getUnwatchedMovies().ToList();
        }
    }
}
