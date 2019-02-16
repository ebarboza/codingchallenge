using System;

namespace CodingChallenge.WebApi.ViewModels
{
    public class ProjectViewModel
    {
        public int ProjectId { set; get; }
        public DateTime StartDate { set; get; }
        public string TimeToStart { set; get; }
        public DateTime EndDate { set; get; }
        public int Credits { set; get; }
        public string Status { set; get; }
    }
}