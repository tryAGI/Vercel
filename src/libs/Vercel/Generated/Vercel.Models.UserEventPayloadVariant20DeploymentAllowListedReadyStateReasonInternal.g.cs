
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A narrowed subset of the deployment's `readyStateReasonInternal` — only values in the public allowlist are permitted here. Callers should run their raw reason through `toAllowListedReadyStateReasonInternal` from `@api/events` before assigning. This keeps abuse / moderation / admin reasons out of the public activity log.
    /// </summary>
    public enum UserEventPayloadVariant20DeploymentAllowListedReadyStateReasonInternal
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
    public static class UserEventPayloadVariant20DeploymentAllowListedReadyStateReasonInternalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant20DeploymentAllowListedReadyStateReasonInternal value)
        {
            return value switch
            {
                UserEventPayloadVariant20DeploymentAllowListedReadyStateReasonInternal.EarlyIgnoreStep => "EARLY_IGNORE_STEP",
                UserEventPayloadVariant20DeploymentAllowListedReadyStateReasonInternal.IgnoreStep => "IGNORE_STEP",
                UserEventPayloadVariant20DeploymentAllowListedReadyStateReasonInternal.NamespacePruned => "NAMESPACE_PRUNED",
                UserEventPayloadVariant20DeploymentAllowListedReadyStateReasonInternal.UnaffectedProject => "UNAFFECTED_PROJECT",
                UserEventPayloadVariant20DeploymentAllowListedReadyStateReasonInternal.UnverifiedCommit => "UNVERIFIED_COMMIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant20DeploymentAllowListedReadyStateReasonInternal? ToEnum(string value)
        {
            return value switch
            {
                "EARLY_IGNORE_STEP" => UserEventPayloadVariant20DeploymentAllowListedReadyStateReasonInternal.EarlyIgnoreStep,
                "IGNORE_STEP" => UserEventPayloadVariant20DeploymentAllowListedReadyStateReasonInternal.IgnoreStep,
                "NAMESPACE_PRUNED" => UserEventPayloadVariant20DeploymentAllowListedReadyStateReasonInternal.NamespacePruned,
                "UNAFFECTED_PROJECT" => UserEventPayloadVariant20DeploymentAllowListedReadyStateReasonInternal.UnaffectedProject,
                "UNVERIFIED_COMMIT" => UserEventPayloadVariant20DeploymentAllowListedReadyStateReasonInternal.UnverifiedCommit,
                _ => null,
            };
        }
    }
}