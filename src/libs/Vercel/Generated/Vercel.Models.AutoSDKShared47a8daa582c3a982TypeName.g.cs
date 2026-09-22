
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared47a8daa582c3a982TypeName
    {
        /// <summary>
        ///
        /// </summary>
        Flag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared47a8daa582c3a982TypeNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared47a8daa582c3a982TypeName value)
        {
            return value switch
            {
                AutoSDKShared47a8daa582c3a982TypeName.Flag => "flag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared47a8daa582c3a982TypeName? ToEnum(string value)
        {
            return value switch
            {
                "flag" => AutoSDKShared47a8daa582c3a982TypeName.Flag,
                _ => null,
            };
        }
    }
}