using Umbraco.Core.Models.Sections;

namespace UmbHideUsers.App_Plugins.MyFavoriteThings.Sections
{
    public class MyFavoriteThingsSection : ISection
    {
        public string Alias => "myFavoriteThings";

        public string Name => "My Favorite Things";
    }
}