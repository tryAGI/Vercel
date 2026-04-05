
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp
    {
        /// <summary>
        /// 
        /// </summary>
        x_contains,
        /// <summary>
        /// 
        /// </summary>
        x_endsWith,
        /// <summary>
        /// 
        /// </summary>
        x_eq,
        /// <summary>
        /// 
        /// </summary>
        x_ex,
        /// <summary>
        /// 
        /// </summary>
        x_oneOf,
        /// <summary>
        /// 
        /// </summary>
        x_regex,
        /// <summary>
        /// 
        /// </summary>
        x_startsWith,
        /// <summary>
        /// 
        /// </summary>
        After,
        /// <summary>
        /// 
        /// </summary>
        Before,
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        ContainsAllOf,
        /// <summary>
        /// 
        /// </summary>
        ContainsAnyOf,
        /// <summary>
        /// 
        /// </summary>
        ContainsNoneOf,
        /// <summary>
        /// 
        /// </summary>
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Ex,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        OneOf,
        /// <summary>
        /// 
        /// </summary>
        Regex,
        /// <summary>
        /// 
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.x_contains => "!contains",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.x_endsWith => "!endsWith",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.x_eq => "!eq",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.x_ex => "!ex",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.x_oneOf => "!oneOf",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.x_regex => "!regex",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.x_startsWith => "!startsWith",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.After => "after",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Before => "before",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Contains => "contains",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.ContainsAllOf => "containsAllOf",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.ContainsAnyOf => "containsAnyOf",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.ContainsNoneOf => "containsNoneOf",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.EndsWith => "endsWith",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Eq => "eq",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Ex => "ex",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Gt => "gt",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Gte => "gte",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Lt => "lt",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Lte => "lte",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.OneOf => "oneOf",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Regex => "regex",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.x_contains,
                "!endsWith" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.x_endsWith,
                "!eq" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.x_eq,
                "!ex" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.x_ex,
                "!oneOf" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.x_oneOf,
                "!regex" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.x_regex,
                "!startsWith" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.x_startsWith,
                "after" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.After,
                "before" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Before,
                "contains" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Contains,
                "containsAllOf" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.ContainsAllOf,
                "containsAnyOf" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.ContainsAnyOf,
                "containsNoneOf" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.ContainsNoneOf,
                "endsWith" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.EndsWith,
                "eq" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Eq,
                "ex" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Ex,
                "gt" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Gt,
                "gte" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Gte,
                "lt" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Lt,
                "lte" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Lte,
                "oneOf" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.OneOf,
                "regex" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.Regex,
                "startsWith" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}