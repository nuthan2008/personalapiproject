using System;
using Nest;
namespace BusinessProvider.Models
{
    public class SysData : ISysData
    {
        [Keyword(Name = "sysTenant")]
        public string sysTenant { get; set; }

        [Keyword(Name = "sysSubTenant")]
        public string sysSubTenant { get; set; }

        [Keyword(Name = "sysLocale")]
        public string sysLocale { get; set; }

        [TextWithKeyword]
        public string sysDomainType { get; set; }

        [Keyword(Name = "sysCreatedBy")]
        public string sysCreatedBy { get; set; }

        [Date(Name = "sysCreatedDate")]
        public DateTime sysCreatedDate { get; set; }

        [Keyword(Name = "sysModBy")]
        public string sysModBy { get; set; }

        [Date(Name = "sysModDate")]
        public DateTime sysModDate { get; set; }
    }
}