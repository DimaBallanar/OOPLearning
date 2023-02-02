using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tasks0202.Modules
{
    public class Money
    {
        [JsonInclude]
        public int Code { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        [JsonPropertyName("d")]
        [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime? LastUpdate { get; set; }
        [JsonIgnore]
        public string Text => $"{Code}+{Name}";

        public Money()
        {

        }

        public override string ToString()
        {
            return $"{Code}   {Name}  {Symbol}";
        }
    }
}
