using Microsoft.AspNetCore.Mvc;
using PostgresDataLoggerService.Data.Interfaces;

namespace PostgresDataLoggerService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InterpreterController: ControllerBase
    {
        private readonly IDataWriter _writer;
        private readonly IDataReader _reader;

        public InterpreterController(IDataWriter writer, IDataReader reader)
        {
            _writer = writer;
            _reader = reader;
        }

        [HttpGet]
        public async Task<IActionResult> GetRollData(long blockId)
        {
            //Convert 
            var rollData = await _reader.GetRollAsync(blockId);
            return Ok(rollData);
        }

        [HttpPost]
        public async Task<IActionResult> SetRollData(long time, float roll, long nBlockId = -1, short seq = 0)
        {
            var sucess = await _writer.DBSaveRollAsync(time, roll, nBlockId, seq);
            return Ok(sucess);
        }
    }
}
