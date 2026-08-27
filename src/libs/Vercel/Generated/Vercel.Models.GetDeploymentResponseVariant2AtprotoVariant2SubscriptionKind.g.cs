
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentResponseVariant2AtprotoVariant2SubscriptionKind
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
    public static class GetDeploymentResponseVariant2AtprotoVariant2SubscriptionKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2AtprotoVariant2SubscriptionKind value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Account => "account",
                GetDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Commit => "commit",
                GetDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Identity => "identity",
                GetDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2AtprotoVariant2SubscriptionKind? ToEnum(string value)
        {
            return value switch
            {
                "account" => GetDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Account,
                "commit" => GetDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Commit,
                "identity" => GetDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Identity,
                "sync" => GetDeploymentResponseVariant2AtprotoVariant2SubscriptionKind.Sync,
                _ => null,
            };
        }
    }
}