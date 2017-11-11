using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace Raktar.App.Forms
{
	class AppDesign
	{
		public static void Apply(MetroForm form)
		{
			Apply(form, null);
		}

		public static void Apply(MetroForm form, MetroStyleExtender extender)
		{
			form.Theme = MetroThemeStyle.Dark;
			form.Style = MetroColorStyle.Blue;

			MetroStyleManager mgr = new MetroStyleManager(form.Container);

			mgr.Owner = form;
			mgr.Style = form.Style;
			mgr.Theme = form.Theme;

			if (extender != null)
			{
				extender.StyleManager = mgr;
				extender.Style = mgr.Style;
				extender.Theme = mgr.Theme;
			}

			mgr.Update();
		}
	}
}
