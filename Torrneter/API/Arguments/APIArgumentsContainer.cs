using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public class APIArgumentsContainer : APIContainer
    {
        private List<IDataScheme> list;
        private static readonly APIArgumentsContainer Instance = new APIArgumentsContainer();
        private APIArgumentsContainer()
        {
            Initialize();
        }

        public static APIArgumentsContainer GetInstance()
        {
            return Instance;
        }

        private void Initialize()
        {
            list = new List<IDataScheme>
            {
                new DataScheme("activeTorrentCount", typeof(int), APIMethods.SessionStats),
                new DataScheme("activityDate", typeof(int), APIMethods.TorrentGet),
                new DataScheme("addedDate", typeof(int), APIMethods.TorrentGet),
                new DataScheme("alt-speed-down", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("alt-speed-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("alt-speed-time-begin", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("alt-speed-time-day", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("alt-speed-time-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("alt-speed-time-end", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("alt-speed-up", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("bandwidthPriority", typeof(int), APIMethods.TorrentSet, APIMethods.TorrentGet),
                new DataScheme("bandwidthPriority", typeof(int), APIMethods.TorrentAdd),
                new DataScheme("blocklist-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("blocklist-size", typeof(int), APIMethods.SessionGet),
                new DataScheme("blocklist-url", typeof(string), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("cache-size-mb", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("comment", typeof(string), APIMethods.TorrentGet),
                new DataScheme("config-dir", typeof(string), APIMethods.SessionGet),
                new DataScheme("cookies", typeof(string), APIMethods.TorrentAdd),
                new DataScheme("corruptEver", typeof(int), APIMethods.TorrentGet),
                new DataScheme("creator", typeof(string), APIMethods.TorrentGet),
                new DataScheme("dateCreated", typeof(int), APIMethods.TorrentGet),
                new DataScheme("delete-local-data", typeof(bool), APIMethods.TorrentRemove),
                new DataScheme("desiredAvailable", typeof(int), APIMethods.TorrentGet),
                new DataScheme("dht-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("doneDate", typeof(int), APIMethods.TorrentGet),
                new DataScheme("downloadDir", typeof(string), APIMethods.TorrentGet),
                new DataScheme("download-dir", typeof(string), APIMethods.SessionGet, APIMethods.SessionSet, APIMethods.TorrentAdd),
                new DataScheme("downloadedEver", typeof(int), APIMethods.TorrentGet),
                new DataScheme("downloadLimit", typeof(int), APIMethods.TorrentGet, APIMethods.TorrentSet),
                new DataScheme("downloadLimited", typeof(bool), APIMethods.TorrentGet, APIMethods.TorrentSet),
                new DataScheme("download-queue-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("download-queue-size", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("downloadSpeed", typeof(int), APIMethods.SessionStats),
                new DataScheme("encryption", typeof(string), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("error", typeof(int), APIMethods.TorrentGet),
                new DataScheme("errorString", typeof(string), APIMethods.TorrentGet),
                new DataScheme("eta", typeof(int), APIMethods.TorrentGet),
                new DataScheme("etaIdle", typeof(int), APIMethods.TorrentGet),
                new DataScheme("filename", typeof(string), APIMethods.TorrentAdd),
                new DataScheme("files-unwanted", typeof(List<string>), APIMethods.TorrentAdd, APIMethods.TorrentSet),
                new DataScheme("files-wanted", typeof(List<string>), APIMethods.TorrentAdd, APIMethods.TorrentSet),
                new DataScheme("hashString", typeof(string), APIMethods.TorrentGet),
                new DataScheme("haveUnchecked", typeof(int), APIMethods.TorrentGet),
                new DataScheme("haveValid", typeof(int), APIMethods.TorrentGet),
                new DataScheme("honorsSessionLimits", typeof(bool), APIMethods.TorrentGet, APIMethods.TorrentSet),
                new DataScheme("id", typeof(IDTorrent), APIMethods.TorrentGet),
                new DataScheme("idle-seeding-limit", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("idle-seeding-limit-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("ids", typeof(IDTorrent), APIMethods.TorrentRenamePath, APIMethods.TorrentSet, APIMethods.TorrentRemove, APIMethods.TorrentSetLocation),
                new DataScheme("incomplete-dir", typeof(string), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("incomplete-dir-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("isFinished", typeof(bool), APIMethods.TorrentGet),
                new DataScheme("isPrivate", typeof(bool), APIMethods.TorrentGet),
                new DataScheme("isStalled", typeof(bool), APIMethods.TorrentGet),
                new DataScheme("leftUntilDone", typeof(int), APIMethods.TorrentGet),
                new DataScheme("location", typeof(string), APIMethods.TorrentSetLocation, APIMethods.TorrentSet),
                new DataScheme("lpd-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("magnetLink", typeof(string), APIMethods.TorrentGet),
                new DataScheme("manualAnnounceTime", typeof(int), APIMethods.TorrentGet),
                new DataScheme("maxConnectedPeers", typeof(int), APIMethods.TorrentGet),
                new DataScheme("metadataPercentComplete", typeof(double), APIMethods.TorrentGet),
                new DataScheme("metainfo", typeof(string), APIMethods.TorrentAdd),
                new DataScheme("move", typeof(bool), APIMethods.TorrentSetLocation),
                new DataScheme("name", typeof(string), APIMethods.TorrentRenamePath, APIMethods.TorrentGet),
                new DataScheme("path", typeof(string), APIMethods.FreeSpace, APIMethods.TorrentRenamePath),
                new DataScheme("paused", typeof(bool), APIMethods.TorrentAdd),
                new DataScheme("pausedTorrentCount", typeof(int), APIMethods.SessionStats),
                new DataScheme("peer-limit", typeof(int), APIMethods.TorrentGet, APIMethods.TorrentSet, APIMethods.TorrentAdd),
                new DataScheme("peer-limit-global", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("peer-limit-per-torrent", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("peer-port", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("peer-port-random-on-start", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("peersConnected", typeof(int), APIMethods.TorrentGet),
                new DataScheme("peersGettingFromUs", typeof(int), APIMethods.TorrentGet),
                new DataScheme("peersSendingToUs", typeof(int), APIMethods.TorrentGet),
                new DataScheme("percentDone", typeof(double), APIMethods.TorrentGet),
                new DataScheme("pex-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("pieceCount", typeof(int), APIMethods.TorrentGet),
                new DataScheme("pieces", typeof(string), APIMethods.TorrentGet),
                new DataScheme("pieceSize", typeof(int), APIMethods.TorrentGet),
                new DataScheme("port-forwarding-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("priorities", typeof(List<int>), APIMethods.TorrentGet),
                new DataScheme("priority-high", typeof(List<string>), APIMethods.TorrentAdd, APIMethods.TorrentSet),
                new DataScheme("priority-low", typeof(List<string>), APIMethods.TorrentAdd, APIMethods.TorrentSet),
                new DataScheme("priority-normal", typeof(List<string>), APIMethods.TorrentAdd, APIMethods.TorrentSet),
                new DataScheme("queuePosition", typeof(int), APIMethods.TorrentGet, APIMethods.TorrentSet),
                new DataScheme("queue-stalled-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("queue-stalled-minutes", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("rateDownload (B/s)", typeof(int), APIMethods.TorrentGet),
                new DataScheme("rateUpload (B/s)", typeof(int), APIMethods.TorrentGet),
                new DataScheme("recheckProgress", typeof(double), APIMethods.TorrentGet),
                new DataScheme("rename-partial-files", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("rpc-version", typeof(int), APIMethods.SessionGet),
                new DataScheme("rpc-version-minimum", typeof(int), APIMethods.SessionGet),
                new DataScheme("script-torrent-done-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("script-torrent-done-filename", typeof(string), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("secondsDownloading", typeof(int), APIMethods.TorrentGet),
                new DataScheme("secondsSeeding", typeof(int), APIMethods.TorrentGet),
                new DataScheme("seedIdleLimit", typeof(int), APIMethods.TorrentGet, APIMethods.TorrentSet),
                new DataScheme("seedIdleMode", typeof(int), APIMethods.TorrentGet, APIMethods.TorrentSet),
                new DataScheme("seed-queue-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("seed-queue-size", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("seedRatioLimit", typeof(double), APIMethods.SessionGet, APIMethods.SessionSet, APIMethods.TorrentSet, APIMethods.TorrentGet),
                new DataScheme("seedRatioLimited", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("seedRatioMode", typeof(int), APIMethods.TorrentGet, APIMethods.TorrentSet),
                new DataScheme("size-bytes", typeof(int), APIMethods.FreeSpace),
                new DataScheme("sizeWhenDone", typeof(int), APIMethods.TorrentGet),
                new DataScheme("speed-limit-down", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("speed-limit-down-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("speed-limit-up", typeof(int), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("speed-limit-up-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("start-added-torrents", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("startDate", typeof(int), APIMethods.TorrentGet),
                new DataScheme("status", typeof(int), APIMethods.TorrentGet),
                new DataScheme("torrentCount", typeof(int), APIMethods.SessionStats),
                new DataScheme("torrentFile", typeof(string), APIMethods.TorrentGet),
                new DataScheme("totalSize", typeof(int), APIMethods.TorrentGet),
                new DataScheme("trackerAdd", typeof(List<string>), APIMethods.TorrentSet),
                new DataScheme("trackerRemove", typeof(IDTorrent), APIMethods.TorrentSet),
                new DataScheme("trackerReplace", typeof(List<KeyValuePair<IDTorrent, string>>), APIMethods.TorrentSet),
                new DataScheme("trash-original-torrent-files", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("units", typeof(object), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("uploadedEver", typeof(int), APIMethods.TorrentGet),
                new DataScheme("uploadLimit", typeof(int), APIMethods.TorrentGet, APIMethods.TorrentSet),
                new DataScheme("uploadLimited", typeof(bool), APIMethods.TorrentGet, APIMethods.TorrentSet),
                new DataScheme("uploadRatio", typeof(double), APIMethods.TorrentGet),
                new DataScheme("uploadSpeed", typeof(int), APIMethods.SessionStats),
                new DataScheme("utp-enabled", typeof(bool), APIMethods.SessionGet, APIMethods.SessionSet),
                new DataScheme("version", typeof(string), APIMethods.SessionGet),
                new DataScheme("wanted", typeof(List<bool>), APIMethods.TorrentGet),
                new DataScheme("webseedsSendingToUs", typeof(int), APIMethods.TorrentGet)
            };
            AddComplexObjects();
        }

        private void AddComplexObjects()
        {
            DataScheme files = new DataScheme("files", typeof(List<IDataScheme>), APIMethods.TorrentGet);
            files.PutChild(new DataScheme("bytesCompleted", typeof(int), null));
            files.PutChild(new DataScheme("length", typeof(int), null));
            files.PutChild(new DataScheme("name", typeof(string), null));

            list.Add(files);

            DataScheme fileStats = new DataScheme("fileStats", typeof(List<IDataScheme>), APIMethods.TorrentGet);
            fileStats.PutChild(new DataScheme("bytesCompleted", typeof(int), null));
            fileStats.PutChild(new DataScheme("wanted", typeof(bool), null));
            fileStats.PutChild(new DataScheme("priority", typeof(int), null));

            list.Add(fileStats);

            DataScheme labels = new DataScheme("labels", typeof(IDataScheme), APIMethods.TorrentGet, APIMethods.TorrentSet);
            labels.PutChild(new DataScheme("label", typeof(string[]), null));

            list.Add(labels);

            DataScheme peers = new DataScheme("peers", typeof(List<IDataScheme>), APIMethods.TorrentGet);
            peers.PutChild(new DataScheme("address", typeof(string), null));
            peers.PutChild(new DataScheme("clientName", typeof(string), null));
            peers.PutChild(new DataScheme("clientIsChoked", typeof(bool), null));
            peers.PutChild(new DataScheme("clientIsInterested", typeof(bool), null));
            peers.PutChild(new DataScheme("flagStr", typeof(string), null));
            peers.PutChild(new DataScheme("isDownloadingFrom", typeof(bool), null));
            peers.PutChild(new DataScheme("isEncrypted", typeof(bool), null));
            peers.PutChild(new DataScheme("isIncoming", typeof(bool), null));
            peers.PutChild(new DataScheme("isUploadingTo", typeof(bool), null));
            peers.PutChild(new DataScheme("isUTP", typeof(bool), null));
            peers.PutChild(new DataScheme("peerIsChoked", typeof(bool), null));
            peers.PutChild(new DataScheme("peerIsInterested", typeof(bool), null));
            peers.PutChild(new DataScheme("port", typeof(int), null));
            peers.PutChild(new DataScheme("progress", typeof(double), null));
            peers.PutChild(new DataScheme("rateToClient (B/s)", typeof(int), null));
            peers.PutChild(new DataScheme("rateToPeer (B/s)", typeof(int), null));

            list.Add(peers);

            DataScheme peersFrom = new DataScheme("peersFrom", typeof(IDataScheme), APIMethods.TorrentGet);
            peersFrom.PutChild(new DataScheme("fromCache", typeof(int), null));
            peersFrom.PutChild(new DataScheme("fromDht", typeof(int), null));
            peersFrom.PutChild(new DataScheme("fromIncoming", typeof(int), null));
            peersFrom.PutChild(new DataScheme("fromLpd", typeof(int), null));
            peersFrom.PutChild(new DataScheme("fromLtep", typeof(int), null));
            peersFrom.PutChild(new DataScheme("fromPex", typeof(int), null));
            peersFrom.PutChild(new DataScheme("fromTracker", typeof(int), null));

            list.Add(peersFrom);

            DataScheme trackers = new DataScheme("trackers", typeof(List<IDataScheme>), APIMethods.TorrentGet);
            trackers.PutChild(new DataScheme("announce", typeof(string), null));
            trackers.PutChild(new DataScheme("id", typeof(int), null));
            trackers.PutChild(new DataScheme("scrape", typeof(string), null));
            trackers.PutChild(new DataScheme("tier", typeof(int), null));

            list.Add(trackers);

            DataScheme trackerStats = new DataScheme("trackerStats", typeof(List<IDataScheme>), APIMethods.TorrentGet);
            trackerStats.PutChild(new DataScheme("announce", typeof(string), null));
            trackerStats.PutChild(new DataScheme("announceState", typeof(int), null));
            trackerStats.PutChild(new DataScheme("downloadCount", typeof(int), null));
            trackerStats.PutChild(new DataScheme("hasAnnounced", typeof(bool), null));
            trackerStats.PutChild(new DataScheme("hasScraped", typeof(bool), null));
            trackerStats.PutChild(new DataScheme("host", typeof(string), null));
            trackerStats.PutChild(new DataScheme("id", typeof(int), null));
            trackerStats.PutChild(new DataScheme("isBackup", typeof(bool), null));
            trackerStats.PutChild(new DataScheme("lastAnnouncePeerCount", typeof(int), null));
            trackerStats.PutChild(new DataScheme("lastAnnounceResult", typeof(string), null));
            trackerStats.PutChild(new DataScheme("lastAnnounceStartTime", typeof(int), null));
            trackerStats.PutChild(new DataScheme("lastAnnounceSucceeded", typeof(bool), null));
            trackerStats.PutChild(new DataScheme("lastAnnounceTime", typeof(int), null));
            trackerStats.PutChild(new DataScheme("lastAnnounceTimedOut", typeof(bool), null));
            trackerStats.PutChild(new DataScheme("lastScrapeResult", typeof(string), null));
            trackerStats.PutChild(new DataScheme("lastScrapeStartTime", typeof(int), null));
            trackerStats.PutChild(new DataScheme("lastScrapeSucceeded", typeof(bool), null));
            trackerStats.PutChild(new DataScheme("lastScrapeTime", typeof(int), null));
            trackerStats.PutChild(new DataScheme("lastScrapeTimedOut", typeof(bool), null));
            trackerStats.PutChild(new DataScheme("leecherCount", typeof(int), null));
            trackerStats.PutChild(new DataScheme("nextAnnounceTime", typeof(int), null));
            trackerStats.PutChild(new DataScheme("nextScrapeTime", typeof(int), null));
            trackerStats.PutChild(new DataScheme("scrape", typeof(string), null));
            trackerStats.PutChild(new DataScheme("scrapeState", typeof(int), null));
            trackerStats.PutChild(new DataScheme("seederCount", typeof(int), null));
            trackerStats.PutChild(new DataScheme("tier", typeof(int), null));

            list.Add(trackerStats);

            DataScheme webseeds = new DataScheme("webseeds", typeof(IDataScheme), APIMethods.TorrentGet);
            webseeds.PutChild(new DataScheme("webseed", typeof(string[]), null));

            list.Add(webseeds);

            DataScheme units = new DataScheme("units", typeof(IDataScheme), APIMethods.SessionGet, APIMethods.SessionSet);
            units.PutChild(new DataScheme("speed-units", typeof(string[]), null));
            units.PutChild(new DataScheme("speed-bytes", typeof(int), null));
            units.PutChild(new DataScheme("size-units", typeof(string[]), null));
            units.PutChild(new DataScheme("size-bytes", typeof(int), null));
            units.PutChild(new DataScheme("memory-units", typeof(string[]), null));
            units.PutChild(new DataScheme("memory-bytes", typeof(int), null));

            list.Add(units);

            DataScheme cumulativeStats = new DataScheme("cumulative-stats", typeof(IDataScheme), APIMethods.SessionStats);
            AddStatsObjects(cumulativeStats);

            list.Add(cumulativeStats);

            DataScheme currentStats = new DataScheme("current-stats", typeof(IDataScheme), APIMethods.SessionStats);
            AddStatsObjects(currentStats);

            list.Add(currentStats);

        }

        private void AddStatsObjects(DataScheme statsObject)
        {
            statsObject.PutChild(new DataScheme("uploadedBytes", typeof(int), null));
            statsObject.PutChild(new DataScheme("downloadedBytes", typeof(int), null));
            statsObject.PutChild(new DataScheme("filesAdded", typeof(int), null));
            statsObject.PutChild(new DataScheme("sessionCount", typeof(int), null));
            statsObject.PutChild(new DataScheme("secondsActive", typeof(int), null));
        }

        public override IList<IDataScheme> GetList()
        {
            return list;
        }
    }
}