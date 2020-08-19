using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public enum ArgumentType
    {
        TorrentStart, TorrentStartNow, TorrentStop, TorrentVerify, TorrentReannounce,
        TorrentSet,
        TorrentGet,
        TorrentAdd,
        TorrentRemove,
        TorrentSetLocation,
        TorrentRenamePath,
        SessionSet,
        SessionGet,
        SessionStats,
        QueueMoveTop,
        QueueMoveUp,
        QueueMoveDown,
        QueueMoveBottom,
        FreeSpace,

    }
}