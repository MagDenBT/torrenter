using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Documents;

namespace Torrneter
{
    public interface IQueryFactory
    {

        #region Torrent Action
     
   
      
        /// <summary>
        /// Может остановить, запустить, проверить или реаноснировать последний активный торрент
        /// </summary>
        /// <param name="action">Что нужно сделать</param>
        
        void TorrentActionRecentlyActive(TorrentActions action);

        /// <summary>
        /// Может остановить, запустить, проверить или реаноснировать торрент
        /// </summary>
        /// <param name="action">Что нужно сделать</param>
        /// <param name="ID">Массив ИД торрентов, пустой массив - значит ВСЕ торренты</param>
        void TorrentAction(TorrentActions action, params int[] ID);

        #endregion

        #region Torrent Mutators

        void TorrentSet(TorrentMutators mutators);
        #endregion

        #region Torrent Accessors
        TorrentInfo TorrentGet(params int[] IDs);
        TorrentInfo TorrentGetRecently();
        #endregion

        #region Adding a Torrent
        TorrentAdded TorrentAdd(NewTorrent NewTorrent);
        #endregion

        #region Removing a Torrent
        void TorrentRemove(IDTorrent ID, bool DeletelocalData);
        void TorrentRemoveRecently(bool DeletelocalData)
        #endregion

        #region Moving a Torrent
          void TorrentSetLocation()
        #endregion
    }
}