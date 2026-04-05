
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagRequestEnvironmentsRuleConditionCmp
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
    public static class CreateFlagRequestEnvironmentsRuleConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagRequestEnvironmentsRuleConditionCmp value)
        {
            return value switch
            {
                CreateFlagRequestEnvironmentsRuleConditionCmp.x_contains => "!contains",
                CreateFlagRequestEnvironmentsRuleConditionCmp.x_endsWith => "!endsWith",
                CreateFlagRequestEnvironmentsRuleConditionCmp.x_eq => "!eq",
                CreateFlagRequestEnvironmentsRuleConditionCmp.x_ex => "!ex",
                CreateFlagRequestEnvironmentsRuleConditionCmp.x_oneOf => "!oneOf",
                CreateFlagRequestEnvironmentsRuleConditionCmp.x_regex => "!regex",
                CreateFlagRequestEnvironmentsRuleConditionCmp.x_startsWith => "!startsWith",
                CreateFlagRequestEnvironmentsRuleConditionCmp.After => "after",
                CreateFlagRequestEnvironmentsRuleConditionCmp.Before => "before",
                CreateFlagRequestEnvironmentsRuleConditionCmp.Contains => "contains",
                CreateFlagRequestEnvironmentsRuleConditionCmp.ContainsAllOf => "containsAllOf",
                CreateFlagRequestEnvironmentsRuleConditionCmp.ContainsAnyOf => "containsAnyOf",
                CreateFlagRequestEnvironmentsRuleConditionCmp.ContainsNoneOf => "containsNoneOf",
                CreateFlagRequestEnvironmentsRuleConditionCmp.EndsWith => "endsWith",
                CreateFlagRequestEnvironmentsRuleConditionCmp.Eq => "eq",
                CreateFlagRequestEnvironmentsRuleConditionCmp.Ex => "ex",
                CreateFlagRequestEnvironmentsRuleConditionCmp.Gt => "gt",
                CreateFlagRequestEnvironmentsRuleConditionCmp.Gte => "gte",
                CreateFlagRequestEnvironmentsRuleConditionCmp.Lt => "lt",
                CreateFlagRequestEnvironmentsRuleConditionCmp.Lte => "lte",
                CreateFlagRequestEnvironmentsRuleConditionCmp.OneOf => "oneOf",
                CreateFlagRequestEnvironmentsRuleConditionCmp.Regex => "regex",
                CreateFlagRequestEnvironmentsRuleConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagRequestEnvironmentsRuleConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => CreateFlagRequestEnvironmentsRuleConditionCmp.x_contains,
                "!endsWith" => CreateFlagRequestEnvironmentsRuleConditionCmp.x_endsWith,
                "!eq" => CreateFlagRequestEnvironmentsRuleConditionCmp.x_eq,
                "!ex" => CreateFlagRequestEnvironmentsRuleConditionCmp.x_ex,
                "!oneOf" => CreateFlagRequestEnvironmentsRuleConditionCmp.x_oneOf,
                "!regex" => CreateFlagRequestEnvironmentsRuleConditionCmp.x_regex,
                "!startsWith" => CreateFlagRequestEnvironmentsRuleConditionCmp.x_startsWith,
                "after" => CreateFlagRequestEnvironmentsRuleConditionCmp.After,
                "before" => CreateFlagRequestEnvironmentsRuleConditionCmp.Before,
                "contains" => CreateFlagRequestEnvironmentsRuleConditionCmp.Contains,
                "containsAllOf" => CreateFlagRequestEnvironmentsRuleConditionCmp.ContainsAllOf,
                "containsAnyOf" => CreateFlagRequestEnvironmentsRuleConditionCmp.ContainsAnyOf,
                "containsNoneOf" => CreateFlagRequestEnvironmentsRuleConditionCmp.ContainsNoneOf,
                "endsWith" => CreateFlagRequestEnvironmentsRuleConditionCmp.EndsWith,
                "eq" => CreateFlagRequestEnvironmentsRuleConditionCmp.Eq,
                "ex" => CreateFlagRequestEnvironmentsRuleConditionCmp.Ex,
                "gt" => CreateFlagRequestEnvironmentsRuleConditionCmp.Gt,
                "gte" => CreateFlagRequestEnvironmentsRuleConditionCmp.Gte,
                "lt" => CreateFlagRequestEnvironmentsRuleConditionCmp.Lt,
                "lte" => CreateFlagRequestEnvironmentsRuleConditionCmp.Lte,
                "oneOf" => CreateFlagRequestEnvironmentsRuleConditionCmp.OneOf,
                "regex" => CreateFlagRequestEnvironmentsRuleConditionCmp.Regex,
                "startsWith" => CreateFlagRequestEnvironmentsRuleConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}