//using WebApplicationModels.Models;

//namespace WebApplicationModels.Repository
//{
//    public class StudentRepository : IStudentRepository
//    {
//        public List<StudentModel> getAllStudent()
//        {
//            return dataSource();
//        }

//        public StudentModel GetStudentById(int id)
//        {
//            return dataSource().Where(x => x.rollNo == id).FirstOrDefault();
//        }
//        private List<StudentModel> dataSource()
//        {
//            return  new List<StudentModel>
//            {
//                new StudentModel { rollNo = 1, name = "Durgesh Tiwari", gender = "Male", standard = 10 },
//                new StudentModel { rollNo = 2, name = "Aditya Tiwari", gender = "Male", standard = 8 },
//                new StudentModel { rollNo = 3, name = "Shubham Tiwari", gender = "Male", standard = 12 },
//                new StudentModel { rollNo = 4, name = "Roli Tiwari", gender = "Female", standard = 10 },
//                new StudentModel { rollNo = 5, name = "Kishori Tiwari", gender = "Female", standard = 11 },
//                new StudentModel { rollNo = 6, name = "Satyam Tiwari", gender = "Male", standard = 9 },
//            };
//        }
        
//    }
//}
