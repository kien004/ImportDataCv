using ImportDataCv.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ImportDataCv.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartWordController : ControllerBase
    {
        private readonly SmartWorkVatcoContext _smartWorkVatcoContext;
        public SmartWordController(SmartWorkVatcoContext smartWorkVatcoContext)
        {
            _smartWorkVatcoContext = smartWorkVatcoContext;
        }
        [HttpPost("save")]
        public async Task<IActionResult> ImportExcelCvSmart([FromBody] List<Contact> dataExcel)
        {
            if (dataExcel == null || !dataExcel.Any())
            {
                return BadRequest("Không có dữ liệu để lưu.");
            }

            foreach (var itemData in dataExcel)
            {
                // Tạo danh sách các tham số từ đối tượng
                var parameters = new List<SqlParameter>();

                foreach (var field in itemData.GetType().GetProperties())
                {
                    switch (field.Name)
                    {
                        case "ContactName":
                            parameters.Add(new SqlParameter("@ContactName", field.GetValue(itemData) ?? (object)DBNull.Value));
                            break;
                        case "MobilePhone":
                            parameters.Add(new SqlParameter("@MobilePhone", field.GetValue(itemData) ?? (object)DBNull.Value));
                            break;
                        case "Email":
                            parameters.Add(new SqlParameter("@Email", field.GetValue(itemData) ?? (object)DBNull.Value));
                            break;
                        case "Hashtag":
                            parameters.Add(new SqlParameter("@Hashtag", field.GetValue(itemData) ?? (object)DBNull.Value));
                            break;
                        default:
                            break;
                    }
                }

                // Tạo câu lệnh INSERT INTO với các tham số đã được chuẩn bị
                var insertQuery = @"
            INSERT INTO [SmartWork_Vatco].[dbo].[CONTACT] (CONTACT_NAME, MOBILE_PHONE, EMAIL, HASHTAG) 
            VALUES (@ContactName, @MobilePhone, @Email, @Hashtag)";

                // Thực hiện câu lệnh SQL với ExecuteSqlRaw
                await _smartWorkVatcoContext.Database.ExecuteSqlRawAsync(insertQuery, parameters.ToArray());
            }
            return Ok(new { message = "Dữ liệu đã được lưu thành công" });
        }
    }
}
