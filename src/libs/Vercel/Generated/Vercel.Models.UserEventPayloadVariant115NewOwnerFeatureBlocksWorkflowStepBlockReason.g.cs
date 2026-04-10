
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerFeatureBlocksWorkflowStepBlockReason
    {
        /// <summary>
        /// 
        /// </summary>
        AdminOverride,
        /// <summary>
        /// 
        /// </summary>
        HardBlocked,
        /// <summary>
        /// 
        /// </summary>
        LimitsExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant115NewOwnerFeatureBlocksWorkflowStepBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerFeatureBlocksWorkflowStepBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerFeatureBlocksWorkflowStepBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant115NewOwnerFeatureBlocksWorkflowStepBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant115NewOwnerFeatureBlocksWorkflowStepBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerFeatureBlocksWorkflowStepBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant115NewOwnerFeatureBlocksWorkflowStepBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant115NewOwnerFeatureBlocksWorkflowStepBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant115NewOwnerFeatureBlocksWorkflowStepBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}