using Microsoft.AspNetCore.Mvc;

namespace Release_Candidate_Ervin_Hostetler.TagHelpers
{
    public enum SortOrder
    {
        ASC, DESC
    }


    public class QueryOptions
    {
        public string SortField { get; set; }
        public SortOrder SortOrder { get; set; }

        public QueryOptions()
        {
            SortField = "";
            SortOrder = SortOrder.ASC;
        }
        public string Sort => $"{SortField} {SortOrder.ToString()}";
    }
}