using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace Raktar.App.Forms
{
	class AppDesign
	{
		public static MetroThemeStyle AppStyle = MetroThemeStyle.Light;
		public static MetroColorStyle AppTheme = MetroColorStyle.Blue;

		public static void Apply(MetroForm form)
		{
			Apply(form, null);
		}

		public static void Apply(MetroForm form, MetroStyleExtender extender)
		{
			form.Theme = AppStyle;
			form.Style = AppTheme;

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

			form.ShadowType = MetroFormShadowType.DropShadow;

			mgr.Update();
		}
	}
}
