
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0Status
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
        /// <summary>
        ///
        /// </summary>
        Errored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared383028c008cc4ae0StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0Status value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0Status.Disabled => "disabled",
                AutoSDKShared383028c008cc4ae0Status.Enabled => "enabled",
                AutoSDKShared383028c008cc4ae0Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKShared383028c008cc4ae0Status.Disabled,
                "enabled" => AutoSDKShared383028c008cc4ae0Status.Enabled,
                "errored" => AutoSDKShared383028c008cc4ae0Status.Errored,
                _ => null,
            };
        }
    }
}