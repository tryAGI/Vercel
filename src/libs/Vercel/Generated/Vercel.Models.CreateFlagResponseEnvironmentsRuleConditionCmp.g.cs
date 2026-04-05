
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseEnvironmentsRuleConditionCmp
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
    public static class CreateFlagResponseEnvironmentsRuleConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseEnvironmentsRuleConditionCmp value)
        {
            return value switch
            {
                CreateFlagResponseEnvironmentsRuleConditionCmp.x_contains => "!contains",
                CreateFlagResponseEnvironmentsRuleConditionCmp.x_endsWith => "!endsWith",
                CreateFlagResponseEnvironmentsRuleConditionCmp.x_eq => "!eq",
                CreateFlagResponseEnvironmentsRuleConditionCmp.x_ex => "!ex",
                CreateFlagResponseEnvironmentsRuleConditionCmp.x_oneOf => "!oneOf",
                CreateFlagResponseEnvironmentsRuleConditionCmp.x_regex => "!regex",
                CreateFlagResponseEnvironmentsRuleConditionCmp.x_startsWith => "!startsWith",
                CreateFlagResponseEnvironmentsRuleConditionCmp.After => "after",
                CreateFlagResponseEnvironmentsRuleConditionCmp.Before => "before",
                CreateFlagResponseEnvironmentsRuleConditionCmp.Contains => "contains",
                CreateFlagResponseEnvironmentsRuleConditionCmp.ContainsAllOf => "containsAllOf",
                CreateFlagResponseEnvironmentsRuleConditionCmp.ContainsAnyOf => "containsAnyOf",
                CreateFlagResponseEnvironmentsRuleConditionCmp.ContainsNoneOf => "containsNoneOf",
                CreateFlagResponseEnvironmentsRuleConditionCmp.EndsWith => "endsWith",
                CreateFlagResponseEnvironmentsRuleConditionCmp.Eq => "eq",
                CreateFlagResponseEnvironmentsRuleConditionCmp.Ex => "ex",
                CreateFlagResponseEnvironmentsRuleConditionCmp.Gt => "gt",
                CreateFlagResponseEnvironmentsRuleConditionCmp.Gte => "gte",
                CreateFlagResponseEnvironmentsRuleConditionCmp.Lt => "lt",
                CreateFlagResponseEnvironmentsRuleConditionCmp.Lte => "lte",
                CreateFlagResponseEnvironmentsRuleConditionCmp.OneOf => "oneOf",
                CreateFlagResponseEnvironmentsRuleConditionCmp.Regex => "regex",
                CreateFlagResponseEnvironmentsRuleConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseEnvironmentsRuleConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => CreateFlagResponseEnvironmentsRuleConditionCmp.x_contains,
                "!endsWith" => CreateFlagResponseEnvironmentsRuleConditionCmp.x_endsWith,
                "!eq" => CreateFlagResponseEnvironmentsRuleConditionCmp.x_eq,
                "!ex" => CreateFlagResponseEnvironmentsRuleConditionCmp.x_ex,
                "!oneOf" => CreateFlagResponseEnvironmentsRuleConditionCmp.x_oneOf,
                "!regex" => CreateFlagResponseEnvironmentsRuleConditionCmp.x_regex,
                "!startsWith" => CreateFlagResponseEnvironmentsRuleConditionCmp.x_startsWith,
                "after" => CreateFlagResponseEnvironmentsRuleConditionCmp.After,
                "before" => CreateFlagResponseEnvironmentsRuleConditionCmp.Before,
                "contains" => CreateFlagResponseEnvironmentsRuleConditionCmp.Contains,
                "containsAllOf" => CreateFlagResponseEnvironmentsRuleConditionCmp.ContainsAllOf,
                "containsAnyOf" => CreateFlagResponseEnvironmentsRuleConditionCmp.ContainsAnyOf,
                "containsNoneOf" => CreateFlagResponseEnvironmentsRuleConditionCmp.ContainsNoneOf,
                "endsWith" => CreateFlagResponseEnvironmentsRuleConditionCmp.EndsWith,
                "eq" => CreateFlagResponseEnvironmentsRuleConditionCmp.Eq,
                "ex" => CreateFlagResponseEnvironmentsRuleConditionCmp.Ex,
                "gt" => CreateFlagResponseEnvironmentsRuleConditionCmp.Gt,
                "gte" => CreateFlagResponseEnvironmentsRuleConditionCmp.Gte,
                "lt" => CreateFlagResponseEnvironmentsRuleConditionCmp.Lt,
                "lte" => CreateFlagResponseEnvironmentsRuleConditionCmp.Lte,
                "oneOf" => CreateFlagResponseEnvironmentsRuleConditionCmp.OneOf,
                "regex" => CreateFlagResponseEnvironmentsRuleConditionCmp.Regex,
                "startsWith" => CreateFlagResponseEnvironmentsRuleConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}