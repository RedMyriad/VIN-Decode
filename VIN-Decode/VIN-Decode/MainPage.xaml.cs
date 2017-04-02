using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace VIN_Decode
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            appView.TitleBar.BackgroundColor = Windows.UI.Colors.Black;
            appView.TitleBar.InactiveBackgroundColor = Windows.UI.Colors.Black;
            appView.TitleBar.ButtonBackgroundColor = Windows.UI.Colors.Black;
            appView.TitleBar.ButtonHoverForegroundColor = Windows.UI.Colors.Black;
            appView.TitleBar.ButtonHoverBackgroundColor = Windows.UI.Colors.WhiteSmoke;
            appView.TitleBar.ButtonPressedBackgroundColor = Windows.UI.Colors.WhiteSmoke;
            appView.TitleBar.ButtonInactiveBackgroundColor = Windows.UI.Colors.Black; 
        }

        private async void checkBtn_Click(object sender, RoutedEventArgs e)
        {

            if (vin.Text.Length > 17 || vin.Text.Length < 17)
            {
                resultsBox.Text = "VIN Number Length Is Incorrect";
            }

            int carYear;

            if (int.TryParse(year.Text, out carYear))
            {
               if(carYear > DateTime.Today.Year)
                {
                    resultsBox.Text = "Invalid Year";
                }
                else
                {
                    //Send request
                    RootObject myVin = await Decode.GetInfo(vin.Text, year.Text);

                    //Return Results
                    resultsBox.Text = "Instructions: If a section is empty that means the manufacturer did not provide those details or are inaccessible." + 
                        "\n\n" + "Error code: " + myVin.Results[0].ErrorCode + 
                        "\n" + "Manufacturer: " + myVin.Results[0].Manufacturer +
                        "\n" + "Plant City: " + myVin.Results[0].PlantCity +
                        "\n" + "Plant Country: " + myVin.Results[0].PlantCountry +
                        "\n" + "Model: " + myVin.Results[0].Model +
                        "\n" + "Model Year: " + myVin.Results[0].ModelYear +
                        "\n" + "Body Class: " + myVin.Results[0].BodyClass +
                        "\n" + "Engine Cylinders: " + myVin.Results[0].EngineCylinders +
                        "\n" + "Engine Horsepower: " + myVin.Results[0].EngineHP +
                        "\n" + "Fuel: " + myVin.Results[0].VehicleType +
                        "\n" + "Fuel: " + myVin.Results[0].FuelTypePrimary +
                        "\n" + "Doors: " + myVin.Results[0].Doors +
                        "\n\n" + "Powered by the NHTSA API";
                }
            }
            else
            {
                resultsBox.Text = "Invalid Year Format";
            }
        }
    }
}
