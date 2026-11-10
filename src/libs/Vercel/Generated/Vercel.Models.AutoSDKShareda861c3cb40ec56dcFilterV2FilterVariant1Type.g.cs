
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1Type value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1Type.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1Type.Basic,
                _ => null,
            };
        }
    }
}