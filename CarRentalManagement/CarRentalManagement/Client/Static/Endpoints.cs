using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Static
{
    public static class ApiEndpoints
    {
        public static string Prefix = "api";

        public static string Makes = $"{Prefix}/{PagePath.Makes}";
        public static string Vehicles = $"{Prefix}/{PagePath.Vehicles}";
        public static string Models = $"{Prefix}/{PagePath.Models}";
        public static string Bookings = $"{Prefix}/{PagePath.Bookings}";
        public static string Customers = $"{Prefix}/{PagePath.Customers}";
        public static string Colours = $"{Prefix}/{PagePath.Colours}";

    }    
    
    public static class PagePath
    {
        public const string Makes = "makes";
        public const string Vehicles = "vehicle";
        public const string Models = "model";
        public const string Bookings = "bookings";
        public const string Customers = "customer";
        public const string Colours = "colour";

    }


}
