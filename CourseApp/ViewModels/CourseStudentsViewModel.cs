using CourseApp.Models;

namespace CourseApp.ViewModels
{
    public class CourseStudentsViewModel
    {
        public course crs { get; set; }
        public List<student> std { get; set; }
    }
}