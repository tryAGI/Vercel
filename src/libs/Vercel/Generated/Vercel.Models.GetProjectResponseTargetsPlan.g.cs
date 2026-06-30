
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseTargetsPlan
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
    public static class GetProjectResponseTargetsPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTargetsPlan value)
        {
            return value switch
            {
                GetProjectResponseTargetsPlan.Enterprise => "enterprise",
                GetProjectResponseTargetsPlan.Hobby => "hobby",
                GetProjectResponseTargetsPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTargetsPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetProjectResponseTargetsPlan.Enterprise,
                "hobby" => GetProjectResponseTargetsPlan.Hobby,
                "pro" => GetProjectResponseTargetsPlan.Pro,
                _ => null,
            };
        }
    }
}