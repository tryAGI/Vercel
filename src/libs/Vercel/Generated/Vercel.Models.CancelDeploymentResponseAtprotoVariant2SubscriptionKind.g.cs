
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CancelDeploymentResponseAtprotoVariant2SubscriptionKind
    {
        /// <summary>
        ///
        /// </summary>
        Account,
        /// <summary>
        ///
        /// </summary>
        Commit,
        /// <summary>
        ///
        /// </summary>
        Identity,
        /// <summary>
        ///
        /// </summary>
        Sync,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseAtprotoVariant2SubscriptionKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseAtprotoVariant2SubscriptionKind value)
        {
            return value switch
            {
                CancelDeploymentResponseAtprotoVariant2SubscriptionKind.Account => "account",
                CancelDeploymentResponseAtprotoVariant2SubscriptionKind.Commit => "commit",
                CancelDeploymentResponseAtprotoVariant2SubscriptionKind.Identity => "identity",
                CancelDeploymentResponseAtprotoVariant2SubscriptionKind.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseAtprotoVariant2SubscriptionKind? ToEnum(string value)
        {
            return value switch
            {
                "account" => CancelDeploymentResponseAtprotoVariant2SubscriptionKind.Account,
                "commit" => CancelDeploymentResponseAtprotoVariant2SubscriptionKind.Commit,
                "identity" => CancelDeploymentResponseAtprotoVariant2SubscriptionKind.Identity,
                "sync" => CancelDeploymentResponseAtprotoVariant2SubscriptionKind.Sync,
                _ => null,
            };
        }
    }
}