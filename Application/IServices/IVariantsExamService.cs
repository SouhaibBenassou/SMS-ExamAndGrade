using Domain.Dtos;
using Domain.Entities;

namespace Application.IServices
{
    public interface IVariantsExamService
    {
        Task<string> AddVariantsExamAsync(VariantsExamDto variantsExams);
        Task<string> UpdateVariantsExamAsync(VariantsExamDto variantsExams);
        Task<List<VariantsExams>> GetAllVariantsExamsAsync();
        Task<VariantsExams> GetVariantsExamAsync(Guid id);
        Task<string> DeleteVariantsExamAsync(Guid id);
    }
}
