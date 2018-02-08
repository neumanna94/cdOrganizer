using System.Collections.Generic;
namespace CDOrganizer.Models
{
    public class CD
    {
        private string _title;
        private string _genre;
        private string _artist;
        private static List<CD> _allCDs = new List<CD>{};

        public CD(string titleIn, string genreIn, string artistIn)
        {
            _title = titleIn;
            _genre = genreIn;
            _artist = artistIn;
        }
        //GETTERS
        public string getTitle()
        {
            return _title;
        }
        public string getGenre()
        {
            return _genre;
        }
        public string getArtist()
        {
            return _artist;
        }
        //SETTERS
        public void setTitle(string titleIn)
        {
            _title = titleIn;
        }
        public void setGenre(string genreIn)
        {
            _genre = genreIn;
        }
        public void setArtist(string artistIn)
        {
            _artist = artistIn;
        }
        public void PushToList(CD pushThisCD)
        {
            _allCDs.Add(pushThisCD);
        }
    }
}
