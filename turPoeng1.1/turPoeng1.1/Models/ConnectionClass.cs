using Plugin.Connectivity;
using System;


namespace App2.classes
{
    public class ConnectionClass
    {
        public bool IsWeOnline()
        {
            try
            {
                if (CrossConnectivity.Current.IsConnected)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
