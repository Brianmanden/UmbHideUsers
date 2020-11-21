using UmbHideUsers.App_Plugins.MyFavoriteThings.Sections;
using Umbraco.Core.Composing;
using Umbraco.Web;

namespace UmbHideUsers.App_Plugins.MyFavoriteThings
{
    public class SectionComposer : IUserComposer
    {
        public void Compose(Composition composition) {
            composition.Sections().Append<MyFavoriteThingsSection>();
        }
    }
}