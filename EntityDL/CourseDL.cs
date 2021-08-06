
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDTO;

namespace EntityDL
{
    public class CourseDL
    {
        Course dtCourseObj;
        public CourseDL()
        {
            dtCourseObj = new Course();
        }
        public List<Course> GetCourses()
        {
            try
            {
                List<Course> courseList = new List<Course>();
                ProjectEntities courseCntx = new ProjectEntities();
                var dbCourseList = courseCntx.Courses.ToList();
                foreach (var item in dbCourseList)
                {
                    courseList.Add(
                        new Course()
                        {
                            CourseID = item.CourseID,
                            CourseTitle = item.CourseTitle,
                            Duration = item.Duration,
                            Owner = item.Owner,
                            AssessmentMode = item.AssessmentMode
                        });
                }
                return courseList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

