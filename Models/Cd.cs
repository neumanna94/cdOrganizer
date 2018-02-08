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
            return null;
        }
        public string getGenre()
        {
            return null;
        }
        public string getArtist()
        {
            return null;
        }
        //SETTERS
        public void setTitle()
        {

        }
        public void setGenre()
        {

        }
        public void setArtist()
        {

        }
        public void PushToList(CD pushThisCD)
        {
            _allCDs.Add(pushThisCD);
        }
    }
}
