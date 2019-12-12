namespace iMarket.API.Contracts
{
    public interface IMongoEntity<TId>
    {
        TId Id { get; set; }
    }
}
