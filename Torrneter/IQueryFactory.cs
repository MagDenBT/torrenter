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
        /// <param name="ID">Список ИД торрентов, пустой список - значит ВСЕ торренты</param>
        void TorrentAction(TorrentActions action, List<int> ID);

        #endregion

        #region Torrent Mutators

        void TorrentSet(TorrentMutators mutators);
        #endregion
    }
}