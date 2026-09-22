
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0dd077d6df470379Variant18Type
    {
        /// <summary>
        ///
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0dd077d6df470379Variant18TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0dd077d6df470379Variant18Type value)
        {
            return value switch
            {
                AutoSDKShared0dd077d6df470379Variant18Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0dd077d6df470379Variant18Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => AutoSDKShared0dd077d6df470379Variant18Type.Vercel,
                _ => null,
            };
        }
    }
}