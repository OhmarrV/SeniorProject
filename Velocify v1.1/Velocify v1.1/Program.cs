namespace Velocify_v1._1
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
            //Application.Run(new Form1());


            int dbUserId = CheckSessionToken();
            if(dbUserId == 0)
            {
                Application.Run(new LoginForm());
            }
            else if(dbUserId > 0) 
            {
                MessageBox.Show("Welcome back user: "+dbUserId.ToString());
                Application.Run(new Form1(dbUserId));
            }
            





            
        }

        static int CheckSessionToken()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            return dbHelper.SearchActiveSessionToken();
        }


    }
}