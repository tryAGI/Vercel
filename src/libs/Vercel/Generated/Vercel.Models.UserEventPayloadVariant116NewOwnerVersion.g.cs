
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Northstar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant116NewOwnerVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerVersion value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerVersion.Northstar => "northstar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerVersion? ToEnum(string value)
        {
            return value switch
            {
                "northstar" => UserEventPayloadVariant116NewOwnerVersion.Northstar,
                _ => null,
            };
        }
    }
}