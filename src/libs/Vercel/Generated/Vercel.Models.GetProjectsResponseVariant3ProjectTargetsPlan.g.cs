
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectTargetsPlan
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
    public static class GetProjectsResponseVariant3ProjectTargetsPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectTargetsPlan value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectTargetsPlan.Enterprise => "enterprise",
                GetProjectsResponseVariant3ProjectTargetsPlan.Hobby => "hobby",
                GetProjectsResponseVariant3ProjectTargetsPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectTargetsPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetProjectsResponseVariant3ProjectTargetsPlan.Enterprise,
                "hobby" => GetProjectsResponseVariant3ProjectTargetsPlan.Hobby,
                "pro" => GetProjectsResponseVariant3ProjectTargetsPlan.Pro,
                _ => null,
            };
        }
    }
}