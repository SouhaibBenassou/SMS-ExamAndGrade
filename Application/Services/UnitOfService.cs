﻿using Application.Interfaces;
using Application.IServices;

namespace Application.Services
{
    public class UnitOfService : IUnitOfService
    {
        public ITestService TestService { get; set; }
        public ISupervisorService SupervisorService { get; set; }
        public IRoomService RoomService { get; set; }
        public IExamService ExamService { get; set; }
        public IVariantsExamService VariantsExamService { get; set; }
        public IExamResultsService ExamResultsService { get; set; }
        public ITestResultService TestResultService { get; set; }
        public IStagiereNoteService StagiereNoteService { get; set; }
        public IIndividualWorkUOFService IndividualWorkUOFService { get; set; }

        public UnitOfService(ITestService testService, ISupervisorService supervisorService, IRoomService roomService, IExamService examService, IVariantsExamService variantsExamService, IExamResultsService examResultsService, ITestResultService testResultService, IStagiereNoteService stagiereNoteService, IIndividualWorkUOFService individualWorkUOFService) {
            TestService = testService;
            SupervisorService = supervisorService;
            RoomService = roomService;
            ExamService = examService;
            VariantsExamService = variantsExamService;
            ExamResultsService = examResultsService;
            TestResultService = testResultService;
            StagiereNoteService = stagiereNoteService;
            IndividualWorkUOFService = individualWorkUOFService;
        }
    }
}
