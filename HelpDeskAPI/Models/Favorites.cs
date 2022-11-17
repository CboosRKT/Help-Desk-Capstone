using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace HelpDeskAPI
{
    public class Favorites
    {
        public int ticket_id { get; set; }
        public int user_id { get; set; }
    }
}
