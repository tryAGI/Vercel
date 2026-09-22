
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0dd077d6df470379Variant14Type
    {
        /// <summary>
        ///
        /// </summary>
        GithubCustomHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0dd077d6df470379Variant14TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0dd077d6df470379Variant14Type value)
        {
            return value switch
            {
                AutoSDKShared0dd077d6df470379Variant14Type.GithubCustomHost => "github-custom-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0dd077d6df470379Variant14Type? ToEnum(string value)
        {
            return value switch
            {
                "github-custom-host" => AutoSDKShared0dd077d6df470379Variant14Type.GithubCustomHost,
                _ => null,
            };
        }
    }
}