using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using Plugin.Geolocator;

using TravelRecordApp.Logic;
using TravelRecordApp.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var locator = CrossGeolocator.Current;

            var position = await locator.GetPositionAsync();
            // 현재 위치 좌표(위도, 경도) 반환

            var venues = await VenueLogic.GetVenues(position.Latitude, position.Longitude);

            venueListView.ItemsSource = venues;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                var selectedVenue = venueListView.SelectedItem as Venue;
                var firstCategory = selectedVenue.categories.FirstOrDefault();

                Post post = new Post()
                {
                    Experience = expretienceEntry.Text,
                    CategoryId = firstCategory.id,
                    Categoryname = firstCategory.name,
                    Address = selectedVenue.location.address,
                    Distance = selectedVenue.location.distance,
                    Latitude = selectedVenue.location.lat,
                    Longitude = selectedVenue.location.lng,
                    VenueName = selectedVenue.name
                };

                using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    conn.CreateTable<Post>();
                    int rows = conn.Insert(post);

                    if (rows > 0)
                        DisplayAlert("Success", "Expreience succesfully inserter", "ok");
                    else
                        DisplayAlert("Failure", "Expreience failed to be inserted", "ok");
                }
            }
            catch(NullReferenceException nre)
            {

            }
            catch(Exception ex)
            {

            }
        }
    }
}