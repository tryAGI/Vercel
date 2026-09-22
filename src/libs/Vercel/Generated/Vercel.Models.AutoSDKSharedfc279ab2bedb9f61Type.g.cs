
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfc279ab2bedb9f61Type
    {
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfc279ab2bedb9f61TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfc279ab2bedb9f61Type value)
        {
            return value switch
            {
                AutoSDKSharedfc279ab2bedb9f61Type.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfc279ab2bedb9f61Type? ToEnum(string value)
        {
            return value switch
            {
                "string" => AutoSDKSharedfc279ab2bedb9f61Type.String,
                _ => null,
            };
        }
    }
}