using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using iMarket.API.Contracts;

namespace Talent.Common.Models
{
    public class User : IMongoCommon
    {
        public Guid UId { get; set; }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public bool IsMobilePhoneVerified { get; set; }

        public string UserType { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string TalentId { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string EmployerId { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string RecruiterId { get; set; }

        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public Login Login { get; set; }
    }
}
