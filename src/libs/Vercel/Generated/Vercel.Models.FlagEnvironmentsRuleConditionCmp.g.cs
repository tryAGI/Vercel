
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagEnvironmentsRuleConditionCmp
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
    public static class FlagEnvironmentsRuleConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsRuleConditionCmp value)
        {
            return value switch
            {
                FlagEnvironmentsRuleConditionCmp.x_contains => "!contains",
                FlagEnvironmentsRuleConditionCmp.x_endsWith => "!endsWith",
                FlagEnvironmentsRuleConditionCmp.x_eq => "!eq",
                FlagEnvironmentsRuleConditionCmp.x_ex => "!ex",
                FlagEnvironmentsRuleConditionCmp.x_oneOf => "!oneOf",
                FlagEnvironmentsRuleConditionCmp.x_regex => "!regex",
                FlagEnvironmentsRuleConditionCmp.x_startsWith => "!startsWith",
                FlagEnvironmentsRuleConditionCmp.After => "after",
                FlagEnvironmentsRuleConditionCmp.Before => "before",
                FlagEnvironmentsRuleConditionCmp.Contains => "contains",
                FlagEnvironmentsRuleConditionCmp.ContainsAllOf => "containsAllOf",
                FlagEnvironmentsRuleConditionCmp.ContainsAnyOf => "containsAnyOf",
                FlagEnvironmentsRuleConditionCmp.ContainsNoneOf => "containsNoneOf",
                FlagEnvironmentsRuleConditionCmp.EndsWith => "endsWith",
                FlagEnvironmentsRuleConditionCmp.Eq => "eq",
                FlagEnvironmentsRuleConditionCmp.Ex => "ex",
                FlagEnvironmentsRuleConditionCmp.Gt => "gt",
                FlagEnvironmentsRuleConditionCmp.Gte => "gte",
                FlagEnvironmentsRuleConditionCmp.Lt => "lt",
                FlagEnvironmentsRuleConditionCmp.Lte => "lte",
                FlagEnvironmentsRuleConditionCmp.OneOf => "oneOf",
                FlagEnvironmentsRuleConditionCmp.Regex => "regex",
                FlagEnvironmentsRuleConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsRuleConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => FlagEnvironmentsRuleConditionCmp.x_contains,
                "!endsWith" => FlagEnvironmentsRuleConditionCmp.x_endsWith,
                "!eq" => FlagEnvironmentsRuleConditionCmp.x_eq,
                "!ex" => FlagEnvironmentsRuleConditionCmp.x_ex,
                "!oneOf" => FlagEnvironmentsRuleConditionCmp.x_oneOf,
                "!regex" => FlagEnvironmentsRuleConditionCmp.x_regex,
                "!startsWith" => FlagEnvironmentsRuleConditionCmp.x_startsWith,
                "after" => FlagEnvironmentsRuleConditionCmp.After,
                "before" => FlagEnvironmentsRuleConditionCmp.Before,
                "contains" => FlagEnvironmentsRuleConditionCmp.Contains,
                "containsAllOf" => FlagEnvironmentsRuleConditionCmp.ContainsAllOf,
                "containsAnyOf" => FlagEnvironmentsRuleConditionCmp.ContainsAnyOf,
                "containsNoneOf" => FlagEnvironmentsRuleConditionCmp.ContainsNoneOf,
                "endsWith" => FlagEnvironmentsRuleConditionCmp.EndsWith,
                "eq" => FlagEnvironmentsRuleConditionCmp.Eq,
                "ex" => FlagEnvironmentsRuleConditionCmp.Ex,
                "gt" => FlagEnvironmentsRuleConditionCmp.Gt,
                "gte" => FlagEnvironmentsRuleConditionCmp.Gte,
                "lt" => FlagEnvironmentsRuleConditionCmp.Lt,
                "lte" => FlagEnvironmentsRuleConditionCmp.Lte,
                "oneOf" => FlagEnvironmentsRuleConditionCmp.OneOf,
                "regex" => FlagEnvironmentsRuleConditionCmp.Regex,
                "startsWith" => FlagEnvironmentsRuleConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}