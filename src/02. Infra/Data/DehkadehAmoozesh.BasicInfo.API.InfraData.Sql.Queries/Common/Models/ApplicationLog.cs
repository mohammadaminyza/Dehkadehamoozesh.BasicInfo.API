using System;

namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Models
{
    public partial class ApplicationLog
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string MessageTemplate { get; set; }
        public string Level { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string Exception { get; set; }
        public string Properties { get; set; }
    }
}