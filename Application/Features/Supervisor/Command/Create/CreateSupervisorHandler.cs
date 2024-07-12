using Application.Interfaces;
using Application.IRepository;
using System;
using Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Application.Features.Supervisor.command.Create
{
    public class CreateSupervisorHandler : IRequestHandler<CreateSupervisorCommand, Domain.Entities.Supervisor>
    {

        private readonly ISupervisorRepository _supervisorRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CreateSupervisorHandler(ISupervisorRepository supervisorRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _supervisorRepository = supervisorRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Domain.Entities.Supervisor> Handle(CreateSupervisorCommand request, CancellationToken cancellationToken)
        {
            var supervisor = _mapper.Map<Domain.Entities.Supervisor>(request.SupervisorDto);
            await _supervisorRepository.CreateAsync(supervisor);
            await _unitOfWork.CommitAsync();
            return supervisor;
        }


    }
}

