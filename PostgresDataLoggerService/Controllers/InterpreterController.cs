using Microsoft.AspNetCore.Mvc;
using PostgresDataLoggerService.Data.Interfaces;
using System.Text.Json;

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

        [HttpGet("roll")]
        public async Task<ActionResult<string>> GetFirstRollData(long blockId)
        {
            var rollData = await _reader.GetFirstRollAsync(blockId);
            if (rollData.TimeEditData.BlockID == 0 && rollData.TimeEditData.Time == 0 && rollData.Roll == 0f)
                return NotFound($"No roll data for block {blockId}");

            var json = JsonSerializer.Serialize(rollData, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                IncludeFields = true,
                WriteIndented = false
            });

            return Content(json, "application/json");
        }

        [HttpPost("roll")]
        public async Task<IActionResult> SetRollData(long time, float roll, long nBlockId = -1, short seq = 0)
        {
            var sucess = await _writer.DBSaveRollAsync(time, roll, nBlockId, seq);
            return Ok(sucess);
        }

        [HttpPost("block-min")]
        public async Task<IActionResult> SetBlockMinimum(string name, int folderId = -1)
        {
            var blockId = await _writer.DBSaveBlockMinimalAsync(name, folderId);
            return Ok(blockId);
        }

        [HttpPost("folder")]
        public async Task<IActionResult> CreateFolder(string name, int? parentId = null)
        {
            var id = await _writer.DBSaveFolderAsync(name, parentId);
            return Ok(id);
        }
    }
}
