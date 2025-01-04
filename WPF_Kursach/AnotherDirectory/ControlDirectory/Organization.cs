using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WPF_Kursach.AnotherDirectory.ControlDirectory
{
    public class Organization
    {
        [JsonPropertyName("NameOrg")]
        public string NameOrg { get; set; }
        [JsonPropertyName("AddressOrg")]
        public string AddressOrg { get; set; }
        [JsonPropertyName("DescriptionOrg")]
        public string? DescriptionOrg { get; set; }
        [JsonPropertyName("TypeOrg")]
        public string? TypeOrg { get; set; }
        public Organization(string _NameOrg, string _AddressOrg, string _DesctriptionOrg)
        {
            NameOrg = _NameOrg;
            AddressOrg = _AddressOrg;
            DescriptionOrg = _DesctriptionOrg;
        }
        public Organization(string _NameOrg, string _AddressOrg, string _DesctriptionOrg, string _TypeOrg)
        {
            NameOrg = _NameOrg;
            AddressOrg = _AddressOrg;
            DescriptionOrg = _DesctriptionOrg;
            TypeOrg = _TypeOrg;
        }
    }
}
