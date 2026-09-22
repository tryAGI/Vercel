
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9e46425f35715a0ConditionCmp
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
    public static class AutoSDKSharedd9e46425f35715a0ConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9e46425f35715a0ConditionCmp value)
        {
            return value switch
            {
                AutoSDKSharedd9e46425f35715a0ConditionCmp.x_contains => "!contains",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.x_endsWith => "!endsWith",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.x_eq => "!eq",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.x_ex => "!ex",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.x_oneOf => "!oneOf",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.x_regex => "!regex",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.x_startsWith => "!startsWith",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.After => "after",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.Before => "before",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.Contains => "contains",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.ContainsAllOf => "containsAllOf",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.ContainsAnyOf => "containsAnyOf",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.ContainsNoneOf => "containsNoneOf",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.EndsWith => "endsWith",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.Eq => "eq",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.Ex => "ex",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.Gt => "gt",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.Gte => "gte",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.Lt => "lt",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.Lte => "lte",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.OneOf => "oneOf",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.Regex => "regex",
                AutoSDKSharedd9e46425f35715a0ConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9e46425f35715a0ConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => AutoSDKSharedd9e46425f35715a0ConditionCmp.x_contains,
                "!endsWith" => AutoSDKSharedd9e46425f35715a0ConditionCmp.x_endsWith,
                "!eq" => AutoSDKSharedd9e46425f35715a0ConditionCmp.x_eq,
                "!ex" => AutoSDKSharedd9e46425f35715a0ConditionCmp.x_ex,
                "!oneOf" => AutoSDKSharedd9e46425f35715a0ConditionCmp.x_oneOf,
                "!regex" => AutoSDKSharedd9e46425f35715a0ConditionCmp.x_regex,
                "!startsWith" => AutoSDKSharedd9e46425f35715a0ConditionCmp.x_startsWith,
                "after" => AutoSDKSharedd9e46425f35715a0ConditionCmp.After,
                "before" => AutoSDKSharedd9e46425f35715a0ConditionCmp.Before,
                "contains" => AutoSDKSharedd9e46425f35715a0ConditionCmp.Contains,
                "containsAllOf" => AutoSDKSharedd9e46425f35715a0ConditionCmp.ContainsAllOf,
                "containsAnyOf" => AutoSDKSharedd9e46425f35715a0ConditionCmp.ContainsAnyOf,
                "containsNoneOf" => AutoSDKSharedd9e46425f35715a0ConditionCmp.ContainsNoneOf,
                "endsWith" => AutoSDKSharedd9e46425f35715a0ConditionCmp.EndsWith,
                "eq" => AutoSDKSharedd9e46425f35715a0ConditionCmp.Eq,
                "ex" => AutoSDKSharedd9e46425f35715a0ConditionCmp.Ex,
                "gt" => AutoSDKSharedd9e46425f35715a0ConditionCmp.Gt,
                "gte" => AutoSDKSharedd9e46425f35715a0ConditionCmp.Gte,
                "lt" => AutoSDKSharedd9e46425f35715a0ConditionCmp.Lt,
                "lte" => AutoSDKSharedd9e46425f35715a0ConditionCmp.Lte,
                "oneOf" => AutoSDKSharedd9e46425f35715a0ConditionCmp.OneOf,
                "regex" => AutoSDKSharedd9e46425f35715a0ConditionCmp.Regex,
                "startsWith" => AutoSDKSharedd9e46425f35715a0ConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}