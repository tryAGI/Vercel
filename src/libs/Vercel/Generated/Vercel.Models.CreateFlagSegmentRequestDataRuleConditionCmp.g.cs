
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagSegmentRequestDataRuleConditionCmp
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
    public static class CreateFlagSegmentRequestDataRuleConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagSegmentRequestDataRuleConditionCmp value)
        {
            return value switch
            {
                CreateFlagSegmentRequestDataRuleConditionCmp.x_contains => "!contains",
                CreateFlagSegmentRequestDataRuleConditionCmp.x_endsWith => "!endsWith",
                CreateFlagSegmentRequestDataRuleConditionCmp.x_eq => "!eq",
                CreateFlagSegmentRequestDataRuleConditionCmp.x_ex => "!ex",
                CreateFlagSegmentRequestDataRuleConditionCmp.x_oneOf => "!oneOf",
                CreateFlagSegmentRequestDataRuleConditionCmp.x_regex => "!regex",
                CreateFlagSegmentRequestDataRuleConditionCmp.x_startsWith => "!startsWith",
                CreateFlagSegmentRequestDataRuleConditionCmp.After => "after",
                CreateFlagSegmentRequestDataRuleConditionCmp.Before => "before",
                CreateFlagSegmentRequestDataRuleConditionCmp.Contains => "contains",
                CreateFlagSegmentRequestDataRuleConditionCmp.ContainsAllOf => "containsAllOf",
                CreateFlagSegmentRequestDataRuleConditionCmp.ContainsAnyOf => "containsAnyOf",
                CreateFlagSegmentRequestDataRuleConditionCmp.ContainsNoneOf => "containsNoneOf",
                CreateFlagSegmentRequestDataRuleConditionCmp.EndsWith => "endsWith",
                CreateFlagSegmentRequestDataRuleConditionCmp.Eq => "eq",
                CreateFlagSegmentRequestDataRuleConditionCmp.Ex => "ex",
                CreateFlagSegmentRequestDataRuleConditionCmp.Gt => "gt",
                CreateFlagSegmentRequestDataRuleConditionCmp.Gte => "gte",
                CreateFlagSegmentRequestDataRuleConditionCmp.Lt => "lt",
                CreateFlagSegmentRequestDataRuleConditionCmp.Lte => "lte",
                CreateFlagSegmentRequestDataRuleConditionCmp.OneOf => "oneOf",
                CreateFlagSegmentRequestDataRuleConditionCmp.Regex => "regex",
                CreateFlagSegmentRequestDataRuleConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagSegmentRequestDataRuleConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => CreateFlagSegmentRequestDataRuleConditionCmp.x_contains,
                "!endsWith" => CreateFlagSegmentRequestDataRuleConditionCmp.x_endsWith,
                "!eq" => CreateFlagSegmentRequestDataRuleConditionCmp.x_eq,
                "!ex" => CreateFlagSegmentRequestDataRuleConditionCmp.x_ex,
                "!oneOf" => CreateFlagSegmentRequestDataRuleConditionCmp.x_oneOf,
                "!regex" => CreateFlagSegmentRequestDataRuleConditionCmp.x_regex,
                "!startsWith" => CreateFlagSegmentRequestDataRuleConditionCmp.x_startsWith,
                "after" => CreateFlagSegmentRequestDataRuleConditionCmp.After,
                "before" => CreateFlagSegmentRequestDataRuleConditionCmp.Before,
                "contains" => CreateFlagSegmentRequestDataRuleConditionCmp.Contains,
                "containsAllOf" => CreateFlagSegmentRequestDataRuleConditionCmp.ContainsAllOf,
                "containsAnyOf" => CreateFlagSegmentRequestDataRuleConditionCmp.ContainsAnyOf,
                "containsNoneOf" => CreateFlagSegmentRequestDataRuleConditionCmp.ContainsNoneOf,
                "endsWith" => CreateFlagSegmentRequestDataRuleConditionCmp.EndsWith,
                "eq" => CreateFlagSegmentRequestDataRuleConditionCmp.Eq,
                "ex" => CreateFlagSegmentRequestDataRuleConditionCmp.Ex,
                "gt" => CreateFlagSegmentRequestDataRuleConditionCmp.Gt,
                "gte" => CreateFlagSegmentRequestDataRuleConditionCmp.Gte,
                "lt" => CreateFlagSegmentRequestDataRuleConditionCmp.Lt,
                "lte" => CreateFlagSegmentRequestDataRuleConditionCmp.Lte,
                "oneOf" => CreateFlagSegmentRequestDataRuleConditionCmp.OneOf,
                "regex" => CreateFlagSegmentRequestDataRuleConditionCmp.Regex,
                "startsWith" => CreateFlagSegmentRequestDataRuleConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}