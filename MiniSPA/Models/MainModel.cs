using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MiniSPA.Models
{
    public class MainModel
    {
        public string customer { get; set; }
        public string instModel { get; set; }
    }
    public class MainModelBuilder
    {
        public MainModel MainModelData()
        {
            var data = new MainModel() { customer = GetSerializedCustomers(), instModel = GetSerializedInstructors() };
            return data;
        }

        private string GetSerializedCustomers()
        {
            var customers = new[] { new Customers(){Number=100,Name="Srini",City="Madurai"},
                                    new Customers(){Number=101,Name="Asvini",City="Chennai"},
                                    new Customers(){Number=102,Name="Akshai",City="Trichy"}
                                  };
            var settings = new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(customers, Formatting.None, settings);
        }

        private string GetSerializedInstructors()
        {
            var customers = new[] { new Instructors(){Age=30,Name="Srini",Degree="MS"},
                                    new Instructors(){Age=25,Name="Asvini",Degree="CS"},
                                    new Instructors(){Age=20,Name="Akshai",Degree="BS"}
                                  };
            var settings = new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(customers, Formatting.None, settings);
        }
    }
}