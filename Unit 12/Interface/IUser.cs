namespace training_code.Interface
{
    internal interface IUser
    {
        public static string GettingUserLogin()
        {
            string? login = string.Empty;

            Console.WriteLine($"Input you login: ");
            login = Console.ReadLine();
            var isLogin = string.IsNullOrWhiteSpace(login);

            if (string.IsNullOrWhiteSpace(login) || login == string.Empty)
            {
                return GettingUserLogin();
            }

            return login;
        }

        public static string GettingUserName()
        {
            string? name = string.Empty;

            Console.WriteLine($"Input you name: ");
            name = Console.ReadLine();
            var isName = string.IsNullOrWhiteSpace(name);

            if (string.IsNullOrWhiteSpace(name) || name == string.Empty)
            {
                return GettingUserName();
            }

            return name;
        }

        public static bool GettingPremiumType()
        {
            Console.WriteLine($"Is bought a subscription (Yes or No): ");
            var receivedData = Console.ReadLine()?.ToLower();

            while (string.IsNullOrWhiteSpace(receivedData) || (receivedData != "yes" && receivedData != "no" && receivedData != "y" && receivedData != "n"))
            {
                Console.WriteLine($"The data is invalid ({receivedData})\nPlease, enter yes or no");
                receivedData = Console.ReadLine()?.ToLower();
            }

            return receivedData == "yes" || receivedData == "y";
        }
    }
}
 