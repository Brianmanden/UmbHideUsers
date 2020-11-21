using UmbHideUsers.App_Plugins.CustomUserList.Sections;
using Umbraco.Core.Composing;
using Umbraco.Web;

namespace UmbHideUsers.App_Plugins.CustomUserList.Composers
{
    public class SectionComposer : IUserComposer
    {
        public void Compose(Composition composition) {
            composition.Sections().Append<CustomUserListSection>();
            composition.Sections().Insert<CustomUserListSection>(4);
        }
    }
}