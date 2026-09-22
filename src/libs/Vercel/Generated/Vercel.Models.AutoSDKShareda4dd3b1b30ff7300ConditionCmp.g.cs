
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda4dd3b1b30ff7300ConditionCmp
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
    public static class AutoSDKShareda4dd3b1b30ff7300ConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda4dd3b1b30ff7300ConditionCmp value)
        {
            return value switch
            {
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.x_contains => "!contains",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.x_endsWith => "!endsWith",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.x_eq => "!eq",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.x_ex => "!ex",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.x_oneOf => "!oneOf",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.x_regex => "!regex",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.x_startsWith => "!startsWith",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.After => "after",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Before => "before",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Contains => "contains",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.ContainsAllOf => "containsAllOf",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.ContainsAnyOf => "containsAnyOf",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.ContainsNoneOf => "containsNoneOf",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.EndsWith => "endsWith",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Eq => "eq",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Ex => "ex",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Gt => "gt",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Gte => "gte",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Lt => "lt",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Lte => "lte",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.OneOf => "oneOf",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Regex => "regex",
                AutoSDKShareda4dd3b1b30ff7300ConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda4dd3b1b30ff7300ConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.x_contains,
                "!endsWith" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.x_endsWith,
                "!eq" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.x_eq,
                "!ex" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.x_ex,
                "!oneOf" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.x_oneOf,
                "!regex" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.x_regex,
                "!startsWith" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.x_startsWith,
                "after" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.After,
                "before" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Before,
                "contains" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Contains,
                "containsAllOf" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.ContainsAllOf,
                "containsAnyOf" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.ContainsAnyOf,
                "containsNoneOf" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.ContainsNoneOf,
                "endsWith" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.EndsWith,
                "eq" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Eq,
                "ex" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Ex,
                "gt" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Gt,
                "gte" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Gte,
                "lt" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Lt,
                "lte" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Lte,
                "oneOf" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.OneOf,
                "regex" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.Regex,
                "startsWith" => AutoSDKShareda4dd3b1b30ff7300ConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}