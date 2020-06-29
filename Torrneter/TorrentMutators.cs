using System.Collections.Generic;

namespace Torrneter
{
    /// <summary>
    /** Just as an empty "ids" value is shorthand for "all ids", using an empty array
        for "files-wanted", "files-unwanted", "priority-high", "priority-low", or
        "priority-normal" is shorthand for saying "all files"
    */
    /// </summary>
    public class TorrentMutators
    {
        /// <summary>
        /// this torrent's bandwidth tr_priority_t
        /// </summary>
        public int BandwidthPriority { get; set; }
        /// <summary>
        /// maximum download speed (KBps)
        /// </summary>
        public int DownloadLimit { get; set; }
        /// <summary>
        /// true if "downloadLimit" is honored
        /// </summary>
        public bool DownloadLimited { get; set; }
        /// <summary>
        /// indices of file(s) to download
        /// </summary>
        public int[] FilesWanted{get; set;}
        /// <summary>
        /// indices of file(s) to not download
        /// </summary>
        public int[] FilesUnwanted { get; set; }
        /// <summary>
        /// true if session upload limits are honored
        /// </summary>
        public bool HonorsSessionLimits { get; set; }
        /// <summary>
        /// list of torrent id numbers, sha1 hash strings, or both
        /// </summary>
        public int[] IDs { get; set; }
        /// <summary>
        /// array of string labels
        /// </summary>
        public string[] Labels { get; set; }
        /// <summary>
        /// new location of the torrent's content
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// maximum number of peers
        /// </summary>
        public int PeerLimit { get; set; }
        /// <summary>
        /// indices of high-priority file(s)
        /// </summary>
        public int[] PriorityHigh { get; set; }
        /// <summary>
        /// indices of low-priority file(s)
        /// </summary>
        public int[] PriorityLow { get; set; }
        /// <summary>
        /// indices of normal-priority file(s)
        /// </summary>
        public int[] PriorityNormal { get; set; }
        /// <summary>
        /// position of this torrent in its queue [0...n)
        /// </summary>
        public int QueuePosition { get; set; }
        /// <summary>
        /// torrent-level number of minutes of seeding inactivity
        /// </summary>
        public int SeedIdleLimit { get; set; }
        /// <summary>
        /// which seeding inactivity to use.  See tr_idlelimit
        /// </summary>
        public int SeedIdleMode { get; set; }
        /// <summary>
        /// torrent-level seeding ratio
        /// </summary>
        public double SeedRatioLimit { get; set; }
        /// <summary>
        /// which ratio to use.  See tr_ratiolimit
        /// </summary>
        public int SeedRatioMode { get; set; }
        /// <summary>
        /// strings of announce URLs to add
        /// </summary>
        public string[] TrackerAdd { get; set; }
        /// <summary>
        /// ids of trackers to remove
        /// </summary>
        public int[] trackerRemove { get; set; }
        
        private Dictionary<int, string> _trackerReplace;
        /// <summary>
        /// maximum upload speed (KBps)
        /// </summary>
        public int UploadLimit { get; set; }

        /// <summary>
        /// true if "uploadLimit" is honored
        /// </summary>
        public bool UploadLimited { get; set; }

        /// <summary>
        /// pairs of <trackerId/new announce URLs>
        /// </summary>
        public void TrackerReplace(int TrackerID, string NewURL)
        {
            _trackerReplace.Add(TrackerID, NewURL);
        }

        /// <summary>
        /// pairs of <trackerId/new announce URLs>
        /// </summary>
        public void TrackerReplace(Dictionary<int, string> TrackerReplaceDictionary)
        {
            _trackerReplace = TrackerReplaceDictionary;

        }

        /// <summary>
        /// pairs of <trackerId/new announce URLs>
        /// </summary>
        public Dictionary<int, string> GetTrackerReplaceDictionary()
        {
            return _trackerReplace;
        }
    }
}