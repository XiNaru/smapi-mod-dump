﻿using StardewModdingAPI;

namespace PlantablePalmTrees
{
    class PlantablePalmTreesConfig
    {
        public bool Use_Modifier_Key { get; set; } = false;
        public SButton Modifier_Key { get; set; } = SButton.LeftAlt;
        public bool Require_Tilled_Soil { get; set; } = false;
        public bool Show_Placement_Icon { get; set; } = true;
        public bool Enable_Mushroom_Tree_Planting { get; set; } = false;
        public bool Enable_Planting_in_Mines { get; set; } = false;
    }
}
