﻿namespace BetterMixedSeeds.Config
{
    /// <summary>Data about a crop.</summary>
    public class Crop
    {
        /// <summary>The crops name, this is the display name used in the configuration.</summary>
        public string Name { get; set; }

        /// <summary>Whether the crop should get added the seed list.</summary>
        public bool Enabled { get; set; }

        /// <summary>The chance the crop will have at being picked.</summary>
        public int Chance { get; set; }

        /// <summary>Construct an instance.</summary>
        /// <param name="name">Crop name.</param>
        /// <param name="enabled">Whether the crop is enabled.</param>
        /// <param name="chance">The crop chance.</param>
        public Crop(string name, bool enabled, int chance)
        {
            Name = name;
            Enabled = enabled;
            Chance = chance;
        }
    }
}
