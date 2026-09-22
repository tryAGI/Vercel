
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7882ff81487eef12AffinityMode
    {
        /// <summary>
        ///
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared7882ff81487eef12AffinityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7882ff81487eef12AffinityMode value)
        {
            return value switch
            {
                AutoSDKShared7882ff81487eef12AffinityMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7882ff81487eef12AffinityMode? ToEnum(string value)
        {
            return value switch
            {
                "strict" => AutoSDKShared7882ff81487eef12AffinityMode.Strict,
                _ => null,
            };
        }
    }
}