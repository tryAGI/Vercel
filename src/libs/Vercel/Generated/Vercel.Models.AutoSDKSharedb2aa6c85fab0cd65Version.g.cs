
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The version of the microfrontends config schema.
    /// </summary>
    public enum AutoSDKSharedb2aa6c85fab0cd65Version
    {
        /// <summary>
        ///
        /// </summary>
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedb2aa6c85fab0cd65VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb2aa6c85fab0cd65Version value)
        {
            return value switch
            {
                AutoSDKSharedb2aa6c85fab0cd65Version.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb2aa6c85fab0cd65Version? ToEnum(string value)
        {
            return value switch
            {
                "1" => AutoSDKSharedb2aa6c85fab0cd65Version.x1,
                _ => null,
            };
        }
    }
}