namespace Torrneter
{
    public class IDTorrent
    {
        private string[] IDs;
        private bool RecentlyActive;

        IDTorrent(params string[] ID)
        {
            IDs = ID;
        }

        public IDTorrent(bool RecentLy) { }
    }
}