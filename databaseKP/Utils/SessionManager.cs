using System;

namespace databaseKP.Utils
{
    public static class SessionManager
    {
        public static int UserId { get; set; }
        public static string Login { get; set; }
        public static string FullName { get; set; }
        public static string Role { get; set; } // "Гость" или "Кадровик"
        public static bool IsLoggedIn => UserId != 0;

        // Только Кадровик может редактировать и экспортировать
        public static bool CanEdit => Role == "Кадровик";
    }
}