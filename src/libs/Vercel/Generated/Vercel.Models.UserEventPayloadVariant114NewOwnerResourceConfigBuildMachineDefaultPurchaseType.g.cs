
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefaultPurchaseType
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
    public static class UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefaultPurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefaultPurchaseType value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Enhanced => "enhanced",
                UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Standard => "standard",
                UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefaultPurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Enhanced,
                "standard" => UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Standard,
                "turbo" => UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefaultPurchaseType.Turbo,
                _ => null,
            };
        }
    }
}