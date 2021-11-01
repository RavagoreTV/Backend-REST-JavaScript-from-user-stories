using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Backend_REST___JavaScript_from_user_stories.Model;

namespace Backend_REST___JavaScript_from_user_stories.Managers
{
    public class MusicRecordManagers
    {

        private static readonly List<MusicRecords> Data = new List<MusicRecords>
        {
            new MusicRecords() {Title= "99 luftballon", Artist = "Nina", Duration = 3, PublicationYear = 1989},
            new MusicRecords() {Title= "Best song in the world", Artist = "unknown", Duration = 4, PublicationYear = 1994},
            new MusicRecords() {Title= "i cant sing for shit", Artist = "lil nas x", Duration = 3, PublicationYear = 2017},
            new MusicRecords() {Title= "i need a dollar", Artist = "Aloe blacc", Duration = 6, PublicationYear = 2021},


        };

        public List<MusicRecords> GetAll()
        {
            return new List<MusicRecords>(Mrecords);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy
        }

        public MusicRecords GetByTitle(string title)
        {
            return Mrecords.Find(Mrecord => Mrecord.Title == title);
        }

        public MusicRecords Add(MusicRecords mewrecord)
        {
            
        }

        public MusicRecords Delete(MusicRecords mrecords)
        {

        }

    }
}



