﻿using Realms;

namespace Nutriomly.Models
{
    /// <summary>
    /// DbControlModel
    /// </summary>
    public class DbControlModel : RealmObject
    {
        /// <summary>
        /// Key of a DB Control value
        /// </summary>
        [PrimaryKey]
        public string Key { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public string Value { get; set; }
    }

    /// <summary>
    /// DbControlKeys
    /// </summary>
    public enum DbControlKeys
    {
        /// <summary>
        /// DatabaseId
        /// </summary>
        DatabaseId
    }
}
