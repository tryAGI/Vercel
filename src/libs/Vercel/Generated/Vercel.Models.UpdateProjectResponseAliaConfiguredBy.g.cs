
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseAliaConfiguredBy
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
    public static class UpdateProjectResponseAliaConfiguredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseAliaConfiguredBy value)
        {
            return value switch
            {
                UpdateProjectResponseAliaConfiguredBy.A => "A",
                UpdateProjectResponseAliaConfiguredBy.Cname => "CNAME",
                UpdateProjectResponseAliaConfiguredBy.Dns01 => "dns-01",
                UpdateProjectResponseAliaConfiguredBy.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseAliaConfiguredBy? ToEnum(string value)
        {
            return value switch
            {
                "A" => UpdateProjectResponseAliaConfiguredBy.A,
                "CNAME" => UpdateProjectResponseAliaConfiguredBy.Cname,
                "dns-01" => UpdateProjectResponseAliaConfiguredBy.Dns01,
                "http" => UpdateProjectResponseAliaConfiguredBy.Http,
                _ => null,
            };
        }
    }
}