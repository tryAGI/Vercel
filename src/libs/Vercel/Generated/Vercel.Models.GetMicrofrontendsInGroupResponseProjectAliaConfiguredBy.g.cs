
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectAliaConfiguredBy
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
    public static class GetMicrofrontendsInGroupResponseProjectAliaConfiguredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectAliaConfiguredBy value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectAliaConfiguredBy.A => "A",
                GetMicrofrontendsInGroupResponseProjectAliaConfiguredBy.Cname => "CNAME",
                GetMicrofrontendsInGroupResponseProjectAliaConfiguredBy.Dns01 => "dns-01",
                GetMicrofrontendsInGroupResponseProjectAliaConfiguredBy.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectAliaConfiguredBy? ToEnum(string value)
        {
            return value switch
            {
                "A" => GetMicrofrontendsInGroupResponseProjectAliaConfiguredBy.A,
                "CNAME" => GetMicrofrontendsInGroupResponseProjectAliaConfiguredBy.Cname,
                "dns-01" => GetMicrofrontendsInGroupResponseProjectAliaConfiguredBy.Dns01,
                "http" => GetMicrofrontendsInGroupResponseProjectAliaConfiguredBy.Http,
                _ => null,
            };
        }
    }
}