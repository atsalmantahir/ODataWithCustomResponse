using System.Collections.Generic;

namespace ODataWithCustomResponse.OData
{
    public class ODataWrapper<T>
    {
        public int? ResultCount { get; set; }
        public int? Top { get; set; }
        public int? Skip { get; set; }
        public string OrderBy { get; set; }
        public IEnumerable<T> Results { get; set; }
    }
}
