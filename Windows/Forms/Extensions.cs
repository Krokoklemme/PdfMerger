// Copyright © 2019 Henning Hoppe
// This work is free.You can redistribute it and/or modify it under the
// terms of the Do What The Fuck You Want To Public License, Version 2,
// as published by Sam Hocevar.See the COPYING file or http://www.wtfpl.net/
// for more details.

namespace PdfMerger.Windows.Forms
{
    using System.Windows.Forms;

    internal static class Extensions
    {
        /// <summary>
        /// Adds a new unique item to the collection.
        /// </summary>
        /// <param name="this">The collection to add the item to.</param>
        /// <param name="item">The text item to add.</param>
        public static void AddUniqueInvariant(this ListView.ListViewItemCollection @this, string item)
        {
            var duplicate = false;

            foreach (ListViewItem i in @this)
            {
                if (i.Text.ToLowerInvariant() == item.ToLowerInvariant())
                {
                    duplicate = true;
                    break;
                }
            }

            if (!duplicate)
            {
                @this.Add(item);
            }
        }
    }
}
