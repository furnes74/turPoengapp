using Xamarin.Forms;

namespace turPoeng1.Models
{
    public static class Constants
    {
        // The iOS simulator can connect to localhost. However, Android emulators must use the 10.0.2.2 special alias to your host loopback interface.
        public static string BaseAddress = Device.RuntimePlatform == Device.Android ? "https://10.0.2.2:44395" : "https://localhost:44395";
        public static string PostItemsUrl = BaseAddress + "/api/Posts/get";
        public static string PostItemUrl = BaseAddress + "/api/Posts/getpost/1";
        public static string FriendItemUrl = BaseAddress + "/api/Person/GetFriends/1";// needs to be modified
        public static string PersonItemsUrl = BaseAddress + "/api/Person/GetPerson/3";
        

    }
}
