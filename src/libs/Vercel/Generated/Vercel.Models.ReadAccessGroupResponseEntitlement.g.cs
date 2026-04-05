
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReadAccessGroupResponseEntitlement
    {
        /// <summary>
        /// 
        /// </summary>
        V0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReadAccessGroupResponseEntitlementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadAccessGroupResponseEntitlement value)
        {
            return value switch
            {
                ReadAccessGroupResponseEntitlement.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadAccessGroupResponseEntitlement? ToEnum(string value)
        {
            return value switch
            {
                "v0" => ReadAccessGroupResponseEntitlement.V0,
                _ => null,
            };
        }
    }
}