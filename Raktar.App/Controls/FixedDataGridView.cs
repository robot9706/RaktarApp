using System;
using MetroFramework.Controls;

namespace Raktar.App.Controls
{
	public class FixedDataGridView : MetroGrid
	{
		protected override void OnHandleCreated(EventArgs e)
		{
			//Van egy hiba a System.Windows.Forms.DataGridView control-ban (a MetroGrid ősosztálya),
			//ennek köszönhetően ha az egér a Grid bal felső cellája felett van mikor egy ablak nyílik
			//és a grid automatikusan méretezőtik egy System.InvalidOperationException kapunk.

			//Megoldás: Biztosra kell menni hogy az ablak megnyílása előtt létezik a bal felső cella,
			//ez a TopLeftHeaderCell property olvasásával lehetséges.
			TopLeftHeaderCell.ToString();

			base.OnHandleCreated(e);
		}
	}
}
