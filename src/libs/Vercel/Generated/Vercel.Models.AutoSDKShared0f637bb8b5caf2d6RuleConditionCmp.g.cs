
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp
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
    public static class AutoSDKShared0f637bb8b5caf2d6RuleConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp value)
        {
            return value switch
            {
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.x_contains => "!contains",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.x_endsWith => "!endsWith",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.x_eq => "!eq",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.x_ex => "!ex",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.x_oneOf => "!oneOf",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.x_regex => "!regex",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.x_startsWith => "!startsWith",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.After => "after",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Before => "before",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Contains => "contains",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.ContainsAllOf => "containsAllOf",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.ContainsAnyOf => "containsAnyOf",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.ContainsNoneOf => "containsNoneOf",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.EndsWith => "endsWith",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Eq => "eq",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Ex => "ex",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Gt => "gt",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Gte => "gte",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Lt => "lt",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Lte => "lte",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.OneOf => "oneOf",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Regex => "regex",
                AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.x_contains,
                "!endsWith" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.x_endsWith,
                "!eq" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.x_eq,
                "!ex" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.x_ex,
                "!oneOf" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.x_oneOf,
                "!regex" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.x_regex,
                "!startsWith" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.x_startsWith,
                "after" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.After,
                "before" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Before,
                "contains" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Contains,
                "containsAllOf" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.ContainsAllOf,
                "containsAnyOf" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.ContainsAnyOf,
                "containsNoneOf" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.ContainsNoneOf,
                "endsWith" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.EndsWith,
                "eq" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Eq,
                "ex" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Ex,
                "gt" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Gt,
                "gte" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Gte,
                "lt" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Lt,
                "lte" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Lte,
                "oneOf" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.OneOf,
                "regex" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.Regex,
                "startsWith" => AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}