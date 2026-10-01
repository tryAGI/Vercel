
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareddb65d769b106737aInterstitialHistoryItemAction
    {
        /// <summary>
        ///
        /// </summary>
        AddDeploymentInterstitial,
        /// <summary>
        ///
        /// </summary>
        AddProjectInterstitial,
        /// <summary>
        ///
        /// </summary>
        RemoveDeploymentInterstitial,
        /// <summary>
        ///
        /// </summary>
        RemoveProjectInterstitial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareddb65d769b106737aInterstitialHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareddb65d769b106737aInterstitialHistoryItemAction value)
        {
            return value switch
            {
                AutoSDKShareddb65d769b106737aInterstitialHistoryItemAction.AddDeploymentInterstitial => "add-deployment-interstitial",
                AutoSDKShareddb65d769b106737aInterstitialHistoryItemAction.AddProjectInterstitial => "add-project-interstitial",
                AutoSDKShareddb65d769b106737aInterstitialHistoryItemAction.RemoveDeploymentInterstitial => "remove-deployment-interstitial",
                AutoSDKShareddb65d769b106737aInterstitialHistoryItemAction.RemoveProjectInterstitial => "remove-project-interstitial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareddb65d769b106737aInterstitialHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "add-deployment-interstitial" => AutoSDKShareddb65d769b106737aInterstitialHistoryItemAction.AddDeploymentInterstitial,
                "add-project-interstitial" => AutoSDKShareddb65d769b106737aInterstitialHistoryItemAction.AddProjectInterstitial,
                "remove-deployment-interstitial" => AutoSDKShareddb65d769b106737aInterstitialHistoryItemAction.RemoveDeploymentInterstitial,
                "remove-project-interstitial" => AutoSDKShareddb65d769b106737aInterstitialHistoryItemAction.RemoveProjectInterstitial,
                _ => null,
            };
        }
    }
}