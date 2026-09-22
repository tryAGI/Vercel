
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0dd077d6df470379Variant16Type
    {
        /// <summary>
        ///
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0dd077d6df470379Variant16TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0dd077d6df470379Variant16Type value)
        {
            return value switch
            {
                AutoSDKShared0dd077d6df470379Variant16Type.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0dd077d6df470379Variant16Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => AutoSDKShared0dd077d6df470379Variant16Type.Gitlab,
                _ => null,
            };
        }
    }
}