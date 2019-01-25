using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewModdingAPI;
using StardewValley;

namespace StardewImportantInventory
{
    internal class Modentry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            throw new NotImplementedException();
        }

        private Char CatchItems;

        private void getItems(object sender, EventArgs e)
        {
            if (Game1.player.hasItemInInventoryNamed("Rainbow Scale"))
            this.Monitor.Log($"Player has a Rainbow Scale");


        }


    }
}




