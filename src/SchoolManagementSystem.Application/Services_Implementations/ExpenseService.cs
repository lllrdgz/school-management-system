
using SchoolManagementSystem.Application.Repositories_Interfaces;
using SchoolManagementSystem.Domain.Entities;
using SchoolManagementSystem.Domain.Services;

namespace SchoolManagementSystem.Application.Services_Implementations;

public class ExpenseService : BaseService<Expense>, IExpenseService
{
    public ExpenseService(IExpenseRepository repository) : base(repository)
    {

    }
}