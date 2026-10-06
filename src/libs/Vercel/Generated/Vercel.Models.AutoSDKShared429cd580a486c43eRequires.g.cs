
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared429cd580a486c43eRequires
    {
        /// <summary>
        ///
        /// </summary>
        BuildReady,
        /// <summary>
        ///
        /// </summary>
        DeploymentUrl,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared429cd580a486c43eRequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429cd580a486c43eRequires value)
        {
            return value switch
            {
                AutoSDKShared429cd580a486c43eRequires.BuildReady => "build-ready",
                AutoSDKShared429cd580a486c43eRequires.DeploymentUrl => "deployment-url",
                AutoSDKShared429cd580a486c43eRequires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429cd580a486c43eRequires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => AutoSDKShared429cd580a486c43eRequires.BuildReady,
                "deployment-url" => AutoSDKShared429cd580a486c43eRequires.DeploymentUrl,
                "none" => AutoSDKShared429cd580a486c43eRequires.None,
                _ => null,
            };
        }
    }
}