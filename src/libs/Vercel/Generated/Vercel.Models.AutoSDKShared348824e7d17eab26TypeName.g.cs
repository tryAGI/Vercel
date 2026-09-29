
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared348824e7d17eab26TypeName
    {
        /// <summary>
        ///
        /// </summary>
        Flag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared348824e7d17eab26TypeNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared348824e7d17eab26TypeName value)
        {
            return value switch
            {
                AutoSDKShared348824e7d17eab26TypeName.Flag => "flag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared348824e7d17eab26TypeName? ToEnum(string value)
        {
            return value switch
            {
                "flag" => AutoSDKShared348824e7d17eab26TypeName.Flag,
                _ => null,
            };
        }
    }
}