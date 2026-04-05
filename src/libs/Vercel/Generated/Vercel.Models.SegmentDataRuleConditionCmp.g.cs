
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SegmentDataRuleConditionCmp
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
    public static class SegmentDataRuleConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentDataRuleConditionCmp value)
        {
            return value switch
            {
                SegmentDataRuleConditionCmp.x_contains => "!contains",
                SegmentDataRuleConditionCmp.x_endsWith => "!endsWith",
                SegmentDataRuleConditionCmp.x_eq => "!eq",
                SegmentDataRuleConditionCmp.x_ex => "!ex",
                SegmentDataRuleConditionCmp.x_oneOf => "!oneOf",
                SegmentDataRuleConditionCmp.x_regex => "!regex",
                SegmentDataRuleConditionCmp.x_startsWith => "!startsWith",
                SegmentDataRuleConditionCmp.After => "after",
                SegmentDataRuleConditionCmp.Before => "before",
                SegmentDataRuleConditionCmp.Contains => "contains",
                SegmentDataRuleConditionCmp.ContainsAllOf => "containsAllOf",
                SegmentDataRuleConditionCmp.ContainsAnyOf => "containsAnyOf",
                SegmentDataRuleConditionCmp.ContainsNoneOf => "containsNoneOf",
                SegmentDataRuleConditionCmp.EndsWith => "endsWith",
                SegmentDataRuleConditionCmp.Eq => "eq",
                SegmentDataRuleConditionCmp.Ex => "ex",
                SegmentDataRuleConditionCmp.Gt => "gt",
                SegmentDataRuleConditionCmp.Gte => "gte",
                SegmentDataRuleConditionCmp.Lt => "lt",
                SegmentDataRuleConditionCmp.Lte => "lte",
                SegmentDataRuleConditionCmp.OneOf => "oneOf",
                SegmentDataRuleConditionCmp.Regex => "regex",
                SegmentDataRuleConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentDataRuleConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => SegmentDataRuleConditionCmp.x_contains,
                "!endsWith" => SegmentDataRuleConditionCmp.x_endsWith,
                "!eq" => SegmentDataRuleConditionCmp.x_eq,
                "!ex" => SegmentDataRuleConditionCmp.x_ex,
                "!oneOf" => SegmentDataRuleConditionCmp.x_oneOf,
                "!regex" => SegmentDataRuleConditionCmp.x_regex,
                "!startsWith" => SegmentDataRuleConditionCmp.x_startsWith,
                "after" => SegmentDataRuleConditionCmp.After,
                "before" => SegmentDataRuleConditionCmp.Before,
                "contains" => SegmentDataRuleConditionCmp.Contains,
                "containsAllOf" => SegmentDataRuleConditionCmp.ContainsAllOf,
                "containsAnyOf" => SegmentDataRuleConditionCmp.ContainsAnyOf,
                "containsNoneOf" => SegmentDataRuleConditionCmp.ContainsNoneOf,
                "endsWith" => SegmentDataRuleConditionCmp.EndsWith,
                "eq" => SegmentDataRuleConditionCmp.Eq,
                "ex" => SegmentDataRuleConditionCmp.Ex,
                "gt" => SegmentDataRuleConditionCmp.Gt,
                "gte" => SegmentDataRuleConditionCmp.Gte,
                "lt" => SegmentDataRuleConditionCmp.Lt,
                "lte" => SegmentDataRuleConditionCmp.Lte,
                "oneOf" => SegmentDataRuleConditionCmp.OneOf,
                "regex" => SegmentDataRuleConditionCmp.Regex,
                "startsWith" => SegmentDataRuleConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}