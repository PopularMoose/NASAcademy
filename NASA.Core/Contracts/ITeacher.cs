namespace NASA.Core.Contracts
{
    public interface ITeacher
    {
        Task<bool> ExistsById(string teacherId);

        Task<bool> TeacherWithPhoneNumberExists(string phoneNumber);

        Task<bool> TeacherWithEmailExists(string emailaddress);

        Task<bool> TeacherWithNameExists(string name);

        Task<bool> TeacherHasCourses(string teacherId);

        Task Create(string teacherId, string phoneNumber, string emailaddress, string name);

        Task<int> GetTeacherId(string teacherId);
    }
}
