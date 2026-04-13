
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerResourceConfigBuildMachinePurchaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant116NewOwnerResourceConfigBuildMachinePurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerResourceConfigBuildMachinePurchaseType value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerResourceConfigBuildMachinePurchaseType.Enhanced => "enhanced",
                UserEventPayloadVariant116NewOwnerResourceConfigBuildMachinePurchaseType.Standard => "standard",
                UserEventPayloadVariant116NewOwnerResourceConfigBuildMachinePurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerResourceConfigBuildMachinePurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => UserEventPayloadVariant116NewOwnerResourceConfigBuildMachinePurchaseType.Enhanced,
                "standard" => UserEventPayloadVariant116NewOwnerResourceConfigBuildMachinePurchaseType.Standard,
                "turbo" => UserEventPayloadVariant116NewOwnerResourceConfigBuildMachinePurchaseType.Turbo,
                _ => null,
            };
        }
    }
}