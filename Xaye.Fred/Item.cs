﻿namespace Xaye.Fred
{
    /// <summary>
    /// Base class for items that internally keep 
    /// a reference to a <see cref="Fred"/> object.
    /// Used to lazily retrieve additional data.
    /// </summary>
    public abstract class Item
    {
        protected Item(Fred fred)
        {
            Fred = fred;
        }

        internal Fred Fred { get; set; }

        /// <summary>
        /// Notes about an Item.
        /// </summary>
        public string Notes { get; set; }
    }
}