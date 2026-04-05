
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAccessGroupResponseEntitlement
    {
        /// <summary>
        /// 
        /// </summary>
        V0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAccessGroupResponseEntitlementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAccessGroupResponseEntitlement value)
        {
            return value switch
            {
                CreateAccessGroupResponseEntitlement.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAccessGroupResponseEntitlement? ToEnum(string value)
        {
            return value switch
            {
                "v0" => CreateAccessGroupResponseEntitlement.V0,
                _ => null,
            };
        }
    }
}