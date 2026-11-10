
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2ManagedBy
    {
        /// <summary>
        ///
        /// </summary>
        Drain,
        /// <summary>
        ///
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2ManagedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2ManagedBy value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2ManagedBy.Drain => "drain",
                AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2ManagedBy.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2ManagedBy? ToEnum(string value)
        {
            return value switch
            {
                "drain" => AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2ManagedBy.Drain,
                "integration" => AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2ManagedBy.Integration,
                _ => null,
            };
        }
    }
}