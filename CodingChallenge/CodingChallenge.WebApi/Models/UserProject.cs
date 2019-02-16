using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingChallenge.WebApi.Models
{
    public class UserProject
    {
        [Key, Column(Order = 0)]
        [ForeignKey("User")]
        public int UserId { set; get; }

        [Key, Column(Order = 1)]
        [ForeignKey("Project")]
        public int ProjectId { set; get; }

        public virtual User User { set; get; }
        public Project Project { set; get; }

        public bool IsActive { set; get; }

        public DateTime AssignedDate { set; get; }
    }
}
