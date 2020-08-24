using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public class TorrentStartCreator : IArgumentCreator
    {
        public Dictionary<string, ArgumentField<object>> CreateArguments()
        {
            Dictionary<string, ArgumentField<IDTorrent>> list = new Dictionary<string, ArgumentField<IDTorrent>>();
            ArgumentField<IDTorrent>
        }
    }
}