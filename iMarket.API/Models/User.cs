using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using iMarket.API.Contracts;

namespace iMarket.API.Models
{
    public class User : IMongoCommon
    {
        public Guid UId { get; set; }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool TermsAccepted { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
