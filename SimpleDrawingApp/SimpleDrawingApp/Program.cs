namespace SimpleDrawingApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DrawingForm form = new DrawingForm();
            DrawingModel model = new DrawingModel();
            DrawingController dc = new DrawingController(model, form);
            Application.Run(form);
        }
    }
}