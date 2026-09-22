
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedceccd47983fcf9deVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedceccd47983fcf9deVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedceccd47983fcf9deVariant3Type value)
        {
            return value switch
            {
                AutoSDKSharedceccd47983fcf9deVariant3Type.Boolean => "boolean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedceccd47983fcf9deVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AutoSDKSharedceccd47983fcf9deVariant3Type.Boolean,
                _ => null,
            };
        }
    }
}