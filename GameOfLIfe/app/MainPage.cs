using System;
using System.Threading;
using System.Windows.Forms;

namespace GameOfLife.app
{
    public partial class MainPage : Form
    {
        private readonly AnimateGrid _animateGrid;

        public MainPage()
        {
            InitializeComponent();

            CreateInitialGrid();

            _animateGrid = new AnimateGrid(lifeGrid);
            
        }

        //Create the first grid
        public void CreateInitialGrid()
        {
            FormClosing += CloseForm;
            Shown += ShowForm;
            lifeGrid.SuspendLayout();

            for (var x = 0; x <= 99; x++)
            {
                lifeGrid.Columns.Add("", "");
                lifeGrid.Columns[x].Width = 4;
            }

            lifeGrid.Rows.Add(100);

            for (var x = 0; x <= 99; x++)
            {
                lifeGrid.Rows[x].Height = 4;
            }
            lifeGrid.ResumeLayout();
        }

        //Set initial values
        private void ShowForm(object sender, EventArgs e)
        {
            lifeGrid.CurrentCell = null;
            lifeGrid.ShowCellToolTips = false;
        }        

        //Cancel animation on closing the form
        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            _animateGrid.Cancelled = true;
        }

        //Button command that starts the live or death process
        private void StartCommand(object sender, EventArgs e)
        {
            _animateGrid.SetInitalValue();
            _animateGrid.Cancelled = true;
            var backgroundThread = new Thread(_animateGrid.GiveLifeOrDeath);
            backgroundThread.Start(3);
        }
    }
}