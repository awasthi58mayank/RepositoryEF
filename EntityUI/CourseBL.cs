﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDTO;
using EntityDL;

namespace EntityBL
{
    public class CourseBL
    {
        CourseDL dalCourseObj;
        public CourseBL()
        {
            dalCourseObj = new CourseDL();
        }
        public List<Course> GetCourses()
        {
            try
            {
                var courseData = dalCourseObj.GetCourses();
                return courseData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


