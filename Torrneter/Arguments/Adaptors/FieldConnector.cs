using System;

namespace Torrneter
{
    /// <summary>
    /// This constants provides argument field associations with string values accepted by the API.  
    /// </summary>
    public class FieldConnector
    {
        public const string bandwidthPriority = "bandwidthPriority";
        public const string downloadLimit = "downloadLimit";
        public const string downloadLimited = "downloadLimited";
        public const string filesWanted = "files-wanted";
        public const string filesUnwanted = "files-unwanted";
        public const string honorsSessionLimits = "honorsSessionLimits";
        public const string ids = "ids";
        public const string labels = "labels";
        public const string location = "location";
        public const string peerLimit = "peer-limit";
        public const string priorityHigh = "priority-high";
        public const string priorityLow = "priority-low";
        public const string queuePosition = "priority-normal";
        public const string seedIdleMode = "queuePosition";
        public const string priorityNormal = "seedIdleLimit";
        public const string seedRatioMode = "seedIdleMode";
        public const string seedIdleLimit = "seedRatioLimit";
        public const string seedRatioLimit = "seedRatioMode";
        public const string trackerAdd = "trackerAdd";
        public const string trackerRemove = "trackerRemove";
        public const string trackerReplace = "trackerReplace";
        public const string uploadLimit = "uploadLimit";
        public const string uploadLimited = "uploadLimited";

        
        public string GetApiAlias(string fieldName)
        {
            
            throw new NotImplementedException();
        }

    }
}