
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagRequestEnvironmentsRuleConditionCmp
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
    public static class UpdateFlagRequestEnvironmentsRuleConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagRequestEnvironmentsRuleConditionCmp value)
        {
            return value switch
            {
                UpdateFlagRequestEnvironmentsRuleConditionCmp.x_contains => "!contains",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.x_endsWith => "!endsWith",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.x_eq => "!eq",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.x_ex => "!ex",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.x_oneOf => "!oneOf",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.x_regex => "!regex",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.x_startsWith => "!startsWith",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.After => "after",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.Before => "before",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.Contains => "contains",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.ContainsAllOf => "containsAllOf",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.ContainsAnyOf => "containsAnyOf",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.ContainsNoneOf => "containsNoneOf",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.EndsWith => "endsWith",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.Eq => "eq",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.Ex => "ex",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.Gt => "gt",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.Gte => "gte",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.Lt => "lt",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.Lte => "lte",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.OneOf => "oneOf",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.Regex => "regex",
                UpdateFlagRequestEnvironmentsRuleConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagRequestEnvironmentsRuleConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => UpdateFlagRequestEnvironmentsRuleConditionCmp.x_contains,
                "!endsWith" => UpdateFlagRequestEnvironmentsRuleConditionCmp.x_endsWith,
                "!eq" => UpdateFlagRequestEnvironmentsRuleConditionCmp.x_eq,
                "!ex" => UpdateFlagRequestEnvironmentsRuleConditionCmp.x_ex,
                "!oneOf" => UpdateFlagRequestEnvironmentsRuleConditionCmp.x_oneOf,
                "!regex" => UpdateFlagRequestEnvironmentsRuleConditionCmp.x_regex,
                "!startsWith" => UpdateFlagRequestEnvironmentsRuleConditionCmp.x_startsWith,
                "after" => UpdateFlagRequestEnvironmentsRuleConditionCmp.After,
                "before" => UpdateFlagRequestEnvironmentsRuleConditionCmp.Before,
                "contains" => UpdateFlagRequestEnvironmentsRuleConditionCmp.Contains,
                "containsAllOf" => UpdateFlagRequestEnvironmentsRuleConditionCmp.ContainsAllOf,
                "containsAnyOf" => UpdateFlagRequestEnvironmentsRuleConditionCmp.ContainsAnyOf,
                "containsNoneOf" => UpdateFlagRequestEnvironmentsRuleConditionCmp.ContainsNoneOf,
                "endsWith" => UpdateFlagRequestEnvironmentsRuleConditionCmp.EndsWith,
                "eq" => UpdateFlagRequestEnvironmentsRuleConditionCmp.Eq,
                "ex" => UpdateFlagRequestEnvironmentsRuleConditionCmp.Ex,
                "gt" => UpdateFlagRequestEnvironmentsRuleConditionCmp.Gt,
                "gte" => UpdateFlagRequestEnvironmentsRuleConditionCmp.Gte,
                "lt" => UpdateFlagRequestEnvironmentsRuleConditionCmp.Lt,
                "lte" => UpdateFlagRequestEnvironmentsRuleConditionCmp.Lte,
                "oneOf" => UpdateFlagRequestEnvironmentsRuleConditionCmp.OneOf,
                "regex" => UpdateFlagRequestEnvironmentsRuleConditionCmp.Regex,
                "startsWith" => UpdateFlagRequestEnvironmentsRuleConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}