
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede7fa7575dde4720dConditionCmp
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
    public static class AutoSDKSharede7fa7575dde4720dConditionCmpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede7fa7575dde4720dConditionCmp value)
        {
            return value switch
            {
                AutoSDKSharede7fa7575dde4720dConditionCmp.x_contains => "!contains",
                AutoSDKSharede7fa7575dde4720dConditionCmp.x_endsWith => "!endsWith",
                AutoSDKSharede7fa7575dde4720dConditionCmp.x_eq => "!eq",
                AutoSDKSharede7fa7575dde4720dConditionCmp.x_ex => "!ex",
                AutoSDKSharede7fa7575dde4720dConditionCmp.x_oneOf => "!oneOf",
                AutoSDKSharede7fa7575dde4720dConditionCmp.x_regex => "!regex",
                AutoSDKSharede7fa7575dde4720dConditionCmp.x_startsWith => "!startsWith",
                AutoSDKSharede7fa7575dde4720dConditionCmp.After => "after",
                AutoSDKSharede7fa7575dde4720dConditionCmp.Before => "before",
                AutoSDKSharede7fa7575dde4720dConditionCmp.Contains => "contains",
                AutoSDKSharede7fa7575dde4720dConditionCmp.ContainsAllOf => "containsAllOf",
                AutoSDKSharede7fa7575dde4720dConditionCmp.ContainsAnyOf => "containsAnyOf",
                AutoSDKSharede7fa7575dde4720dConditionCmp.ContainsNoneOf => "containsNoneOf",
                AutoSDKSharede7fa7575dde4720dConditionCmp.EndsWith => "endsWith",
                AutoSDKSharede7fa7575dde4720dConditionCmp.Eq => "eq",
                AutoSDKSharede7fa7575dde4720dConditionCmp.Ex => "ex",
                AutoSDKSharede7fa7575dde4720dConditionCmp.Gt => "gt",
                AutoSDKSharede7fa7575dde4720dConditionCmp.Gte => "gte",
                AutoSDKSharede7fa7575dde4720dConditionCmp.Lt => "lt",
                AutoSDKSharede7fa7575dde4720dConditionCmp.Lte => "lte",
                AutoSDKSharede7fa7575dde4720dConditionCmp.OneOf => "oneOf",
                AutoSDKSharede7fa7575dde4720dConditionCmp.Regex => "regex",
                AutoSDKSharede7fa7575dde4720dConditionCmp.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede7fa7575dde4720dConditionCmp? ToEnum(string value)
        {
            return value switch
            {
                "!contains" => AutoSDKSharede7fa7575dde4720dConditionCmp.x_contains,
                "!endsWith" => AutoSDKSharede7fa7575dde4720dConditionCmp.x_endsWith,
                "!eq" => AutoSDKSharede7fa7575dde4720dConditionCmp.x_eq,
                "!ex" => AutoSDKSharede7fa7575dde4720dConditionCmp.x_ex,
                "!oneOf" => AutoSDKSharede7fa7575dde4720dConditionCmp.x_oneOf,
                "!regex" => AutoSDKSharede7fa7575dde4720dConditionCmp.x_regex,
                "!startsWith" => AutoSDKSharede7fa7575dde4720dConditionCmp.x_startsWith,
                "after" => AutoSDKSharede7fa7575dde4720dConditionCmp.After,
                "before" => AutoSDKSharede7fa7575dde4720dConditionCmp.Before,
                "contains" => AutoSDKSharede7fa7575dde4720dConditionCmp.Contains,
                "containsAllOf" => AutoSDKSharede7fa7575dde4720dConditionCmp.ContainsAllOf,
                "containsAnyOf" => AutoSDKSharede7fa7575dde4720dConditionCmp.ContainsAnyOf,
                "containsNoneOf" => AutoSDKSharede7fa7575dde4720dConditionCmp.ContainsNoneOf,
                "endsWith" => AutoSDKSharede7fa7575dde4720dConditionCmp.EndsWith,
                "eq" => AutoSDKSharede7fa7575dde4720dConditionCmp.Eq,
                "ex" => AutoSDKSharede7fa7575dde4720dConditionCmp.Ex,
                "gt" => AutoSDKSharede7fa7575dde4720dConditionCmp.Gt,
                "gte" => AutoSDKSharede7fa7575dde4720dConditionCmp.Gte,
                "lt" => AutoSDKSharede7fa7575dde4720dConditionCmp.Lt,
                "lte" => AutoSDKSharede7fa7575dde4720dConditionCmp.Lte,
                "oneOf" => AutoSDKSharede7fa7575dde4720dConditionCmp.OneOf,
                "regex" => AutoSDKSharede7fa7575dde4720dConditionCmp.Regex,
                "startsWith" => AutoSDKSharede7fa7575dde4720dConditionCmp.StartsWith,
                _ => null,
            };
        }
    }
}