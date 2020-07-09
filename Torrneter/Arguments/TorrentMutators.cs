using System;
using System.Collections.Generic;

namespace Torrneter
{
    /// <summary>
    /** Using an empty array
        for "files-wanted", "files-unwanted", "priority-high", "priority-low", or
        "priority-normal" is shorthand for saying "all files"
    */
    /// </summary>
    public class TorrentMutators
    {
        private KeyValuePair<FieldConnector, int> bandwidthPriority;
        private KeyValuePair<FieldConnector, int> downloadLimit;
        private KeyValuePair<FieldConnector, bool> downloadLimited;
        private KeyValuePair<FieldConnector, int[]> filesWanted;
        private KeyValuePair<FieldConnector, int[]> filesUnwanted;
        private KeyValuePair<FieldConnector, bool> honorsSessionLimits;
        private KeyValuePair<FieldConnector, IDTorrent> ids;
        private KeyValuePair<FieldConnector, string[]> labels;
        private KeyValuePair<FieldConnector, string> location;
        private KeyValuePair<FieldConnector, int> peerLimit;
        private KeyValuePair<FieldConnector, int[]> priorityHigh;
        private KeyValuePair<FieldConnector, int[]> priorityLow;
        private KeyValuePair<FieldConnector, int> queuePosition;
        private KeyValuePair<FieldConnector, int> seedIdleMode;
        private KeyValuePair<FieldConnector, int[]> priorityNormal;
        private KeyValuePair<FieldConnector, int> seedRatioMode;
        private KeyValuePair<FieldConnector, int> seedIdleLimit;
        private KeyValuePair<FieldConnector, double> seedRatioLimit;
        private KeyValuePair<FieldConnector, string[]> trackerAdd;
        private KeyValuePair<FieldConnector, int[]> trackerRemove;
        private KeyValuePair<FieldConnector, Dictionary<int, string>> trackerReplace;
        private KeyValuePair<FieldConnector, int> uploadLimit;
        private KeyValuePair<FieldConnector, bool> uploadLimited;

        public TorrentMutators()
        {
            SetConnectors();
        }

        private void SetConnectors()
        {
            
            throw new NotImplementedException();
        }

        /// <summary>
        /// this torrent's bandwidth tr_priority_t
        /// </summary>
        public KeyValuePair<string, int> GetBandwidthPriority()
        {
            return new KeyValuePair<string, int>("bandwidthPriority", bandwidthPriority);
        }

        /// <summary>
        /// this torrent's bandwidth tr_priority_t
        /// </summary>
        public void SetBandwidthPriority(int value)
        {
            bandwidthPriority
        }


        /// <summary>
        /// maximum download speed (KBps)
        /// </summary>
        public KeyValuePair<string, int> GetDownloadLimit()
        {
            return new KeyValuePair<string, int>("downloadLimit", downloadLimit) ;
        }

        /// <summary>
        /// maximum download speed (KBps)
        /// </summary>
        public void SetDownloadLimit(int value)
        {
            downloadLimit = value;
        }


        /// <summary>
        /// true if "downloadLimit" is honored
        /// </summary>
        public bool GetDownloadLimited()
        {
            return downloadLimited;
        }

        /// <summary>
        /// true if "downloadLimit" is honored
        /// </summary>
        public void SetDownloadLimited(bool value)
        {
            downloadLimited = value;
        }


        /// <summary>
        /// indices of file(s) to download
        /// </summary>
        public int[] GetFilesWanted()
        {
            return fileswanted;
        }


        /// <summary>
        /// indices of file(s) to download
        /// </summary>
        public void SetFilesWanted(int[] value)
        {
            filesWanted = value;
        }

          /// <summary>
        /// indices of file(s) to not download
        /// </summary>
        public int[] GetFilesUnwanted()
        {
            return filesUnwanted;
        }



        /// <summary>
        /// indices of file(s) to not download
        /// </summary>
        public int[] GetFilesUnwanted()
        {
            return filesUnwanted;
        }

        /// <summary>
        /// indices of file(s) to not download
        /// </summary>
        public void SetFilesUnwanted(int[] value)
        {
            filesUnwanted = value;
        }


        /// <summary>
        /// true if session upload limits are honored
        /// </summary>
        public bool GetHonorsSessionLimits()
        {
            return honorsSessionLimits;
        }

        /// <summary>
        /// true if session upload limits are honored
        /// </summary>
        public void SetHonorsSessionLimits(bool value)
        {
            honorsSessionLimits = value;
        }


        /// <summary>
        /// list of torrent id numbers, sha1 hash strings, or both
        /// </summary>
        public IDTorrent Getids()
        {
            return ids;
        }

        /// <summary>
        /// list of torrent id numbers, sha1 hash strings, or both
        /// </summary>
        public void Setids(IDTorrent value)
        {
            ids = value;
        }


        /// <summary>
        /// array of string labels
        /// </summary>
        public string[] GetLabels()
        {
            return labels;
        }

        /// <summary>
        /// array of string labels
        /// </summary>
        public void SetLabels(string[] value)
        {
            labels = value;
        }


        /// <summary>
        /// new location of the torrent's content
        /// </summary>
        public string GetLocation()
        {
            return location;
        }

        /// <summary>
        /// new location of the torrent's content
        /// </summary>
        public void SetLocation(string value)
        {
            location = value;
        }


        /// <summary>
        /// maximum number of peers
        /// </summary>
        public int GetPeerLimit()
        {
            return peerLimit;
        }

        /// <summary>
        /// maximum number of peers
        /// </summary>
        public void SetPeerLimit(int value)
        {
            peerLimit = value;
        }


        /// <summary>
        /// indices of high-priority file(s)
        /// </summary>
        public int[] GetPriorityHigh()
        {
            return priorityHigh;
        }

        /// <summary>
        /// indices of high-priority file(s)
        /// </summary>
        public void SetPriorityHigh(int[] value)
        {
            priorityHigh = value;
        }


        /// <summary>
        /// indices of low-priority file(s)
        /// </summary>
        public int[] GetPriorityLow()
        {
            return priorityLow;
        }

        /// <summary>
        /// indices of low-priority file(s)
        /// </summary>
        public void SetPriorityLow(int[] value)
        {
            priorityLow = value;
        }


        /// <summary>
        /// indices of normal-priority file(s)
        /// </summary>
        public int[] GetPriorityNormal()
        {
            return priorityNormal;
        }

        /// <summary>
        /// indices of normal-priority file(s)
        /// </summary>
        public void SetPriorityNormal(int[] value)
        {
            priorityNormal = value;
        }


        /// <summary>
        /// position of this torrent in its queue [0...n)
        /// </summary>
        public int GetQueuePosition()
        {
            return queuePosition;
        }

        /// <summary>
        /// position of this torrent in its queue [0...n)
        /// </summary>
        public void SetQueuePosition(int value)
        {
            queuePosition = value;
        }


        /// <summary>
        /// torrent-level number of minutes of seeding inactivity
        /// </summary>
        public int GetSeedIdleLimit()
        {
            return seedIdleLimit;
        }

        /// <summary>
        /// torrent-level number of minutes of seeding inactivity
        /// </summary>
        public void SetSeedIdleLimit(int value)
        {
            seedIdleLimit = value;
        }


        /// <summary>
        /// which seeding inactivity to use.  See tr_idlelimit
        /// </summary>
        public int GetSeedIdleMode()
        {
            return seedIdleMode;
        }

        /// <summary>
        /// which seeding inactivity to use.  See tr_idlelimit
        /// </summary>
        public void SetSeedIdleMode(int value)
        {
            seedIdleMode = value;
        }


        /// <summary>
        /// torrent-level seeding ratio
        /// </summary>
        public double GetSeedRatioLimit()
        {
            return seedRatioLimit;
        }

        /// <summary>
        /// torrent-level seeding ratio
        /// </summary>
        public void SetSeedRatioLimit(double value)
        {
            seedRatioLimit = value;
        }


        /// <summary>
        /// which ratio to use.  See tr_ratiolimit
        /// </summary>
        public int GetSeedRatioMode()
        {
            return seedRatioMode;
        }

        /// <summary>
        /// which ratio to use.  See tr_ratiolimit
        /// </summary>
        public void SetSeedRatioMode(int value)
        {
            seedRatioMode = value;
        }


        /// <summary>
        /// strings of announce URLs to add
        /// </summary>
        public string[] GetTrackerAdd()
        {
            return trackerAdd;
        }

        /// <summary>
        /// strings of announce URLs to add
        /// </summary>
        public void SetTrackerAdd(string[] value)
        {
            trackerAdd = value;
        }


        /// <summary>
        /// ids of trackers to remove
        /// </summary>
        public int[] GetTrackerRemove()
        {
            return trackerRemove;
        }

        /// <summary>
        /// ids of trackers to remove
        /// </summary>
        public void SetTrackerRemove(int[] value)
        {
            trackerRemove = value;
        }


        /// <summary>
        /// pairs of <trackerId/new announce URLs>
        /// </summary>
        public Dictionary<int, string> GettrackerReplace()
        {
            return trackerReplace;
        }

        /// <summary>
        /// pairs of <trackerId/new announce URLs>
        /// </summary>
        public void SettrackerReplace(Dictionary<int, string> value)
        {
            trackerReplace = value;
        }


        /// <summary>
        /// maximum upload speed (KBps)
        /// </summary>
        public int GetUploadLimit()
        {
            return uploadLimit;
        }

        /// <summary>
        /// maximum upload speed (KBps)
        /// </summary>
        public void SetUploadLimit(int value)
        {
            uploadLimit = value;
        }


        /// <summary>
        /// true if "uploadLimit" is honored
        /// </summary>
        public bool GetUploadLimited()
        {
            return uploadLimited;
        }

        /// <summary>
        /// true if "uploadLimit" is honored
        /// </summary>
        public void SetUploadLimited(bool value)
        {
            uploadLimited = value;
        }
    }
}