namespace CourseApp.Models
{
    public static class Repository
    {
        private static List<student>_std=new List<student>();
        
        public static List<student> studs{
            get{
                return _std;     //for seeing students
            }
        }

        public static void AddStudent(student st){
            _std.Add(st);   // for adding students info from apply form 
        }
    }
}