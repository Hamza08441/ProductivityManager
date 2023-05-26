namespace webapi.ViewModels
{
    public class UsersVM
    {
    
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string remember_token { get; set; }
        public Guid user_type_id { get; set; }


    }
}
