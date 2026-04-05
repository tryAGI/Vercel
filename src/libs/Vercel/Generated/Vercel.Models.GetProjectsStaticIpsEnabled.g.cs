
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Filter results by projects with Static IPs enabled<br/>
    /// Example: 1
    /// </summary>
    public enum GetProjectsStaticIpsEnabled
    {
        /// <summary>
        /// 
        /// </summary>
        x0,
        /// <summary>
        /// 
        /// </summary>
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsStaticIpsEnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsStaticIpsEnabled value)
        {
            return value switch
            {
                GetProjectsStaticIpsEnabled.x0 => "0",
                GetProjectsStaticIpsEnabled.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsStaticIpsEnabled? ToEnum(string value)
        {
            return value switch
            {
                "0" => GetProjectsStaticIpsEnabled.x0,
                "1" => GetProjectsStaticIpsEnabled.x1,
                _ => null,
            };
        }
    }
}