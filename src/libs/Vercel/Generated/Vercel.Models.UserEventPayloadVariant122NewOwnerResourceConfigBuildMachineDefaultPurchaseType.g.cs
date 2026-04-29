
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefaultPurchaseType
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
    public static class UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefaultPurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefaultPurchaseType value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Enhanced => "enhanced",
                UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Standard => "standard",
                UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefaultPurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Enhanced,
                "standard" => UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Standard,
                "turbo" => UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Turbo,
                _ => null,
            };
        }
    }
}