using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public class StandartArgumentFactory : ArgumentsFactory
    {
        public override Dictionary<string, IArgumentField<object>> CreateArgumnets(ArgumentType type)
        {
            switch (type)
            {
                case ArgumentType.TorrentStart:
                    //to do
                    break;
                case ArgumentType.TorrentStartNow:
                    //to do
                    break;
                case ArgumentType.TorrentStop:
                    //to do
                    break;
                case ArgumentType.TorrentVerify:
                    //to do
                    break;
                case ArgumentType.TorrentReannounce:
                    //to do
                    break;
                case ArgumentType.TorrentSet:
                    //to do
                    break;
                case ArgumentType.TorrentGet:
                    //to do
                    break;
                case ArgumentType.TorrentAdd:
                    //to do
                    break;
                case ArgumentType.TorrentRemove:
                    //to do
                    break;
                case ArgumentType.SessionSet:
                    //to do
                    break;
                case ArgumentType.SessionGet:
                    //to do
                    break;
                case ArgumentType.SessionStats:
                    //to do
                    break;
                case ArgumentType.QueueMoveTop:
                    //to do
                    break;
                case ArgumentType.QueueMoveUp:
                    //to do
                    break;
                case ArgumentType.QueueMoveDown:
                    //to do
                    break;
                case ArgumentType.QueueMoveBottom:
                    //to do
                    break;
                case ArgumentType.FreeSpace:
                    //to do
                    break;
            }
            throw new NotImplementedException();
        }
    }
}