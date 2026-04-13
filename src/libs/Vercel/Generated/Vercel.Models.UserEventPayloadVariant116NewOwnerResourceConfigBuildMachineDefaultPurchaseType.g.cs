
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefaultPurchaseType
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
    public static class UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefaultPurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefaultPurchaseType value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Enhanced => "enhanced",
                UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Standard => "standard",
                UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefaultPurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Enhanced,
                "standard" => UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Standard,
                "turbo" => UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Turbo,
                _ => null,
            };
        }
    }
}