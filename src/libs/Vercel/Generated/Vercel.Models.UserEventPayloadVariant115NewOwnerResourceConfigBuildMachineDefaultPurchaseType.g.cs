
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultPurchaseType
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
    public static class UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultPurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultPurchaseType value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Enhanced => "enhanced",
                UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Standard => "standard",
                UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultPurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Enhanced,
                "standard" => UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Standard,
                "turbo" => UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Turbo,
                _ => null,
            };
        }
    }
}