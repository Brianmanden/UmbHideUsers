using Umbraco.Core.Models.Sections;

namespace UmbHideUsers.App_Plugins.CustomUserList.Sections
{
    public class CustomUserListSection : ISection
    {
        public string Alias => "customUserList";

        public string Name => "Custom User List";
    }
}