using System.Collections.Generic;
using System;
namespace CDOrganizer.Models
{
    public class CD
    {
        private string _title;
        private string _genre;
        private string _artist;
        private int _id;
        private static List<CD> _allCds = new List<CD>{};

        public CD(string titleIn, string genreIn, string artistIn)
        {
            _title = titleIn;
            _genre = genreIn;
            _artist = artistIn;
            _id = _allCds.Count;
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
        public int GetId(){
            return _id;
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
        public void PushToList()
        {
            if(!checkCD(this)){
                _allCds.Add(this);
            }
        }

        public static bool checkCD(CD inputCD){
            //If List is Empty Return inputCD is not in list.
            if(_allCds.Count == 0)
            {
                return false;
            }
            else
            {
                //Going through each element in the allCds list
                foreach(CD index in _allCds){
                    //If artistName, genre, and title are same; return that CD exists.
                    if(index.getArtist() == inputCD.getArtist() && index.getGenre() == inputCD.getGenre() && index.getTitle() == inputCD.getTitle())
                    {
                        return true;
                    }
                    else
                    {
                    }
                }
            }
            //If got through entire list and no return happened. CD must not be in list.
            return false;
        }
        public static List<CD> GetAll()
        {
            return _allCds;
        }
        public static void ClearAll(){
            _allCds.Clear();
        }
        public static CD Find(int searchId){
            return _allCds[searchId-1];
        }
    }
}
