using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Release_Candidate_Ervin_Hostetler.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.TagHelpers
{
    //public class SortableLinkTagHelper:AnchorTagHelper
    //{
    //    public class QueryOptions : AnchorTagHelper
    //    {
    //        public QueryOptions QueryOptionsController { get; set; }
    //        public string SortField { get; set; }
    //        public static object SortOrder { get; private set; }

    //        public Release_Candidate_Ervin_HostetlerTagHelper(IHtmlGenerator generator) : base(generator)
    //        {
    //        }

    //        public override void Process(TagHelperContext context, TagHelperOutput output)
    //        {
    //            var isCurrentSortField = QueryOptionsController.SortField == SortField;
    //            var newSortOrder = (isCurrentSortField && QueryOptions.SortOrder == SortOrder.ASC) ?
    //                                SortOrder.DESC : SortOrder.ASC;
    //            var newContent = $"{output.PreContent.GetContent()} {BuildSortIcon(isCurrentSortField, QueryOptionsController)}";
    //            RouteValues.Add("SortField", SortField);
    //            RouteValues.Add("SortOrder", newSortOrder.ToString());
    //            base.Process(context, output);
    //            output.TagName = "a";

    //            output.PostContent.SetHtmlContent(newContent);
    //        }

    //        private string BuildSortIcon(bool isCurrentSortField, QueryOptions queryOptions)
    //        {
    //            string sortIcon = "sort";

    //            if (isCurrentSortField)
    //            {
    //                sortIcon += "-by-alphabet";
    //                if (queryOptions.SortOrder == SortOrder.DESC)
    //                    sortIcon += "-alt";
    //            }
    //            return $"<span class=\"glyphicon glyphicon-{sortIcon}\"></span>";
    //        }
    //    }
    public class SortableLinkTagHelper : AnchorTagHelper
    {
        public QueryOptions QueryOptions { get; set; }
        public string SortField { get; set; }

        public SortableLinkTagHelper(IHtmlGenerator generator) : base(generator)
        {
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var isCurrentSortField = QueryOptions.SortField == SortField;
            var newSortOrder = (isCurrentSortField && QueryOptions.SortOrder == SortOrder.ASC) ?
                                SortOrder.DESC : SortOrder.ASC;
            var newContent = $"{output.PreContent.GetContent()} {BuildSortIcon(isCurrentSortField, QueryOptions)}";
            RouteValues.Add("SortField", SortField);
            RouteValues.Add("SortOrder", newSortOrder.ToString());
            base.Process(context, output);
            output.TagName = "a";

            output.PostContent.SetHtmlContent(newContent);
        }

        private string BuildSortIcon(bool isCurrentSortField, QueryOptions queryOptions)
        {
            string sortIcon = "sort";

            if (isCurrentSortField)
            {
                sortIcon += "-by-alphabet";
                if (queryOptions.SortOrder == SortOrder.DESC)
                    sortIcon += "-alt";
            }
            return $"<span class=\"glyphicon glyphicon-{sortIcon}\"></span>";
        }
    }
}

