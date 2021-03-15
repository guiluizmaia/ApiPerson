using IntegraçãoBD.Hypermedia.Abstract;
using System.Collections.Generic;

namespace IntegraçãoBD.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
