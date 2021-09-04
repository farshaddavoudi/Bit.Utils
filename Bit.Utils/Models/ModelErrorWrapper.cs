using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Bit.Utils.Models
{
    public class ModelErrorWrapper
    {
        public List<AppModelError> Errors { get; set; } = new();
    }

    public class AppModelError
    {
        public AppModelError()
        {
            Property = "*";
        }

        public string? Property { get; set; }

        public IEnumerable<string> Messages { get; set; } = Array.Empty<string>();

        [JsonIgnore]
        public IEnumerable<Exception> Exceptions { get; set; } = Array.Empty<Exception>();
    }
}