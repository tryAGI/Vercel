
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsRuleConditionCmp
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
    public static class UpdateFlagResponseEnvironmentsRuleConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsRuleConditionCmp value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsRuleConditionCmp.x_contains => "!contains",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.x_endsWith => "!endsWith",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.x_eq => "!eq",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.x_ex => "!ex",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.x_oneOf => "!oneOf",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.x_regex => "!regex",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.x_startsWith => "!startsWith",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.After => "after",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.Before => "before",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.Contains => "contains",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.ContainsAllOf => "containsAllOf",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.ContainsAnyOf => "containsAnyOf",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.ContainsNoneOf => "containsNoneOf",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.EndsWith => "endsWith",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.Eq => "eq",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.Ex => "ex",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.Gt => "gt",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.Gte => "gte",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.Lt => "lt",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.Lte => "lte",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.OneOf => "oneOf",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.Regex => "regex",
                UpdateFlagResponseEnvironmentsRuleConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsRuleConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => UpdateFlagResponseEnvironmentsRuleConditionCmp.x_contains,
                "!endsWith" => UpdateFlagResponseEnvironmentsRuleConditionCmp.x_endsWith,
                "!eq" => UpdateFlagResponseEnvironmentsRuleConditionCmp.x_eq,
                "!ex" => UpdateFlagResponseEnvironmentsRuleConditionCmp.x_ex,
                "!oneOf" => UpdateFlagResponseEnvironmentsRuleConditionCmp.x_oneOf,
                "!regex" => UpdateFlagResponseEnvironmentsRuleConditionCmp.x_regex,
                "!startsWith" => UpdateFlagResponseEnvironmentsRuleConditionCmp.x_startsWith,
                "after" => UpdateFlagResponseEnvironmentsRuleConditionCmp.After,
                "before" => UpdateFlagResponseEnvironmentsRuleConditionCmp.Before,
                "contains" => UpdateFlagResponseEnvironmentsRuleConditionCmp.Contains,
                "containsAllOf" => UpdateFlagResponseEnvironmentsRuleConditionCmp.ContainsAllOf,
                "containsAnyOf" => UpdateFlagResponseEnvironmentsRuleConditionCmp.ContainsAnyOf,
                "containsNoneOf" => UpdateFlagResponseEnvironmentsRuleConditionCmp.ContainsNoneOf,
                "endsWith" => UpdateFlagResponseEnvironmentsRuleConditionCmp.EndsWith,
                "eq" => UpdateFlagResponseEnvironmentsRuleConditionCmp.Eq,
                "ex" => UpdateFlagResponseEnvironmentsRuleConditionCmp.Ex,
                "gt" => UpdateFlagResponseEnvironmentsRuleConditionCmp.Gt,
                "gte" => UpdateFlagResponseEnvironmentsRuleConditionCmp.Gte,
                "lt" => UpdateFlagResponseEnvironmentsRuleConditionCmp.Lt,
                "lte" => UpdateFlagResponseEnvironmentsRuleConditionCmp.Lte,
                "oneOf" => UpdateFlagResponseEnvironmentsRuleConditionCmp.OneOf,
                "regex" => UpdateFlagResponseEnvironmentsRuleConditionCmp.Regex,
                "startsWith" => UpdateFlagResponseEnvironmentsRuleConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}