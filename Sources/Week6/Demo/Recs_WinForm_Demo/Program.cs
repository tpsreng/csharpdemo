namespace Recs_WinForm_Demo
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
            InitRectangles();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static List<Rectangle> Recs => _recs;
        private static List<Rectangle> _recs = new();
        private static void InitRectangles()
        {
            (new List<Rectangle> 
            {
                Rectangle.CreateInstance(5, 8),
                Rectangle.CreateInstance(6, 8),
                Rectangle.CreateInstance(3, 7),
                Rectangle.CreateInstance(2, 12),
                Rectangle.CreateInstance(4, 9),
            }).ForEach(rect => { _recs.Add(rect); });
        }
    }
}