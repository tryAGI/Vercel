
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectAliaConfiguredBy
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
    public static class GetProjectsResponseVariant3ProjectAliaConfiguredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectAliaConfiguredBy value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectAliaConfiguredBy.A => "A",
                GetProjectsResponseVariant3ProjectAliaConfiguredBy.Cname => "CNAME",
                GetProjectsResponseVariant3ProjectAliaConfiguredBy.Dns01 => "dns-01",
                GetProjectsResponseVariant3ProjectAliaConfiguredBy.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectAliaConfiguredBy? ToEnum(string value)
        {
            return value switch
            {
                "A" => GetProjectsResponseVariant3ProjectAliaConfiguredBy.A,
                "CNAME" => GetProjectsResponseVariant3ProjectAliaConfiguredBy.Cname,
                "dns-01" => GetProjectsResponseVariant3ProjectAliaConfiguredBy.Dns01,
                "http" => GetProjectsResponseVariant3ProjectAliaConfiguredBy.Http,
                _ => null,
            };
        }
    }
}