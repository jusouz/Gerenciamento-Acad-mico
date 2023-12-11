namespace formulario
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static public Form1 form1;
        static public Formulario02 form2;
        static public form03 form3;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            form1 = new Form1();
            form2 = new Formulario02();
            form3 = new form03();
            Application.Run(form3);
        }
    }
}