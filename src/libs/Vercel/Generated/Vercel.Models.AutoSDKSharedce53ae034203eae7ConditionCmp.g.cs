
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedce53ae034203eae7ConditionCmp
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
    public static class AutoSDKSharedce53ae034203eae7ConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedce53ae034203eae7ConditionCmp value)
        {
            return value switch
            {
                AutoSDKSharedce53ae034203eae7ConditionCmp.x_contains => "!contains",
                AutoSDKSharedce53ae034203eae7ConditionCmp.x_endsWith => "!endsWith",
                AutoSDKSharedce53ae034203eae7ConditionCmp.x_eq => "!eq",
                AutoSDKSharedce53ae034203eae7ConditionCmp.x_ex => "!ex",
                AutoSDKSharedce53ae034203eae7ConditionCmp.x_oneOf => "!oneOf",
                AutoSDKSharedce53ae034203eae7ConditionCmp.x_regex => "!regex",
                AutoSDKSharedce53ae034203eae7ConditionCmp.x_startsWith => "!startsWith",
                AutoSDKSharedce53ae034203eae7ConditionCmp.After => "after",
                AutoSDKSharedce53ae034203eae7ConditionCmp.Before => "before",
                AutoSDKSharedce53ae034203eae7ConditionCmp.Contains => "contains",
                AutoSDKSharedce53ae034203eae7ConditionCmp.ContainsAllOf => "containsAllOf",
                AutoSDKSharedce53ae034203eae7ConditionCmp.ContainsAnyOf => "containsAnyOf",
                AutoSDKSharedce53ae034203eae7ConditionCmp.ContainsNoneOf => "containsNoneOf",
                AutoSDKSharedce53ae034203eae7ConditionCmp.EndsWith => "endsWith",
                AutoSDKSharedce53ae034203eae7ConditionCmp.Eq => "eq",
                AutoSDKSharedce53ae034203eae7ConditionCmp.Ex => "ex",
                AutoSDKSharedce53ae034203eae7ConditionCmp.Gt => "gt",
                AutoSDKSharedce53ae034203eae7ConditionCmp.Gte => "gte",
                AutoSDKSharedce53ae034203eae7ConditionCmp.Lt => "lt",
                AutoSDKSharedce53ae034203eae7ConditionCmp.Lte => "lte",
                AutoSDKSharedce53ae034203eae7ConditionCmp.OneOf => "oneOf",
                AutoSDKSharedce53ae034203eae7ConditionCmp.Regex => "regex",
                AutoSDKSharedce53ae034203eae7ConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedce53ae034203eae7ConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => AutoSDKSharedce53ae034203eae7ConditionCmp.x_contains,
                "!endsWith" => AutoSDKSharedce53ae034203eae7ConditionCmp.x_endsWith,
                "!eq" => AutoSDKSharedce53ae034203eae7ConditionCmp.x_eq,
                "!ex" => AutoSDKSharedce53ae034203eae7ConditionCmp.x_ex,
                "!oneOf" => AutoSDKSharedce53ae034203eae7ConditionCmp.x_oneOf,
                "!regex" => AutoSDKSharedce53ae034203eae7ConditionCmp.x_regex,
                "!startsWith" => AutoSDKSharedce53ae034203eae7ConditionCmp.x_startsWith,
                "after" => AutoSDKSharedce53ae034203eae7ConditionCmp.After,
                "before" => AutoSDKSharedce53ae034203eae7ConditionCmp.Before,
                "contains" => AutoSDKSharedce53ae034203eae7ConditionCmp.Contains,
                "containsAllOf" => AutoSDKSharedce53ae034203eae7ConditionCmp.ContainsAllOf,
                "containsAnyOf" => AutoSDKSharedce53ae034203eae7ConditionCmp.ContainsAnyOf,
                "containsNoneOf" => AutoSDKSharedce53ae034203eae7ConditionCmp.ContainsNoneOf,
                "endsWith" => AutoSDKSharedce53ae034203eae7ConditionCmp.EndsWith,
                "eq" => AutoSDKSharedce53ae034203eae7ConditionCmp.Eq,
                "ex" => AutoSDKSharedce53ae034203eae7ConditionCmp.Ex,
                "gt" => AutoSDKSharedce53ae034203eae7ConditionCmp.Gt,
                "gte" => AutoSDKSharedce53ae034203eae7ConditionCmp.Gte,
                "lt" => AutoSDKSharedce53ae034203eae7ConditionCmp.Lt,
                "lte" => AutoSDKSharedce53ae034203eae7ConditionCmp.Lte,
                "oneOf" => AutoSDKSharedce53ae034203eae7ConditionCmp.OneOf,
                "regex" => AutoSDKSharedce53ae034203eae7ConditionCmp.Regex,
                "startsWith" => AutoSDKSharedce53ae034203eae7ConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}