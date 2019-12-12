namespace iMarket.API.Contracts
{
    public interface IMongoCommon : IMongoEntity<string>
    {
        bool IsDeleted { get; set; }
    }
}
