using System;
using System.Collections.Generic;
using Torrneter.Arguments;

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
        private CustomPair< int> bandwidthPriority;
        private CustomPair< int> downloadLimit;
        private CustomPair< bool> downloadLimited;
        private CustomPair< int[]> filesWanted;
        private CustomPair< int[]> filesUnwanted;
        private CustomPair< bool> honorsSessionLimits;
        private CustomPair< IDTorrent> ids;
        private CustomPair< string[]> labels;
        private CustomPair< string> location;
        private CustomPair< int> peerLimit;
        private CustomPair< int[]> priorityHigh;
        private CustomPair< int[]> priorityLow;
        private CustomPair< int> queuePosition;
        private CustomPair< int> seedIdleMode;
        private CustomPair< int[]> priorityNormal;
        private CustomPair< int> seedRatioMode;
        private CustomPair< int> seedIdleLimit;
        private CustomPair< double> seedRatioLimit;
        private CustomPair< string[]> trackerAdd;
        private CustomPair< int[]> trackerRemove;
        private CustomPair< Dictionary<int, string>> trackerReplace;
        private CustomPair< int> uploadLimit;
        private CustomPair< bool> uploadLimited;
        

      
     public TorrentMutators(FieldConnector fieldConnector) 
        {
            SetAllKeys(fieldConnector);
        }

        private void SetAllKeys(FieldConnector fd)
        {
            bandwidthPriority = new CustomPair<int>(fd.GetApiAlias(nameof(bandwidthPriority)));
            downloadLimit = new CustomPair<int>(fd.GetApiAlias(nameof(downloadLimit)));
            downloadLimited = new CustomPair<bool>(fd.GetApiAlias(nameof(downloadLimited)));
            filesWanted = new CustomPair<int[]>(fd.GetApiAlias(nameof(filesWanted)));
            filesUnwanted = new CustomPair<int[]>(fd.GetApiAlias(nameof(filesUnwanted)));
            honorsSessionLimits = new CustomPair<bool>(fd.GetApiAlias(nameof(honorsSessionLimits)));
            ids = new CustomPair<IDTorrent>(fd.GetApiAlias(nameof(ids)));
            labels = new CustomPair<string[]>(fd.GetApiAlias(nameof(labels)));
            location = new CustomPair<string>(fd.GetApiAlias(nameof(location)));
            peerLimit = new CustomPair<int>(fd.GetApiAlias(nameof(peerLimit)));
            priorityHigh = new CustomPair<int[]>(fd.GetApiAlias(nameof(priorityHigh)));
            priorityLow = new CustomPair<int[]>(fd.GetApiAlias(nameof(priorityLow)));
            queuePosition = new CustomPair<int>(fd.GetApiAlias(nameof(queuePosition)));
            seedIdleMode = new CustomPair<int>(fd.GetApiAlias(nameof(seedIdleMode)));
            priorityNormal = new CustomPair<int[]>(fd.GetApiAlias(nameof(priorityNormal)));
            seedRatioMode = new CustomPair<int>(fd.GetApiAlias(nameof(seedRatioMode)));
            seedIdleLimit = new CustomPair<int>(fd.GetApiAlias(nameof(seedIdleLimit)));
            seedRatioLimit = new CustomPair<double>(fd.GetApiAlias(nameof(seedRatioLimit)));
            trackerAdd = new CustomPair<string[]>(fd.GetApiAlias(nameof(trackerAdd)));
            trackerRemove = new CustomPair<int[]>(fd.GetApiAlias(nameof(trackerRemove)));
            trackerReplace = new CustomPair<Dictionary<int, string>>(fd.GetApiAlias(nameof(trackerReplace)));
            uploadLimit = new CustomPair<int>(fd.GetApiAlias(nameof(uploadLimit)));
            uploadLimited = new CustomPair<bool>(fd.GetApiAlias(nameof(uploadLimited)));
        }

        /// <summary>
        /// this torrent's bandwidth tr_priority_t
        /// </summary>
        public int GetBandwidthPriority()
        {
            return bandwidthPriority.Value;
        }

        /// <summary>
        /// this torrent's bandwidth tr_priority_t
        /// </summary>
        public void SetBandwidthPriority(int value)
        {
            bandwidthPriority.Value = value;
        }

      
      


        /// <summary>
        /// maximum download speed (KBps)
        /// </summary>
        public int GetDownloadLimit()
        {
            return downloadLimit.Value;
        }

        public string GetDownloadLimitAlias()
        {
            return downloadLimit.Alias;
        }

        /// <summary>
        /// maximum download speed (KBps)
        /// </summary>
        public void SetDownloadLimit(int value)
        {
            downloadLimit.Value = value;
        }


        /// <summary>
        /// true if "downloadLimit" is honored
        /// </summary>
        public bool GetDownloadLimited()
        {
            return downloadLimited.Value;
        }

        public string GetDownloadLimitedAlias()
        {
            return downloadLimited.Alias;
        }

        /// <summary>
        /// true if "downloadLimit" is honored
        /// </summary>
        public void SetDownloadLimited(bool value)
        {
            downloadLimited.Value = value;
        }


        /// <summary>
        /// indices of file(s) to download
        /// </summary>
        public int[] GetFilesWanted()
        {
            return filesWanted.Value;
        }



        public string GetFilesWantedAlias()
        {
            return filesWanted.Alias;
        }


        /// <summary>
        /// indices of file(s) to download
        /// </summary>
        public void SetFilesWanted(int[] value)
        {
            filesWanted.Value =  value;
        }

          /// <summary>
        /// indices of file(s) to not download
        /// </summary>
        public int[] GetFilesUnwanted()
        {
            return filesUnwanted.Value;
        }

        public string GetFilesUnwantedAlias()
        {
            return filesUnwanted.Alias;
        }



        /// <summary>
        /// indices of file(s) to not download
        /// </summary>
        public void SetFilesUnwanted(int[] value)
        {
            filesUnwanted.Value = value;
        }


        /// <summary>
        /// true if session upload limits are honored
        /// </summary>
        public bool GetHonorsSessionLimits()
        {
            return honorsSessionLimits.Value;
        }

        public string GetHonorsSessionLimitsAlias()
        {
            return honorsSessionLimits.Alias;
        }
        /// <summary>
        /// true if session upload limits are honored
        /// </summary>
        public void SetHonorsSessionLimits(bool value)
        {
            honorsSessionLimits.Value = value;
        }


        /// <summary>
        /// list of torrent id numbers, sha1 hash strings, or both
        /// </summary>
        public IDTorrent Getids()
        {
            return ids.Value;
        }

        public string GetidsAlias()
        {
            return ids.Alias;
        }


        /// <summary>
        /// list of torrent id numbers, sha1 hash strings, or both
        /// </summary>
        public void Setids(IDTorrent value)
        {
            ids.Value = value;
        }


        /// <summary>
        /// array of string labels
        /// </summary>
        public string[] GetLabels()
        {
            return labels.Value;
        }

        public string GetLabelsAlias()
        {
            return labels.Alias;
        }

        /// <summary>
        /// array of string labels
        /// </summary>
        public void SetLabels(string[] value)
        {
            labels.Value = value;
        }


        /// <summary>
        /// new location of the torrent's content
        /// </summary>
        public string GetLocation()
        {
            return location.Value;
        }

        public string GetLocationAlias()
        {
            return location.Alias;
        }

        /// <summary>
        /// new location of the torrent's content
        /// </summary>
        public void SetLocation(string value)
        {
            location.Value = value;
        }


        /// <summary>
        /// maximum number of peers
        /// </summary>
        public int GetPeerLimit()
        {
            return peerLimit.Value;
        }

        public string GetPeerLimitAlias()
        {
            return peerLimit.Alias;
        }

        /// <summary>
        /// maximum number of peers
        /// </summary>
        public void SetPeerLimit(int value)
        {
            peerLimit.Value = value;
        }


        /// <summary>
        /// indices of high-priority file(s)
        /// </summary>
        public int[] GetPriorityHigh()
        {
            return priorityHigh.Value;
        }

        public string GetPriorityHighAlias()
        {
            return priorityHigh.Alias;
        }

        /// <summary>
        /// indices of high-priority file(s)
        /// </summary>
        public void SetPriorityHigh(int[] value)
        {
            priorityHigh.Value = value;
        }


        /// <summary>
        /// indices of low-priority file(s)
        /// </summary>
        public int[] GetPriorityLow()
        {
            return priorityLow.Value;
        }

        public string GetPriorityLowAlias()
        {
            return priorityLow.Alias;
        }

        /// <summary>
        /// indices of low-priority file(s)
        /// </summary>
        public void SetPriorityLow(int[] value)
        {
            priorityLow.Value = value;
        }


        /// <summary>
        /// indices of normal-priority file(s)
        /// </summary>
        public int[] GetPriorityNormal()
        {
            return priorityNormal.Value;
        }

        public string GetPriorityNormalAlias()
        {
            return priorityNormal.Alias;
        }

        /// <summary>
        /// indices of normal-priority file(s)
        /// </summary>
        public void SetPriorityNormal(int[] value)
        {
            priorityNormal.Value = value;
        }


        /// <summary>
        /// position of this torrent in its queue [0...n)
        /// </summary>
        public int GetQueuePosition()
        {
            return queuePosition.Value;
        }

        public string GetQueuePositionAlias()
        {
            return queuePosition.Alias;
        }

        /// <summary>
        /// position of this torrent in its queue [0...n)
        /// </summary>
        public void SetQueuePosition(int value)
        {
            queuePosition.Value = value;
        }


        /// <summary>
        /// torrent-level number of minutes of seeding inactivity
        /// </summary>
        public int GetSeedIdleLimit()
        {
            return seedIdleLimit.Value;
        }

        public string GetSeedIdleLimitAlias()
        {
            return seedIdleLimit.Alias;
        }

        /// <summary>
        /// torrent-level number of minutes of seeding inactivity
        /// </summary>
        public void SetSeedIdleLimit(int value)
        {
            seedIdleLimit.Value = value;
        }


        /// <summary>
        /// which seeding inactivity to use.  See tr_idlelimit
        /// </summary>
        public int GetSeedIdleMode()
        {
            return seedIdleMode.Value;
        }

        public string GetSeedIdleModeAlias()
        {
            return seedIdleMode.Alias;
        }

        /// <summary>
        /// which seeding inactivity to use.  See tr_idlelimit
        /// </summary>
        public void SetSeedIdleMode(int value)
        {
            seedIdleMode.Value = value;
        }


        /// <summary>
        /// torrent-level seeding ratio
        /// </summary>
        public double GetSeedRatioLimit()
        {
            return seedRatioLimit.Value;
        }

        public string GetSeedRatioLimitAlias()
        {
            return seedRatioLimit.Alias;
        }

        /// <summary>
        /// torrent-level seeding ratio
        /// </summary>
        public void SetSeedRatioLimit(double value)
        {
            seedRatioLimit.Value = value;
        }


        /// <summary>
        /// which ratio to use.  See tr_ratiolimit
        /// </summary>
        public int GetSeedRatioMode()
        {
            return seedRatioMode.Value;
        }

        public string GetSeedRatioModeAlias()
        {
            return seedRatioMode.Alias;
        }
        /// <summary>
        /// which ratio to use.  See tr_ratiolimit
        /// </summary>
        public void SetSeedRatioMode(int value)
        {
            seedRatioMode.Value = value;
        }


        /// <summary>
        /// strings of announce URLs to add
        /// </summary>
        public string[] GetTrackerAdd()
        {
            return trackerAdd.Value;
        }
        public string[] GetTrackerAddAlias()
        {
            return trackerAdd.Alias;
        }

        /// <summary>
        /// strings of announce URLs to add
        /// </summary>
        public void SetTrackerAdd(string[] value)
        {
            trackerAdd.Value = value;
        }


        /// <summary>
        /// ids of trackers to remove
        /// </summary>
        public int[] GetTrackerRemove()
        {
            return trackerRemove.Value;
        }
        public int[] GetTrackerRemoveAlias()
        {
            return trackerRemove.Alias;
        }

        /// <summary>
        /// ids of trackers to remove
        /// </summary>
        public void SetTrackerRemove(int[] value)
        {
            trackerRemove.Value = value;
        }


        /// <summary>
        /// pairs of <trackerId/new announce URLs>
        /// </summary>
        public Dictionary<int, string> GettrackerReplace()
        {
            return trackerReplace.Value;
        }
        public Dictionary<int, string> GettrackerReplaceAlias()
        {
            return trackerReplace.Alias;
        }

        /// <summary>
        /// pairs of <trackerId/new announce URLs>
        /// </summary>
        public void SettrackerReplace(Dictionary<int, string> value)
        {
            trackerReplace.Value = value;
        }


        /// <summary>
        /// maximum upload speed (KBps)
        /// </summary>
        public int GetUploadLimit()
        {
            return uploadLimit.Value;
        }
        public int GetUploadLimitAlias()
        {
            return uploadLimit.Alias;
        }

        /// <summary>
        /// maximum upload speed (KBps)
        /// </summary>
        public void SetUploadLimit(int value)
        {
            uploadLimit.Value = value;
        }


        /// <summary>
        /// true if "uploadLimit" is honored
        /// </summary>
        public bool GetUploadLimited()
        {
            return uploadLimited.Value;
        }
        public bool GetUploadLimitedAlias()
        {
            return uploadLimited.Alias;
        }

        
        /// <summary>
        /// true if "uploadLimit" is honored
        /// </summary>
        public void SetUploadLimited(bool value)
        {
            uploadLimited.Value = value;
        }
    }
}