
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2f24cdccbdde3d24TypeName
    {
        /// <summary>
        ///
        /// </summary>
        Flag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2f24cdccbdde3d24TypeNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2f24cdccbdde3d24TypeName value)
        {
            return value switch
            {
                AutoSDKShared2f24cdccbdde3d24TypeName.Flag => "flag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2f24cdccbdde3d24TypeName? ToEnum(string value)
        {
            return value switch
            {
                "flag" => AutoSDKShared2f24cdccbdde3d24TypeName.Flag,
                _ => null,
            };
        }
    }
}