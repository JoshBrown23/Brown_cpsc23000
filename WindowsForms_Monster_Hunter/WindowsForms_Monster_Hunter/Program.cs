using WindowsForms_Monster_Hunter.Controllers;

namespace WindowsForms_Monster_Hunter
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
            WeaponController wc = new WeaponController();
            Application.Run(new Views.MonsterHunterWeaponForm(wc));
        }
    }
}