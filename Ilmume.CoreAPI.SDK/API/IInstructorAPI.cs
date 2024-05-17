using Ilmume.Primary.Entities;

namespace Ilmume.CoreAPI.SDK.API
{
    public interface IInstructorAPI
    {
        List<Instructor> GetAllActiveInstructors();

        Instructor GetInstructorById(Guid id);
    }

}
