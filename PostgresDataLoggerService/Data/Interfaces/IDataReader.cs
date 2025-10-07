using PostgresDataLoggerService.Data.Models;

namespace PostgresDataLoggerService.Data.Interfaces
{
    public interface IDataReader
    {
        Task<RollDataModel> GetFirstRollAsync(long nBlockId);
    }
}
