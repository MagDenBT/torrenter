namespace Torrneter
{
    public class SessionStats
    {
        private int ActiveTorrentCount { get; set; }
        private int DownloadSpeed { get; set; }
        private int PausedTorrentCount { get; set; }
        private int TorrentCount { get; set; }
        private int UploadSpeed { get; set; }

        #region Cumulative stats

        private int UploadedBytesCumulative { get; set; }
        private int DownloadedBytesCumulative { get; set; }
        private int FilesAddedCumulative { get; set; }
        private int SessionCountCumulative { get; set; }
        private int SecondsActiveCumulative { get; set; }

        #endregion

        #region Current stats



        private int UploadedBytesCurrent { get; set; }
        private int DownloadedBytesCurrent { get; set; }
        private int FilesAddedCurrent { get; set; }
        private int SessionCountCurrent { get; set; }
        #endregion

    }
}