
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared04b58f4753dd761fConditionCmp
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
    public static class AutoSDKShared04b58f4753dd761fConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared04b58f4753dd761fConditionCmp value)
        {
            return value switch
            {
                AutoSDKShared04b58f4753dd761fConditionCmp.x_contains => "!contains",
                AutoSDKShared04b58f4753dd761fConditionCmp.x_endsWith => "!endsWith",
                AutoSDKShared04b58f4753dd761fConditionCmp.x_eq => "!eq",
                AutoSDKShared04b58f4753dd761fConditionCmp.x_ex => "!ex",
                AutoSDKShared04b58f4753dd761fConditionCmp.x_oneOf => "!oneOf",
                AutoSDKShared04b58f4753dd761fConditionCmp.x_regex => "!regex",
                AutoSDKShared04b58f4753dd761fConditionCmp.x_startsWith => "!startsWith",
                AutoSDKShared04b58f4753dd761fConditionCmp.After => "after",
                AutoSDKShared04b58f4753dd761fConditionCmp.Before => "before",
                AutoSDKShared04b58f4753dd761fConditionCmp.Contains => "contains",
                AutoSDKShared04b58f4753dd761fConditionCmp.ContainsAllOf => "containsAllOf",
                AutoSDKShared04b58f4753dd761fConditionCmp.ContainsAnyOf => "containsAnyOf",
                AutoSDKShared04b58f4753dd761fConditionCmp.ContainsNoneOf => "containsNoneOf",
                AutoSDKShared04b58f4753dd761fConditionCmp.EndsWith => "endsWith",
                AutoSDKShared04b58f4753dd761fConditionCmp.Eq => "eq",
                AutoSDKShared04b58f4753dd761fConditionCmp.Ex => "ex",
                AutoSDKShared04b58f4753dd761fConditionCmp.Gt => "gt",
                AutoSDKShared04b58f4753dd761fConditionCmp.Gte => "gte",
                AutoSDKShared04b58f4753dd761fConditionCmp.Lt => "lt",
                AutoSDKShared04b58f4753dd761fConditionCmp.Lte => "lte",
                AutoSDKShared04b58f4753dd761fConditionCmp.OneOf => "oneOf",
                AutoSDKShared04b58f4753dd761fConditionCmp.Regex => "regex",
                AutoSDKShared04b58f4753dd761fConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared04b58f4753dd761fConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => AutoSDKShared04b58f4753dd761fConditionCmp.x_contains,
                "!endsWith" => AutoSDKShared04b58f4753dd761fConditionCmp.x_endsWith,
                "!eq" => AutoSDKShared04b58f4753dd761fConditionCmp.x_eq,
                "!ex" => AutoSDKShared04b58f4753dd761fConditionCmp.x_ex,
                "!oneOf" => AutoSDKShared04b58f4753dd761fConditionCmp.x_oneOf,
                "!regex" => AutoSDKShared04b58f4753dd761fConditionCmp.x_regex,
                "!startsWith" => AutoSDKShared04b58f4753dd761fConditionCmp.x_startsWith,
                "after" => AutoSDKShared04b58f4753dd761fConditionCmp.After,
                "before" => AutoSDKShared04b58f4753dd761fConditionCmp.Before,
                "contains" => AutoSDKShared04b58f4753dd761fConditionCmp.Contains,
                "containsAllOf" => AutoSDKShared04b58f4753dd761fConditionCmp.ContainsAllOf,
                "containsAnyOf" => AutoSDKShared04b58f4753dd761fConditionCmp.ContainsAnyOf,
                "containsNoneOf" => AutoSDKShared04b58f4753dd761fConditionCmp.ContainsNoneOf,
                "endsWith" => AutoSDKShared04b58f4753dd761fConditionCmp.EndsWith,
                "eq" => AutoSDKShared04b58f4753dd761fConditionCmp.Eq,
                "ex" => AutoSDKShared04b58f4753dd761fConditionCmp.Ex,
                "gt" => AutoSDKShared04b58f4753dd761fConditionCmp.Gt,
                "gte" => AutoSDKShared04b58f4753dd761fConditionCmp.Gte,
                "lt" => AutoSDKShared04b58f4753dd761fConditionCmp.Lt,
                "lte" => AutoSDKShared04b58f4753dd761fConditionCmp.Lte,
                "oneOf" => AutoSDKShared04b58f4753dd761fConditionCmp.OneOf,
                "regex" => AutoSDKShared04b58f4753dd761fConditionCmp.Regex,
                "startsWith" => AutoSDKShared04b58f4753dd761fConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}