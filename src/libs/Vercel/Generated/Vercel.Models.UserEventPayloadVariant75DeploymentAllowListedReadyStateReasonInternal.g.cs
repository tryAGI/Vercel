
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A narrowed subset of the deployment's `readyStateReasonInternal` — only values in the public allowlist are permitted here. Callers should run their raw reason through `toAllowListedReadyStateReasonInternal` from `@api/events` before assigning. This keeps abuse / moderation / admin reasons out of the public activity log.
    /// </summary>
    public enum UserEventPayloadVariant75DeploymentAllowListedReadyStateReasonInternal
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
    public static class UserEventPayloadVariant75DeploymentAllowListedReadyStateReasonInternalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant75DeploymentAllowListedReadyStateReasonInternal value)
        {
            return value switch
            {
                UserEventPayloadVariant75DeploymentAllowListedReadyStateReasonInternal.EarlyIgnoreStep => "EARLY_IGNORE_STEP",
                UserEventPayloadVariant75DeploymentAllowListedReadyStateReasonInternal.IgnoreStep => "IGNORE_STEP",
                UserEventPayloadVariant75DeploymentAllowListedReadyStateReasonInternal.NamespacePruned => "NAMESPACE_PRUNED",
                UserEventPayloadVariant75DeploymentAllowListedReadyStateReasonInternal.UnaffectedProject => "UNAFFECTED_PROJECT",
                UserEventPayloadVariant75DeploymentAllowListedReadyStateReasonInternal.UnverifiedCommit => "UNVERIFIED_COMMIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant75DeploymentAllowListedReadyStateReasonInternal? ToEnum(string value)
        {
            return value switch
            {
                "EARLY_IGNORE_STEP" => UserEventPayloadVariant75DeploymentAllowListedReadyStateReasonInternal.EarlyIgnoreStep,
                "IGNORE_STEP" => UserEventPayloadVariant75DeploymentAllowListedReadyStateReasonInternal.IgnoreStep,
                "NAMESPACE_PRUNED" => UserEventPayloadVariant75DeploymentAllowListedReadyStateReasonInternal.NamespacePruned,
                "UNAFFECTED_PROJECT" => UserEventPayloadVariant75DeploymentAllowListedReadyStateReasonInternal.UnaffectedProject,
                "UNVERIFIED_COMMIT" => UserEventPayloadVariant75DeploymentAllowListedReadyStateReasonInternal.UnverifiedCommit,
                _ => null,
            };
        }
    }
}