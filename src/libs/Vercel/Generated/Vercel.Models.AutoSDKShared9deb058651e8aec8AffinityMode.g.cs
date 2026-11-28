
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9deb058651e8aec8AffinityMode
    {
        /// <summary>
        ///
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9deb058651e8aec8AffinityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9deb058651e8aec8AffinityMode value)
        {
            return value switch
            {
                AutoSDKShared9deb058651e8aec8AffinityMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9deb058651e8aec8AffinityMode? ToEnum(string value)
        {
            return value switch
            {
                "strict" => AutoSDKShared9deb058651e8aec8AffinityMode.Strict,
                _ => null,
            };
        }
    }
}