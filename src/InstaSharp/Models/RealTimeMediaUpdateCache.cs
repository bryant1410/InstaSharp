﻿using System.Collections.Generic;

namespace InstaSharp.Models
{
    public class RealTimeMediaUpdateCache
    {
        public RealTimeMediaUpdateCache()
        {
            MostRecentMediaTagIds = new Dictionary<string, string>();
        }
        /// <summary>
        /// cache of most recent tag ids so we know where to begin when doing a callback
        /// </summary>
        /// <example>{{"csharp","1235346"},{"angular","890123123"}}</example>
        public Dictionary<string, string> MostRecentMediaTagIds;

        //TODO: Can be extended to hold caches for Locations etc
    }
}