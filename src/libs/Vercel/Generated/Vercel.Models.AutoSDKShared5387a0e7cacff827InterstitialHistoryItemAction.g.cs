
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5387a0e7cacff827InterstitialHistoryItemAction
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
    public static class AutoSDKShared5387a0e7cacff827InterstitialHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5387a0e7cacff827InterstitialHistoryItemAction value)
        {
            return value switch
            {
                AutoSDKShared5387a0e7cacff827InterstitialHistoryItemAction.AddDeploymentInterstitial => "add-deployment-interstitial",
                AutoSDKShared5387a0e7cacff827InterstitialHistoryItemAction.AddProjectInterstitial => "add-project-interstitial",
                AutoSDKShared5387a0e7cacff827InterstitialHistoryItemAction.RemoveDeploymentInterstitial => "remove-deployment-interstitial",
                AutoSDKShared5387a0e7cacff827InterstitialHistoryItemAction.RemoveProjectInterstitial => "remove-project-interstitial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5387a0e7cacff827InterstitialHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "add-deployment-interstitial" => AutoSDKShared5387a0e7cacff827InterstitialHistoryItemAction.AddDeploymentInterstitial,
                "add-project-interstitial" => AutoSDKShared5387a0e7cacff827InterstitialHistoryItemAction.AddProjectInterstitial,
                "remove-deployment-interstitial" => AutoSDKShared5387a0e7cacff827InterstitialHistoryItemAction.RemoveDeploymentInterstitial,
                "remove-project-interstitial" => AutoSDKShared5387a0e7cacff827InterstitialHistoryItemAction.RemoveProjectInterstitial,
                _ => null,
            };
        }
    }
}