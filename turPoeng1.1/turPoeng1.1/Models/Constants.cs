using Xamarin.Forms;

namespace turPoeng1.Models
{
    public static class Constants
    {
        // The iOS simulator can connect to localhost. However, Android emulators must use the 10.0.2.2 special alias to your host loopback interface.
        public static string BaseAddress = Device.RuntimePlatform == Device.Android ? "https://10.0.0.15:44395" : "https://localhost:44395";
        public static string PostItemsUrl = BaseAddress + "/api/Posts/get";
    }
}
