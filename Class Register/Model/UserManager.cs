using System.Collections.ObjectModel;


namespace Class_Register.Model
{
    public class UserManager
    {
        public static ObservableCollection<User> _DatabaseUser = new ObservableCollection<User>()
        {
            new User() { Name = "Eric Musonda", Province="Eastern Province", District="Chipata", Constituency="Chipata Central", NRC="1100", Ward="Lumba Ward 04" },
            new User { Name = "Gary Banda", Province="Eastern Province", District="Chipata", Constituency="Chipata Central", NRC="1101", Ward="Lumba Ward 01" },
            new User { Name = "Muma Mwanza", Province="Eastern Province", District="Chipata", Constituency="Chipata Central", NRC="1102", Ward="Lumba Ward 04" },
            new User { Name = "Billy Zulu", Province="Lusaka Province", District="Lusaka", Constituency="Lusaka Central", NRC="1105", Ward="Bauleni 04 Ward" },
            new User { Name = "Eric Musonda", Province="Western Province", District="Mongu", Constituency="Mongu Central", NRC="1200", Ward="Lumului Ward 04" },
        };
        public static ObservableCollection<User> GetUsers()
        {
            return _DatabaseUser;
        }
        public static void AddUser(User user)
        {
            _DatabaseUser.Add(user);
        }
    }
}
