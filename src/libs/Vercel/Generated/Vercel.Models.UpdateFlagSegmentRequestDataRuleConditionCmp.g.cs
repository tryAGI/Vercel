
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagSegmentRequestDataRuleConditionCmp
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
    public static class UpdateFlagSegmentRequestDataRuleConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagSegmentRequestDataRuleConditionCmp value)
        {
            return value switch
            {
                UpdateFlagSegmentRequestDataRuleConditionCmp.x_contains => "!contains",
                UpdateFlagSegmentRequestDataRuleConditionCmp.x_endsWith => "!endsWith",
                UpdateFlagSegmentRequestDataRuleConditionCmp.x_eq => "!eq",
                UpdateFlagSegmentRequestDataRuleConditionCmp.x_ex => "!ex",
                UpdateFlagSegmentRequestDataRuleConditionCmp.x_oneOf => "!oneOf",
                UpdateFlagSegmentRequestDataRuleConditionCmp.x_regex => "!regex",
                UpdateFlagSegmentRequestDataRuleConditionCmp.x_startsWith => "!startsWith",
                UpdateFlagSegmentRequestDataRuleConditionCmp.After => "after",
                UpdateFlagSegmentRequestDataRuleConditionCmp.Before => "before",
                UpdateFlagSegmentRequestDataRuleConditionCmp.Contains => "contains",
                UpdateFlagSegmentRequestDataRuleConditionCmp.ContainsAllOf => "containsAllOf",
                UpdateFlagSegmentRequestDataRuleConditionCmp.ContainsAnyOf => "containsAnyOf",
                UpdateFlagSegmentRequestDataRuleConditionCmp.ContainsNoneOf => "containsNoneOf",
                UpdateFlagSegmentRequestDataRuleConditionCmp.EndsWith => "endsWith",
                UpdateFlagSegmentRequestDataRuleConditionCmp.Eq => "eq",
                UpdateFlagSegmentRequestDataRuleConditionCmp.Ex => "ex",
                UpdateFlagSegmentRequestDataRuleConditionCmp.Gt => "gt",
                UpdateFlagSegmentRequestDataRuleConditionCmp.Gte => "gte",
                UpdateFlagSegmentRequestDataRuleConditionCmp.Lt => "lt",
                UpdateFlagSegmentRequestDataRuleConditionCmp.Lte => "lte",
                UpdateFlagSegmentRequestDataRuleConditionCmp.OneOf => "oneOf",
                UpdateFlagSegmentRequestDataRuleConditionCmp.Regex => "regex",
                UpdateFlagSegmentRequestDataRuleConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagSegmentRequestDataRuleConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => UpdateFlagSegmentRequestDataRuleConditionCmp.x_contains,
                "!endsWith" => UpdateFlagSegmentRequestDataRuleConditionCmp.x_endsWith,
                "!eq" => UpdateFlagSegmentRequestDataRuleConditionCmp.x_eq,
                "!ex" => UpdateFlagSegmentRequestDataRuleConditionCmp.x_ex,
                "!oneOf" => UpdateFlagSegmentRequestDataRuleConditionCmp.x_oneOf,
                "!regex" => UpdateFlagSegmentRequestDataRuleConditionCmp.x_regex,
                "!startsWith" => UpdateFlagSegmentRequestDataRuleConditionCmp.x_startsWith,
                "after" => UpdateFlagSegmentRequestDataRuleConditionCmp.After,
                "before" => UpdateFlagSegmentRequestDataRuleConditionCmp.Before,
                "contains" => UpdateFlagSegmentRequestDataRuleConditionCmp.Contains,
                "containsAllOf" => UpdateFlagSegmentRequestDataRuleConditionCmp.ContainsAllOf,
                "containsAnyOf" => UpdateFlagSegmentRequestDataRuleConditionCmp.ContainsAnyOf,
                "containsNoneOf" => UpdateFlagSegmentRequestDataRuleConditionCmp.ContainsNoneOf,
                "endsWith" => UpdateFlagSegmentRequestDataRuleConditionCmp.EndsWith,
                "eq" => UpdateFlagSegmentRequestDataRuleConditionCmp.Eq,
                "ex" => UpdateFlagSegmentRequestDataRuleConditionCmp.Ex,
                "gt" => UpdateFlagSegmentRequestDataRuleConditionCmp.Gt,
                "gte" => UpdateFlagSegmentRequestDataRuleConditionCmp.Gte,
                "lt" => UpdateFlagSegmentRequestDataRuleConditionCmp.Lt,
                "lte" => UpdateFlagSegmentRequestDataRuleConditionCmp.Lte,
                "oneOf" => UpdateFlagSegmentRequestDataRuleConditionCmp.OneOf,
                "regex" => UpdateFlagSegmentRequestDataRuleConditionCmp.Regex,
                "startsWith" => UpdateFlagSegmentRequestDataRuleConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}