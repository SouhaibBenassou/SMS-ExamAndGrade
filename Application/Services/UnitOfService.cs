using Application.Interfaces;
using Application.IServices;
using AutoMapper;

namespace Application.Services
{
    public class UnitOfService : IUnitOfService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ISupervisorService SupervisorService { get; set; }
        public IExamService ExamService { get; set; }

        public UnitOfService(IMapper mapper, IUnitOfWork unitOfWork, ISupervisorService supervisorService, IExamService examService) {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            SupervisorService = supervisorService;
            ExamService = examService;
        }
    }
}
