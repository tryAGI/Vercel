
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerResourceConfigBuildMachinePurchaseType
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
    public static class UserEventPayloadVariant115NewOwnerResourceConfigBuildMachinePurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerResourceConfigBuildMachinePurchaseType value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerResourceConfigBuildMachinePurchaseType.Enhanced => "enhanced",
                UserEventPayloadVariant115NewOwnerResourceConfigBuildMachinePurchaseType.Standard => "standard",
                UserEventPayloadVariant115NewOwnerResourceConfigBuildMachinePurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerResourceConfigBuildMachinePurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => UserEventPayloadVariant115NewOwnerResourceConfigBuildMachinePurchaseType.Enhanced,
                "standard" => UserEventPayloadVariant115NewOwnerResourceConfigBuildMachinePurchaseType.Standard,
                "turbo" => UserEventPayloadVariant115NewOwnerResourceConfigBuildMachinePurchaseType.Turbo,
                _ => null,
            };
        }
    }
}