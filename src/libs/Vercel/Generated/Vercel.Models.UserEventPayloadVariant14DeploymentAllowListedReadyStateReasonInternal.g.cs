
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A narrowed subset of the deployment's `readyStateReasonInternal` — only values in the public allowlist are permitted here. Callers should run their raw reason through `toAllowListedReadyStateReasonInternal` from `@api/events` before assigning. This keeps abuse / moderation / admin reasons out of the public activity log.
    /// </summary>
    public enum UserEventPayloadVariant14DeploymentAllowListedReadyStateReasonInternal
    {
        /// <summary>
        /// 
        /// </summary>
        EarlyIgnoreStep,
        /// <summary>
        /// 
        /// </summary>
        IgnoreStep,
        /// <summary>
        /// 
        /// </summary>
        NamespacePruned,
        /// <summary>
        /// 
        /// </summary>
        UnaffectedProject,
        /// <summary>
        /// 
        /// </summary>
        UnverifiedCommit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant14DeploymentAllowListedReadyStateReasonInternalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant14DeploymentAllowListedReadyStateReasonInternal value)
        {
            return value switch
            {
                UserEventPayloadVariant14DeploymentAllowListedReadyStateReasonInternal.EarlyIgnoreStep => "EARLY_IGNORE_STEP",
                UserEventPayloadVariant14DeploymentAllowListedReadyStateReasonInternal.IgnoreStep => "IGNORE_STEP",
                UserEventPayloadVariant14DeploymentAllowListedReadyStateReasonInternal.NamespacePruned => "NAMESPACE_PRUNED",
                UserEventPayloadVariant14DeploymentAllowListedReadyStateReasonInternal.UnaffectedProject => "UNAFFECTED_PROJECT",
                UserEventPayloadVariant14DeploymentAllowListedReadyStateReasonInternal.UnverifiedCommit => "UNVERIFIED_COMMIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant14DeploymentAllowListedReadyStateReasonInternal? ToEnum(string value)
        {
            return value switch
            {
                "EARLY_IGNORE_STEP" => UserEventPayloadVariant14DeploymentAllowListedReadyStateReasonInternal.EarlyIgnoreStep,
                "IGNORE_STEP" => UserEventPayloadVariant14DeploymentAllowListedReadyStateReasonInternal.IgnoreStep,
                "NAMESPACE_PRUNED" => UserEventPayloadVariant14DeploymentAllowListedReadyStateReasonInternal.NamespacePruned,
                "UNAFFECTED_PROJECT" => UserEventPayloadVariant14DeploymentAllowListedReadyStateReasonInternal.UnaffectedProject,
                "UNVERIFIED_COMMIT" => UserEventPayloadVariant14DeploymentAllowListedReadyStateReasonInternal.UnverifiedCommit,
                _ => null,
            };
        }
    }
}