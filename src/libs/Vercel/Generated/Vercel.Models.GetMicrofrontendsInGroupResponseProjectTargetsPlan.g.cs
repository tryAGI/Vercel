
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectTargetsPlan
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
    public static class GetMicrofrontendsInGroupResponseProjectTargetsPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectTargetsPlan value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectTargetsPlan.Enterprise => "enterprise",
                GetMicrofrontendsInGroupResponseProjectTargetsPlan.Hobby => "hobby",
                GetMicrofrontendsInGroupResponseProjectTargetsPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectTargetsPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetMicrofrontendsInGroupResponseProjectTargetsPlan.Enterprise,
                "hobby" => GetMicrofrontendsInGroupResponseProjectTargetsPlan.Hobby,
                "pro" => GetMicrofrontendsInGroupResponseProjectTargetsPlan.Pro,
                _ => null,
            };
        }
    }
}