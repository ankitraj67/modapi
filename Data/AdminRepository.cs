using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MentorOnDemand.Dto;

namespace MentorOnDemand.Data
{
    public interface AdminRepository
    {
        bool AddCourse(CourseDto courseDto);
    }
}
