
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemTargetsPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Hobby,
        /// <summary>
        /// 
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemTargetsPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemTargetsPlan value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemTargetsPlan.Enterprise => "enterprise",
                GetProjectsResponseVariant1ItemTargetsPlan.Hobby => "hobby",
                GetProjectsResponseVariant1ItemTargetsPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemTargetsPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetProjectsResponseVariant1ItemTargetsPlan.Enterprise,
                "hobby" => GetProjectsResponseVariant1ItemTargetsPlan.Hobby,
                "pro" => GetProjectsResponseVariant1ItemTargetsPlan.Pro,
                _ => null,
            };
        }
    }
}