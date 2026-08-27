
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentResponseVariant2AtprotoVariant2SubscriptionKind
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
    public static class CreateDeploymentResponseVariant2AtprotoVariant2SubscriptionKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2AtprotoVariant2SubscriptionKind value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Account => "account",
                CreateDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Commit => "commit",
                CreateDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Identity => "identity",
                CreateDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2AtprotoVariant2SubscriptionKind? ToEnum(string value)
        {
            return value switch
            {
                "account" => CreateDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Account,
                "commit" => CreateDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Commit,
                "identity" => CreateDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Identity,
                "sync" => CreateDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Sync,
                _ => null,
            };
        }
    }
}