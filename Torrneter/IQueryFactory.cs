﻿using System;
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
        /// Stop, start, verify or reannouncing torrent
        /// </summary>
        /// <param name="action">What will doing</param>
        /// <param name="ID"></param>
        void TorrentAction(TorrentActions action, IDTorrent ID);

        #endregion

        #region Torrent Mutators

        void TorrentSet(TorrentMutators mutators);
        #endregion

        #region Torrent Accessors
        /// <summary>
        /// Getting torrent information
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>See returning class fields</returns>
        TorrentInfo TorrentGet(IDTorrent ID);
    
        #endregion

        #region Adding a Torrent
        TorrentAdded TorrentAdd(NewTorrent NewTorrent);
        #endregion

        #region Removing a Torrent
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="DeleteLocalData">delete local data. (default: false)</param>
        void RemoveTorrent(IDTorrent ID, bool DeleteLocalData);
        #endregion

        #region Moving a Torrent

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Location">the new torrent location</param>
        /// <param name="Move">if true, move from previous location otherwise, search "location" for files (default: false)</param>;
        void TorrentSetLocation(IDTorrent ID, string Location, bool Move);
        #endregion
        #region Renaming a Torrent's Path

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID">must only be 1 torrent</param>
        /// <param name="path">the path to the file or folder that will be renamed</param>
        /// <param name="Name">the file or folder's new name</param>
        /// <returns>"path", "name", and "id", holding the torrent ID integer</returns>
        TorrentInfo TorrentRenamePath(string ID, string path, string Name);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="recentlyTorrent"></param>
        /// <param name="Path">the path to the file or folder that will be renamed</param>
        /// <param name="Name">the file or folder's new name</param>
        /// <returns>"path", "name", and "id", holding the torrent ID integer</returns>
        TorrentInfo TorrentRenamePath(bool recentlyTorrent, string Path, string Name);
        #endregion


        #region Session Requests

        #region  Mutators
       
        void SessionSet(SessionSetArguments sessionSetArguments);
        #endregion

        #region Accessors
        void SessionGet(ref SessionGetArgument sessionGetArgument);
        #endregion

        #region Statistics
        SessionStats SessionGetStats();
        #endregion

    #region Blocklist

        
         int BlocklistUpdate();
	#endregion

        #endregion
    }
}