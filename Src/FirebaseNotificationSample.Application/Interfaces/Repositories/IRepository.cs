using System.Collections.Generic;
using FirebaseNotificationSample.Domain.Models;

namespace FirebaseNotificationSample.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        List<T> GetAll();
    }
}