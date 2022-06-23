

using SchoolManagementSystem.Domain.Services;
using SchoolManagementSystem.Domain.Entities;
using SchoolManagementSystem.Domain.Records;
using SchoolManagementSystem.Domain.Relations;
using SchoolManagementSystem.Domain.Interfaces;
// using SchoolManagementSystem.Domain.Services;
// using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Services;
public interface IDoWorkersPaymentService : IRecordService<Worker>
{

    public IRepository<TeacherCourseGroupRelation> GetTeacherCourseGroupRelationRepo(string id);
    public IRepository<TeacherCourseRelation> GetTeacherCourseRelationRepo(string id);
    // public IRepository<StudentCourseGroupRelation> GetStudentCourseGroupRelationRepo(string id);
    // public IQueryable<TeacherCourseGroupRelation> GetWorkerCoursePorcentualSalaries(string id);
    public IQueryable<WorkerPayRecordByPosition> GetWorkerFixSalaries(string id);
    // public List<DateTime> GetAllPaymentDates(string id);

}