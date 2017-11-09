using Nutriomly.Views;
using System;

using Xamarin.Forms;

namespace Nutriomly
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page itemsPage, aboutPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    itemsPage = new NavigationPage(new HomePage())
                    {
                        Title = "Mi comida"
                    };

                    aboutPage = new NavigationPage(new AboutPage())
                    {
                        Title = "Info"
                    };
                    itemsPage.Icon = "tab_feed.png";
                    aboutPage.Icon = "tab_about.png";
                    break;
                default:
                    itemsPage = new HomePage()
                    {
                        Title = "Mi comida"
                    };

                    aboutPage = new AboutPage()
                    {
                        Title = "Info"
                    };
                    break;
            }

            Children.Add(itemsPage);
            Children.Add(aboutPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
