
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectAliaConfiguredBy
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
    public static class GetProjectsResponseVariant2ProjectAliaConfiguredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectAliaConfiguredBy value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectAliaConfiguredBy.A => "A",
                GetProjectsResponseVariant2ProjectAliaConfiguredBy.Cname => "CNAME",
                GetProjectsResponseVariant2ProjectAliaConfiguredBy.Dns01 => "dns-01",
                GetProjectsResponseVariant2ProjectAliaConfiguredBy.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectAliaConfiguredBy? ToEnum(string value)
        {
            return value switch
            {
                "A" => GetProjectsResponseVariant2ProjectAliaConfiguredBy.A,
                "CNAME" => GetProjectsResponseVariant2ProjectAliaConfiguredBy.Cname,
                "dns-01" => GetProjectsResponseVariant2ProjectAliaConfiguredBy.Dns01,
                "http" => GetProjectsResponseVariant2ProjectAliaConfiguredBy.Http,
                _ => null,
            };
        }
    }
}