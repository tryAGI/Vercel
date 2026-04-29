
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerResourceConfigBuildMachinePurchaseType
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
    public static class UserEventPayloadVariant122NewOwnerResourceConfigBuildMachinePurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerResourceConfigBuildMachinePurchaseType value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerResourceConfigBuildMachinePurchaseType.Enhanced => "enhanced",
                UserEventPayloadVariant122NewOwnerResourceConfigBuildMachinePurchaseType.Standard => "standard",
                UserEventPayloadVariant122NewOwnerResourceConfigBuildMachinePurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerResourceConfigBuildMachinePurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => UserEventPayloadVariant122NewOwnerResourceConfigBuildMachinePurchaseType.Enhanced,
                "standard" => UserEventPayloadVariant122NewOwnerResourceConfigBuildMachinePurchaseType.Standard,
                "turbo" => UserEventPayloadVariant122NewOwnerResourceConfigBuildMachinePurchaseType.Turbo,
                _ => null,
            };
        }
    }
}