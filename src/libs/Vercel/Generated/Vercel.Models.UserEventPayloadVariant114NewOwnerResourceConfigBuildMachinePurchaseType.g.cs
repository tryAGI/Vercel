
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerResourceConfigBuildMachinePurchaseType
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
    public static class UserEventPayloadVariant114NewOwnerResourceConfigBuildMachinePurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerResourceConfigBuildMachinePurchaseType value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerResourceConfigBuildMachinePurchaseType.Enhanced => "enhanced",
                UserEventPayloadVariant114NewOwnerResourceConfigBuildMachinePurchaseType.Standard => "standard",
                UserEventPayloadVariant114NewOwnerResourceConfigBuildMachinePurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerResourceConfigBuildMachinePurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => UserEventPayloadVariant114NewOwnerResourceConfigBuildMachinePurchaseType.Enhanced,
                "standard" => UserEventPayloadVariant114NewOwnerResourceConfigBuildMachinePurchaseType.Standard,
                "turbo" => UserEventPayloadVariant114NewOwnerResourceConfigBuildMachinePurchaseType.Turbo,
                _ => null,
            };
        }
    }
}