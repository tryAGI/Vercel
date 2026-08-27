
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseAliaConfiguredBy
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
    public static class GetProjectResponseAliaConfiguredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseAliaConfiguredBy value)
        {
            return value switch
            {
                GetProjectResponseAliaConfiguredBy.A => "A",
                GetProjectResponseAliaConfiguredBy.Cname => "CNAME",
                GetProjectResponseAliaConfiguredBy.Dns01 => "dns-01",
                GetProjectResponseAliaConfiguredBy.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseAliaConfiguredBy? ToEnum(string value)
        {
            return value switch
            {
                "A" => GetProjectResponseAliaConfiguredBy.A,
                "CNAME" => GetProjectResponseAliaConfiguredBy.Cname,
                "dns-01" => GetProjectResponseAliaConfiguredBy.Dns01,
                "http" => GetProjectResponseAliaConfiguredBy.Http,
                _ => null,
            };
        }
    }
}