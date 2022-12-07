namespace NASA.Core.Contracts
{
    public interface ITeacher
    {
        Task<bool> ExistsById(string teacherId);

        Task<bool> TeacherWithPhoneNumberExists(string phoneNumber);

        Task<bool> TeacherHasRents(string teacherId);

        Task Create(string teacherId, string phoneNumber);

        Task<int> GetTeacherId(string teacherId);
    }
}
