using NICodeExercise.Models;

namespace NICodeExercise.ViewModels
{
    public class SearchVM
    {
        public searchresults SearchResults{get; set;}
        public bool SearchPerformed {get; set;}
        public SearchVM(){
            SearchResults = null;
            SearchPerformed = false;
        }
    }
}