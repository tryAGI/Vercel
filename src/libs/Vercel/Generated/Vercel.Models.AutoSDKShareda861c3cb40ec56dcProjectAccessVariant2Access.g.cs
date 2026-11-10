
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2Access
    {
        /// <summary>
        ///
        /// </summary>
        Some,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2Access value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2Access.Some => "some",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2Access? ToEnum(string value)
        {
            return value switch
            {
                "some" => AutoSDKShareda861c3cb40ec56dcProjectAccessVariant2Access.Some,
                _ => null,
            };
        }
    }
}