using System;

namespace FirebaseNotificationSample.Domain.Models
{
    public class User : Entity
    {
        public User(Guid id, string token, string topic) : base()
        {
            this.Token = token;
            this.Topic = topic;

        }
        public string Token { get; private set; }
        public string Topic { get; private set; }
    }
}