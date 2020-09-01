using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Torrneter
{
    public class IDTorrent
    {
        private List<string> IDs;
        private bool RecentlyActive;

        IDTorrent(params string[] ID)
        {
            PutID(ID);
        }

        public IDTorrent(bool RecentLy) 
        {
            RecentlyActive = RecentLy;
            if (RecentLy)  IDs.Add( "RecentlyActive");
        }

       public void PutID(params string[] ID)
        {
            if (RecentlyActive)
            {
                RecentlyActive = false;
                IDs.Clear();
            }
            IDs.AddRange(ID);
        }

        public string[] GetID()
        {
            return IDs.ToArray();
        }

      
    }
}