using System.Collections.Generic;
using RESTDemo.API.Models;

namespace RESTDemo.API
{
    public class PropertiesDataStore
    {
        public static PropertiesDataStore Current { get; } = new PropertiesDataStore();

        public List<PropertyDto> Properties { get; set; }
        public PropertiesDataStore()
        {
            Properties = new List<PropertyDto>()
            {
                new PropertyDto()
                {
                    Id = 1,
                    Name = "Example 1",
                    Description = "Description of Example 1"
                },
                new PropertyDto()
                {
                    Id = 2,
                    Name = "Example 2",
                    Description = "Description of Example 2"
                },
            };
        }
    }
}