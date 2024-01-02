using training_code.Class;
using training_code.Interface;


namespace training_code
{
    class Program : User, IUser, IAdv
    {
        protected static void Main()
        {
            var _usersList = GettingUsersList();
            ShowUsersList(_usersList);

            UserVerify(_usersList);

            Console.ReadKey();
        }

        private static void UserVerify(List<User> list)
        {

            Console.WriteLine($"Select user (input user name): ");
            var recievedData = Console.ReadLine();
            User _user = list.Find(user => user.Name == recievedData);          // без проверки

            if (_user == null)
            {
                Console.WriteLine($"User name is incorrect");
                UserVerify(list);
            }

            Console.WriteLine($"\tUser login: {_user.Login}\n\tUser name: {_user.Name}\n\tUser subscription status: {_user.IsPremium}");

            if (_user.IsPremium == false)
            {
                Console.WriteLine($"User ({_user.Name}) does't has a subscriptin\nMust to watch ADS!!!)");
                IAdv.ShowAds();
            }
        }

        private static User GettingUser()
        {
            var login = IUser.GettingUserLogin();
            var name = IUser.GettingUserName();
            var premium = IUser.GettingPremiumType();
            return new User { Login = login, Name = name, IsPremium = premium };
        }

        private static List<User> GettingUsersList()
        {
            Console.WriteLine($"Input the number of users: ");
            int count = int.Parse(Console.ReadLine());                          // без проверки


            List<User> list = new List<User>();

            for (int i = 0; i < count; i++)
            {
                User user = GettingUser();
                list.Add(user);
            }

            return list;
        }

        private static void ShowUsersList(List<User> list)
        {
            Console.WriteLine($"Users list:");

            foreach (User _user in list)
            {
                Console.WriteLine($"\tUser name: {_user.Name}");
            }
        }

    }
}