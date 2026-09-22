
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbc14f6f0dbfaa660ConfiguredBy
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
    public static class AutoSDKSharedbc14f6f0dbfaa660ConfiguredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbc14f6f0dbfaa660ConfiguredBy value)
        {
            return value switch
            {
                AutoSDKSharedbc14f6f0dbfaa660ConfiguredBy.A => "A",
                AutoSDKSharedbc14f6f0dbfaa660ConfiguredBy.Cname => "CNAME",
                AutoSDKSharedbc14f6f0dbfaa660ConfiguredBy.Dns01 => "dns-01",
                AutoSDKSharedbc14f6f0dbfaa660ConfiguredBy.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbc14f6f0dbfaa660ConfiguredBy? ToEnum(string value)
        {
            return value switch
            {
                "A" => AutoSDKSharedbc14f6f0dbfaa660ConfiguredBy.A,
                "CNAME" => AutoSDKSharedbc14f6f0dbfaa660ConfiguredBy.Cname,
                "dns-01" => AutoSDKSharedbc14f6f0dbfaa660ConfiguredBy.Dns01,
                "http" => AutoSDKSharedbc14f6f0dbfaa660ConfiguredBy.Http,
                _ => null,
            };
        }
    }
}