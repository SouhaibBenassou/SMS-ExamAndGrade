using Application.Interfaces;
using Application.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class TestService : ITestService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TestService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> AddTestAsync(Test test)
        {
            await _unitOfWork.TestRepository.CreateAsync(test);
            await _unitOfWork.CompleteAsync();
            return "Exam successfully added.";
        }

        public async Task<string> DeleteTestAsync(Guid id)
        {
            var exam = await _unitOfWork.ExamRepository.GetAsNoTracking(r => r.Id == id);
            if (exam == null)
            {
                return $"Exam with Id : {id} not found.";
            }

            await _unitOfWork.ExamRepository.RemoveAsync(exam);
            await _unitOfWork.CompleteAsync();

            return "Exam successfully deleted.";
        }
    }
}

