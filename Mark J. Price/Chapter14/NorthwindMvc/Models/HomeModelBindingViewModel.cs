using System.Collections.Generic;

namespace NorthwindMvc.Models
{
    public class HomeModelBindingViewModel
    {
        public Thing Thing { get; internal set; }
        public bool HasErrors { get; internal set; }

        public IEnumerable<string> ValidationErrors{get; internal set;}
    }
}