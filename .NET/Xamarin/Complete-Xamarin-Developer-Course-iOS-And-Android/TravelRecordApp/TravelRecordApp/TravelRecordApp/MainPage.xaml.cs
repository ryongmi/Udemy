using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage);

            iconImage.Source = ImageSource.FromResource("TravelRecordApp.Assets.Images.images.jpg", assembly);
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(email_Entry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(password_Entry.Text);
            // string.IsNullOrEmpty(string value) : value가 비어있으면 True, 값이 있다면 False를 반환.

            if (isEmailEmpty || isPasswordEmpty)
            {

            }
            else
            {
                Navigation.PushAsync(new HomePage());
                // 새 페이지 열기, 새 페이지가 열리면 뒤로가기하면 로그인페이지(첫페이지)로 이동가능
            }
        }
    }
}
