//============================================================
// Student Number	: S10170878, S10173513
// Student Name	: Teo Wen Yu Carlsen, Yong Kai En
// Module  Group	: IT03
//============================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    class Movie
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private int duration;

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        private string classification;

        public string Classification
        {
            get { return classification; }
            set { classification = value; }
        }
        private DateTime openingDate;

        public DateTime OpeningDate
        {
            get { return openingDate; }
            set { openingDate = value; }
        }
        private List<string> genreList = new List<string>();
        public List<int> ratingList = new List<int>(); //created ratingList for Option 6
        public List<string> commentList = new List<string>(); //created commentList for Option 6
        public Movie() { }
        public Movie(string t, int d, string c, DateTime o, List<string> g)
        {
            Title = t;
            Duration = d;
            Classification = c;
            OpeningDate = o;
            genreList = g;
        }
        public List<string> GetGenreList()
        {
            return genreList;
        }
        public List<int> GetRatingList()
        {
            return ratingList;
        }
        public List<string> GetCommentList()
        {
            return commentList;
        }
        public override string ToString()
        {
            return ("Title: " + Title + "\t" + "Duration: " + Duration + "\t" + "Classification: " + Classification + "\t" + "Opening Date: " + OpeningDate);
        }
    }
}
