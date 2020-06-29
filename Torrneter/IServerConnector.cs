using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public interface IServerConnector
    {
        System.Windows.Documents.List GetTorrentsList();
        void StartTorrent();
    }
}