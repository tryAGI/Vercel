
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagSegmentResponseDataRuleConditionCmp
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
    public static class UpdateFlagSegmentResponseDataRuleConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagSegmentResponseDataRuleConditionCmp value)
        {
            return value switch
            {
                UpdateFlagSegmentResponseDataRuleConditionCmp.x_contains => "!contains",
                UpdateFlagSegmentResponseDataRuleConditionCmp.x_endsWith => "!endsWith",
                UpdateFlagSegmentResponseDataRuleConditionCmp.x_eq => "!eq",
                UpdateFlagSegmentResponseDataRuleConditionCmp.x_ex => "!ex",
                UpdateFlagSegmentResponseDataRuleConditionCmp.x_oneOf => "!oneOf",
                UpdateFlagSegmentResponseDataRuleConditionCmp.x_regex => "!regex",
                UpdateFlagSegmentResponseDataRuleConditionCmp.x_startsWith => "!startsWith",
                UpdateFlagSegmentResponseDataRuleConditionCmp.After => "after",
                UpdateFlagSegmentResponseDataRuleConditionCmp.Before => "before",
                UpdateFlagSegmentResponseDataRuleConditionCmp.Contains => "contains",
                UpdateFlagSegmentResponseDataRuleConditionCmp.ContainsAllOf => "containsAllOf",
                UpdateFlagSegmentResponseDataRuleConditionCmp.ContainsAnyOf => "containsAnyOf",
                UpdateFlagSegmentResponseDataRuleConditionCmp.ContainsNoneOf => "containsNoneOf",
                UpdateFlagSegmentResponseDataRuleConditionCmp.EndsWith => "endsWith",
                UpdateFlagSegmentResponseDataRuleConditionCmp.Eq => "eq",
                UpdateFlagSegmentResponseDataRuleConditionCmp.Ex => "ex",
                UpdateFlagSegmentResponseDataRuleConditionCmp.Gt => "gt",
                UpdateFlagSegmentResponseDataRuleConditionCmp.Gte => "gte",
                UpdateFlagSegmentResponseDataRuleConditionCmp.Lt => "lt",
                UpdateFlagSegmentResponseDataRuleConditionCmp.Lte => "lte",
                UpdateFlagSegmentResponseDataRuleConditionCmp.OneOf => "oneOf",
                UpdateFlagSegmentResponseDataRuleConditionCmp.Regex => "regex",
                UpdateFlagSegmentResponseDataRuleConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagSegmentResponseDataRuleConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => UpdateFlagSegmentResponseDataRuleConditionCmp.x_contains,
                "!endsWith" => UpdateFlagSegmentResponseDataRuleConditionCmp.x_endsWith,
                "!eq" => UpdateFlagSegmentResponseDataRuleConditionCmp.x_eq,
                "!ex" => UpdateFlagSegmentResponseDataRuleConditionCmp.x_ex,
                "!oneOf" => UpdateFlagSegmentResponseDataRuleConditionCmp.x_oneOf,
                "!regex" => UpdateFlagSegmentResponseDataRuleConditionCmp.x_regex,
                "!startsWith" => UpdateFlagSegmentResponseDataRuleConditionCmp.x_startsWith,
                "after" => UpdateFlagSegmentResponseDataRuleConditionCmp.After,
                "before" => UpdateFlagSegmentResponseDataRuleConditionCmp.Before,
                "contains" => UpdateFlagSegmentResponseDataRuleConditionCmp.Contains,
                "containsAllOf" => UpdateFlagSegmentResponseDataRuleConditionCmp.ContainsAllOf,
                "containsAnyOf" => UpdateFlagSegmentResponseDataRuleConditionCmp.ContainsAnyOf,
                "containsNoneOf" => UpdateFlagSegmentResponseDataRuleConditionCmp.ContainsNoneOf,
                "endsWith" => UpdateFlagSegmentResponseDataRuleConditionCmp.EndsWith,
                "eq" => UpdateFlagSegmentResponseDataRuleConditionCmp.Eq,
                "ex" => UpdateFlagSegmentResponseDataRuleConditionCmp.Ex,
                "gt" => UpdateFlagSegmentResponseDataRuleConditionCmp.Gt,
                "gte" => UpdateFlagSegmentResponseDataRuleConditionCmp.Gte,
                "lt" => UpdateFlagSegmentResponseDataRuleConditionCmp.Lt,
                "lte" => UpdateFlagSegmentResponseDataRuleConditionCmp.Lte,
                "oneOf" => UpdateFlagSegmentResponseDataRuleConditionCmp.OneOf,
                "regex" => UpdateFlagSegmentResponseDataRuleConditionCmp.Regex,
                "startsWith" => UpdateFlagSegmentResponseDataRuleConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}