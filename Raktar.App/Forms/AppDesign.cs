using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace Raktar.App.Forms
{
	class AppDesign
	{
		public static void Apply(MetroForm form)
		{
			form.Theme = MetroThemeStyle.Dark;
			form.Style = MetroColorStyle.Blue;

			MetroStyleManager mgr = new MetroStyleManager(form.Container);

			mgr.Owner = form;
			mgr.Style = form.Style;
			mgr.Theme = form.Theme;

			mgr.Update();
		}
	}
}
