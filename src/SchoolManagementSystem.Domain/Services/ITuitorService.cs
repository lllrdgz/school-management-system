using SchoolManagementSystem.Domain.Entities;


namespace SchoolManagementSystem.Domain.Services;

public interface ITuitorService : IService<Tuitor>
{
    // Selecciona a un tutor con cierto id
    // y toma toda su información
    Tuitor GetTuitorById(string id);
}