
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbd3f01cc8f6abd3dVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        AliasAssigned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedbd3f01cc8f6abd3dVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbd3f01cc8f6abd3dVariant3Type value)
        {
            return value switch
            {
                AutoSDKSharedbd3f01cc8f6abd3dVariant3Type.AliasAssigned => "alias-assigned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbd3f01cc8f6abd3dVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "alias-assigned" => AutoSDKSharedbd3f01cc8f6abd3dVariant3Type.AliasAssigned,
                _ => null,
            };
        }
    }
}