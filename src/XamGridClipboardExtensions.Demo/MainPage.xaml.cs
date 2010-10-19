using System.Windows;
using System.Windows.Controls;
using Infragistics.Controls.Grids;
using XamGridExtensions;

namespace XamGridClipboardExtensions.Demo
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            this.DataContext = new DataSource(21);
        }

        private void XwGridClipboardPasting(object sender, ClipboardPastingEventArgs e)
        {
            XamGrid xamGrid = sender as XamGrid;

            if (xamGrid != null)
            {
                xamGrid.PasteData(e.Values);
            }
        }

        private void XwGridClipboardCopying(object sender, ClipboardCopyingEventArgs e)
        {
            XamGrid xamGrid = sender as XamGrid;

            if (xamGrid != null && !xamGrid.IsSelectionValid())
            {
                MessageBox.Show("Only rectangular single band regions are allowed.");
                e.Cancel = true;
            }
        }
    }
}
