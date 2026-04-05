
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagSegmentResponseDataRuleConditionCmp
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
    public static class CreateFlagSegmentResponseDataRuleConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagSegmentResponseDataRuleConditionCmp value)
        {
            return value switch
            {
                CreateFlagSegmentResponseDataRuleConditionCmp.x_contains => "!contains",
                CreateFlagSegmentResponseDataRuleConditionCmp.x_endsWith => "!endsWith",
                CreateFlagSegmentResponseDataRuleConditionCmp.x_eq => "!eq",
                CreateFlagSegmentResponseDataRuleConditionCmp.x_ex => "!ex",
                CreateFlagSegmentResponseDataRuleConditionCmp.x_oneOf => "!oneOf",
                CreateFlagSegmentResponseDataRuleConditionCmp.x_regex => "!regex",
                CreateFlagSegmentResponseDataRuleConditionCmp.x_startsWith => "!startsWith",
                CreateFlagSegmentResponseDataRuleConditionCmp.After => "after",
                CreateFlagSegmentResponseDataRuleConditionCmp.Before => "before",
                CreateFlagSegmentResponseDataRuleConditionCmp.Contains => "contains",
                CreateFlagSegmentResponseDataRuleConditionCmp.ContainsAllOf => "containsAllOf",
                CreateFlagSegmentResponseDataRuleConditionCmp.ContainsAnyOf => "containsAnyOf",
                CreateFlagSegmentResponseDataRuleConditionCmp.ContainsNoneOf => "containsNoneOf",
                CreateFlagSegmentResponseDataRuleConditionCmp.EndsWith => "endsWith",
                CreateFlagSegmentResponseDataRuleConditionCmp.Eq => "eq",
                CreateFlagSegmentResponseDataRuleConditionCmp.Ex => "ex",
                CreateFlagSegmentResponseDataRuleConditionCmp.Gt => "gt",
                CreateFlagSegmentResponseDataRuleConditionCmp.Gte => "gte",
                CreateFlagSegmentResponseDataRuleConditionCmp.Lt => "lt",
                CreateFlagSegmentResponseDataRuleConditionCmp.Lte => "lte",
                CreateFlagSegmentResponseDataRuleConditionCmp.OneOf => "oneOf",
                CreateFlagSegmentResponseDataRuleConditionCmp.Regex => "regex",
                CreateFlagSegmentResponseDataRuleConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagSegmentResponseDataRuleConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => CreateFlagSegmentResponseDataRuleConditionCmp.x_contains,
                "!endsWith" => CreateFlagSegmentResponseDataRuleConditionCmp.x_endsWith,
                "!eq" => CreateFlagSegmentResponseDataRuleConditionCmp.x_eq,
                "!ex" => CreateFlagSegmentResponseDataRuleConditionCmp.x_ex,
                "!oneOf" => CreateFlagSegmentResponseDataRuleConditionCmp.x_oneOf,
                "!regex" => CreateFlagSegmentResponseDataRuleConditionCmp.x_regex,
                "!startsWith" => CreateFlagSegmentResponseDataRuleConditionCmp.x_startsWith,
                "after" => CreateFlagSegmentResponseDataRuleConditionCmp.After,
                "before" => CreateFlagSegmentResponseDataRuleConditionCmp.Before,
                "contains" => CreateFlagSegmentResponseDataRuleConditionCmp.Contains,
                "containsAllOf" => CreateFlagSegmentResponseDataRuleConditionCmp.ContainsAllOf,
                "containsAnyOf" => CreateFlagSegmentResponseDataRuleConditionCmp.ContainsAnyOf,
                "containsNoneOf" => CreateFlagSegmentResponseDataRuleConditionCmp.ContainsNoneOf,
                "endsWith" => CreateFlagSegmentResponseDataRuleConditionCmp.EndsWith,
                "eq" => CreateFlagSegmentResponseDataRuleConditionCmp.Eq,
                "ex" => CreateFlagSegmentResponseDataRuleConditionCmp.Ex,
                "gt" => CreateFlagSegmentResponseDataRuleConditionCmp.Gt,
                "gte" => CreateFlagSegmentResponseDataRuleConditionCmp.Gte,
                "lt" => CreateFlagSegmentResponseDataRuleConditionCmp.Lt,
                "lte" => CreateFlagSegmentResponseDataRuleConditionCmp.Lte,
                "oneOf" => CreateFlagSegmentResponseDataRuleConditionCmp.OneOf,
                "regex" => CreateFlagSegmentResponseDataRuleConditionCmp.Regex,
                "startsWith" => CreateFlagSegmentResponseDataRuleConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}