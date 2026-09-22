
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0dd077d6df470379Variant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0dd077d6df470379Variant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0dd077d6df470379Variant1Type value)
        {
            return value switch
            {
                AutoSDKShared0dd077d6df470379Variant1Type.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0dd077d6df470379Variant1Type? ToEnum(string value)
        {
            return value switch
            {
                "github" => AutoSDKShared0dd077d6df470379Variant1Type.Github,
                _ => null,
            };
        }
    }
}