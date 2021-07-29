using System;

namespace FirebaseNotificationSample.Domain.Models
{
    public class Entity
    {
        public Guid Id { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}