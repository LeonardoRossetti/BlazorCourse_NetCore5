using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Static
{
    public static class Endpoints
    {
        public static string Prefix = "api";

        public static string Makes = $"{Prefix}/makes";
        public static string Vehicles = $"{Prefix}/vehicle";
        public static string Models = $"{Prefix}/model";
        public static string Bookings = $"{Prefix}/bookings";
        public static string Customers = $"{Prefix}/customer";
        public static string Colours = $"{Prefix}/colour";

    }
}
