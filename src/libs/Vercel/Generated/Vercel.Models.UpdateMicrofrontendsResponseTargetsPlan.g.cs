
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseTargetsPlan
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
    public static class UpdateMicrofrontendsResponseTargetsPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseTargetsPlan value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseTargetsPlan.Enterprise => "enterprise",
                UpdateMicrofrontendsResponseTargetsPlan.Hobby => "hobby",
                UpdateMicrofrontendsResponseTargetsPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseTargetsPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UpdateMicrofrontendsResponseTargetsPlan.Enterprise,
                "hobby" => UpdateMicrofrontendsResponseTargetsPlan.Hobby,
                "pro" => UpdateMicrofrontendsResponseTargetsPlan.Pro,
                _ => null,
            };
        }
    }
}