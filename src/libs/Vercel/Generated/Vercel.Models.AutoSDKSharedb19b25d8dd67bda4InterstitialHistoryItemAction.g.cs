
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemAction
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
    public static class AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemAction value)
        {
            return value switch
            {
                AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemAction.AddDeploymentInterstitial => "add-deployment-interstitial",
                AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemAction.AddProjectInterstitial => "add-project-interstitial",
                AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemAction.RemoveDeploymentInterstitial => "remove-deployment-interstitial",
                AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemAction.RemoveProjectInterstitial => "remove-project-interstitial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "add-deployment-interstitial" => AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemAction.AddDeploymentInterstitial,
                "add-project-interstitial" => AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemAction.AddProjectInterstitial,
                "remove-deployment-interstitial" => AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemAction.RemoveDeploymentInterstitial,
                "remove-project-interstitial" => AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemAction.RemoveProjectInterstitial,
                _ => null,
            };
        }
    }
}