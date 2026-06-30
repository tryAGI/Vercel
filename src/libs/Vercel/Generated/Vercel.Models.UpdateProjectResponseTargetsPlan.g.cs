
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseTargetsPlan
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
    public static class UpdateProjectResponseTargetsPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseTargetsPlan value)
        {
            return value switch
            {
                UpdateProjectResponseTargetsPlan.Enterprise => "enterprise",
                UpdateProjectResponseTargetsPlan.Hobby => "hobby",
                UpdateProjectResponseTargetsPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseTargetsPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UpdateProjectResponseTargetsPlan.Enterprise,
                "hobby" => UpdateProjectResponseTargetsPlan.Hobby,
                "pro" => UpdateProjectResponseTargetsPlan.Pro,
                _ => null,
            };
        }
    }
}