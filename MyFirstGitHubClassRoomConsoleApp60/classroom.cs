using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class ClassRoom
    {
        public ClassRoom(string className, List<student> studentList, DateTime semesterStart)
        {
            ClassName = className;
            StudentList = studentList;
            SemesterStart = semesterStart;
        }

        public ClassRoom()
        {

        }

        public string ClassName { get; set; }

        public List<student> StudentList { get; set; }

        public DateTime SemesterStart { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(ClassName)}={ClassName}, {nameof(StudentList)}={StudentList}, {nameof(SemesterStart)}={SemesterStart.ToString()}}}";
        }
    }
}
