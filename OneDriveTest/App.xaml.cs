using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Identity.Client;
namespace OneDriveTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string ClientId = "cbc1b653-d562-4e3c-977a-c24749234a05";

        public static PublicClientApplication PublicClientApp = new PublicClientApplication(ClientId);
    }
}
