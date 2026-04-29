
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Northstar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant122NewOwnerVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerVersion value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerVersion.Northstar => "northstar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerVersion? ToEnum(string value)
        {
            return value switch
            {
                "northstar" => UserEventPayloadVariant122NewOwnerVersion.Northstar,
                _ => null,
            };
        }
    }
}