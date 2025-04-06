namespace SimpleDrawingApp
{
    public partial class DrawingForm : Form
    {
        public event EventHandler? ClearRequested;
        public DrawingForm()
        {
            InitializeComponent();
            btnClear.Click += (s, e) => ClearRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
