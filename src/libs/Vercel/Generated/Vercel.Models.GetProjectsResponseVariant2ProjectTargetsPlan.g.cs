
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectTargetsPlan
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
    public static class GetProjectsResponseVariant2ProjectTargetsPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectTargetsPlan value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectTargetsPlan.Enterprise => "enterprise",
                GetProjectsResponseVariant2ProjectTargetsPlan.Hobby => "hobby",
                GetProjectsResponseVariant2ProjectTargetsPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectTargetsPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetProjectsResponseVariant2ProjectTargetsPlan.Enterprise,
                "hobby" => GetProjectsResponseVariant2ProjectTargetsPlan.Hobby,
                "pro" => GetProjectsResponseVariant2ProjectTargetsPlan.Pro,
                _ => null,
            };
        }
    }
}