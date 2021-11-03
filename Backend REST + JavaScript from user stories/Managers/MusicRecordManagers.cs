using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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


        public List<MusicRecords> GetAll(string title = null, string artist = null, string sortBy = null)
        // Optional parameters
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments
        {
            List<MusicRecords> musicrecording = new List<MusicRecords>(Data);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy

            if (title != null)
            {
                musicrecording = musicrecording.FindAll(mrecord => mrecord.Title != null && mrecord.Title.StartsWith(title));
            }

            if (artist != null)
            {
                musicrecording = musicrecording.FindAll(mrecord1 => mrecord1.Artist != null && mrecord1.Artist.StartsWith(artist));

            }
            if (sortBy != null)
            {
                switch (sortBy.ToLower())
                {
                    case "title":
                        musicrecording = musicrecording.OrderBy(mrecord => mrecord.Title).ToList();
                        break;
                    case "artist":
                        musicrecording = musicrecording.OrderBy(mrecord => mrecord.Artist).ToList();
                        break;
                        // skip any other properties in the query string
                }
            }
            return musicrecording;
effsfdfd

        }

        public MusicRecords GetByTitle(string title)
        {
            return Data.Find(Mrecord => Mrecord.Title == title);
        }

        public MusicRecords Add(MusicRecords newRecord)
        {
            Data.Add(newRecord);
            return newRecord;
        }

        public MusicRecords Delete(string title)
        {
            MusicRecords newRecords = Data.Find(record1 => record1.Title == title);
            if (newRecords == null) return null;
            Data.Remove(newRecords);
            return newRecords;

        }

        public MusicRecords Update(string , MusicRecords updates)
        {
            MusicRecords mrecords = Data.Find(mrecording => mrecording.Title == title);
            if (mrecords == null) return null;
            mrecords.Title = updates.Title;
            mrecords.Artist = updates.Artist;
            mrecords.Duration = updates.Duration;
            mrecords.PublicationYear = updates.PublicationYear;
            return mrecords;
        }

    }
}



