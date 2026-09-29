
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f45691814810f14ConditionCmp
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
    public static class AutoSDKShared0f45691814810f14ConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f45691814810f14ConditionCmp value)
        {
            return value switch
            {
                AutoSDKShared0f45691814810f14ConditionCmp.x_contains => "!contains",
                AutoSDKShared0f45691814810f14ConditionCmp.x_endsWith => "!endsWith",
                AutoSDKShared0f45691814810f14ConditionCmp.x_eq => "!eq",
                AutoSDKShared0f45691814810f14ConditionCmp.x_ex => "!ex",
                AutoSDKShared0f45691814810f14ConditionCmp.x_oneOf => "!oneOf",
                AutoSDKShared0f45691814810f14ConditionCmp.x_regex => "!regex",
                AutoSDKShared0f45691814810f14ConditionCmp.x_startsWith => "!startsWith",
                AutoSDKShared0f45691814810f14ConditionCmp.After => "after",
                AutoSDKShared0f45691814810f14ConditionCmp.Before => "before",
                AutoSDKShared0f45691814810f14ConditionCmp.Contains => "contains",
                AutoSDKShared0f45691814810f14ConditionCmp.ContainsAllOf => "containsAllOf",
                AutoSDKShared0f45691814810f14ConditionCmp.ContainsAnyOf => "containsAnyOf",
                AutoSDKShared0f45691814810f14ConditionCmp.ContainsNoneOf => "containsNoneOf",
                AutoSDKShared0f45691814810f14ConditionCmp.EndsWith => "endsWith",
                AutoSDKShared0f45691814810f14ConditionCmp.Eq => "eq",
                AutoSDKShared0f45691814810f14ConditionCmp.Ex => "ex",
                AutoSDKShared0f45691814810f14ConditionCmp.Gt => "gt",
                AutoSDKShared0f45691814810f14ConditionCmp.Gte => "gte",
                AutoSDKShared0f45691814810f14ConditionCmp.Lt => "lt",
                AutoSDKShared0f45691814810f14ConditionCmp.Lte => "lte",
                AutoSDKShared0f45691814810f14ConditionCmp.OneOf => "oneOf",
                AutoSDKShared0f45691814810f14ConditionCmp.Regex => "regex",
                AutoSDKShared0f45691814810f14ConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f45691814810f14ConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => AutoSDKShared0f45691814810f14ConditionCmp.x_contains,
                "!endsWith" => AutoSDKShared0f45691814810f14ConditionCmp.x_endsWith,
                "!eq" => AutoSDKShared0f45691814810f14ConditionCmp.x_eq,
                "!ex" => AutoSDKShared0f45691814810f14ConditionCmp.x_ex,
                "!oneOf" => AutoSDKShared0f45691814810f14ConditionCmp.x_oneOf,
                "!regex" => AutoSDKShared0f45691814810f14ConditionCmp.x_regex,
                "!startsWith" => AutoSDKShared0f45691814810f14ConditionCmp.x_startsWith,
                "after" => AutoSDKShared0f45691814810f14ConditionCmp.After,
                "before" => AutoSDKShared0f45691814810f14ConditionCmp.Before,
                "contains" => AutoSDKShared0f45691814810f14ConditionCmp.Contains,
                "containsAllOf" => AutoSDKShared0f45691814810f14ConditionCmp.ContainsAllOf,
                "containsAnyOf" => AutoSDKShared0f45691814810f14ConditionCmp.ContainsAnyOf,
                "containsNoneOf" => AutoSDKShared0f45691814810f14ConditionCmp.ContainsNoneOf,
                "endsWith" => AutoSDKShared0f45691814810f14ConditionCmp.EndsWith,
                "eq" => AutoSDKShared0f45691814810f14ConditionCmp.Eq,
                "ex" => AutoSDKShared0f45691814810f14ConditionCmp.Ex,
                "gt" => AutoSDKShared0f45691814810f14ConditionCmp.Gt,
                "gte" => AutoSDKShared0f45691814810f14ConditionCmp.Gte,
                "lt" => AutoSDKShared0f45691814810f14ConditionCmp.Lt,
                "lte" => AutoSDKShared0f45691814810f14ConditionCmp.Lte,
                "oneOf" => AutoSDKShared0f45691814810f14ConditionCmp.OneOf,
                "regex" => AutoSDKShared0f45691814810f14ConditionCmp.Regex,
                "startsWith" => AutoSDKShared0f45691814810f14ConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}