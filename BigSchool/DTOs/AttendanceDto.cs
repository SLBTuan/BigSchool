using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.DTOs
{
    public class AttendanceDto
    {
        public int courseId { get; set; }
    }
    public class FollowingDto
    {
        public string FolloweeId { get; set; }
    }
}