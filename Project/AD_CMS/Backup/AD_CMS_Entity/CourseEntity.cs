using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD_CMS_Entity
{
    public class CourseEntity
    {
        public string course_nm { get; set; }
        public string course_alias { get; set; }
        public int total_sem { get; set; }
        public string subject_nm { get; set; }
        public int subject_code { get; set; }
        public int subject_sem { get; set; }
        public int fee_per_year { get; set; }
        public int total_fee { get; set; }
    }
}
