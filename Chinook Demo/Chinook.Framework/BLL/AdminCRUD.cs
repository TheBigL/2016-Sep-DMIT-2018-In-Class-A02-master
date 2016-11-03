using Chinook.Framework.DAL;
using Chinook.Framework.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Framework.BLL
{
    [DataObject]
    public class AdminCRUD
    {
        #region CRUD Methods for Tracks
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Track> ListAllTracks()
        {
            using (var context = new ChinookContext())
            {
                throw new NotImplementedException();//Finish this stuff, man!
            }

        }

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void AddTrack(Track info)
        {
            throw new NotImplementedException();//Finish the add method too, dawg!
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateTrack(Track info)
        {
            throw new NotImplementedException();//Finish the update method too, dawg!
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteTrack(Track info)
        {
            throw new NotImplementedException();//Finish the delete method too, dawg!
        }
        #endregion

    }
}
