
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAccessGroupResponseEntitlement
    {
        /// <summary>
        /// 
        /// </summary>
        V0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAccessGroupResponseEntitlementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAccessGroupResponseEntitlement value)
        {
            return value switch
            {
                UpdateAccessGroupResponseEntitlement.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAccessGroupResponseEntitlement? ToEnum(string value)
        {
            return value switch
            {
                "v0" => UpdateAccessGroupResponseEntitlement.V0,
                _ => null,
            };
        }
    }
}