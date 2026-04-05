
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemAliaConfiguredBy
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
    public static class GetProjectsResponseVariant1ItemAliaConfiguredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemAliaConfiguredBy value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemAliaConfiguredBy.A => "A",
                GetProjectsResponseVariant1ItemAliaConfiguredBy.Cname => "CNAME",
                GetProjectsResponseVariant1ItemAliaConfiguredBy.Dns01 => "dns-01",
                GetProjectsResponseVariant1ItemAliaConfiguredBy.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemAliaConfiguredBy? ToEnum(string value)
        {
            return value switch
            {
                "A" => GetProjectsResponseVariant1ItemAliaConfiguredBy.A,
                "CNAME" => GetProjectsResponseVariant1ItemAliaConfiguredBy.Cname,
                "dns-01" => GetProjectsResponseVariant1ItemAliaConfiguredBy.Dns01,
                "http" => GetProjectsResponseVariant1ItemAliaConfiguredBy.Http,
                _ => null,
            };
        }
    }
}