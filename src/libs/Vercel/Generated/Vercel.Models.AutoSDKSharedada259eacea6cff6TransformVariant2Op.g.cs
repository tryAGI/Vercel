
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedada259eacea6cff6TransformVariant2Op
    {
        /// <summary>
        ///
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedada259eacea6cff6TransformVariant2OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedada259eacea6cff6TransformVariant2Op value)
        {
            return value switch
            {
                AutoSDKSharedada259eacea6cff6TransformVariant2Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedada259eacea6cff6TransformVariant2Op? ToEnum(string value)
        {
            return value switch
            {
                "set" => AutoSDKSharedada259eacea6cff6TransformVariant2Op.Set,
                _ => null,
            };
        }
    }
}