
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared29b35dda7b3e47c4ConfiguredBy
    {
        /// <summary>
        ///
        /// </summary>
        A,
        /// <summary>
        ///
        /// </summary>
        Cname,
        /// <summary>
        ///
        /// </summary>
        Dns01,
        /// <summary>
        ///
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared29b35dda7b3e47c4ConfiguredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared29b35dda7b3e47c4ConfiguredBy value)
        {
            return value switch
            {
                AutoSDKShared29b35dda7b3e47c4ConfiguredBy.A => "A",
                AutoSDKShared29b35dda7b3e47c4ConfiguredBy.Cname => "CNAME",
                AutoSDKShared29b35dda7b3e47c4ConfiguredBy.Dns01 => "dns-01",
                AutoSDKShared29b35dda7b3e47c4ConfiguredBy.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared29b35dda7b3e47c4ConfiguredBy? ToEnum(string value)
        {
            return value switch
            {
                "A" => AutoSDKShared29b35dda7b3e47c4ConfiguredBy.A,
                "CNAME" => AutoSDKShared29b35dda7b3e47c4ConfiguredBy.Cname,
                "dns-01" => AutoSDKShared29b35dda7b3e47c4ConfiguredBy.Dns01,
                "http" => AutoSDKShared29b35dda7b3e47c4ConfiguredBy.Http,
                _ => null,
            };
        }
    }
}