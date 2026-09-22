
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentResponseAtprotoVariant2SubscriptionKind
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
    public static class CreateDeploymentResponseAtprotoVariant2SubscriptionKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseAtprotoVariant2SubscriptionKind value)
        {
            return value switch
            {
                CreateDeploymentResponseAtprotoVariant2SubscriptionKind.Account => "account",
                CreateDeploymentResponseAtprotoVariant2SubscriptionKind.Commit => "commit",
                CreateDeploymentResponseAtprotoVariant2SubscriptionKind.Identity => "identity",
                CreateDeploymentResponseAtprotoVariant2SubscriptionKind.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseAtprotoVariant2SubscriptionKind? ToEnum(string value)
        {
            return value switch
            {
                "account" => CreateDeploymentResponseAtprotoVariant2SubscriptionKind.Account,
                "commit" => CreateDeploymentResponseAtprotoVariant2SubscriptionKind.Commit,
                "identity" => CreateDeploymentResponseAtprotoVariant2SubscriptionKind.Identity,
                "sync" => CreateDeploymentResponseAtprotoVariant2SubscriptionKind.Sync,
                _ => null,
            };
        }
    }
}