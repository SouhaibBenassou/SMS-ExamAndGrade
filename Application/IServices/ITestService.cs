using Domain;
using Domain.Dtos.SupervisorDto;
using Domain.Dtos.TestDto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface ITestService
    {
        Task<string> AddTestAsync(Test test);
/*        Task<string> UpdateTestAsync(Test test);
*/        Task<string> DeleteTestAsync(Guid id);
/*        Task<List<Test>> GetListOfTestAsync();
        Task<TestDto> GetTestByIdAsync(Guid Id);*/
    }
}
