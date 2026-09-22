
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared803d328dcef47295GitSourceSourceVariant1Provider
    {
        /// <summary>
        ///
        /// </summary>
        Bitbucket,
        /// <summary>
        ///
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared803d328dcef47295GitSourceSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared803d328dcef47295GitSourceSourceVariant1Provider value)
        {
            return value switch
            {
                AutoSDKShared803d328dcef47295GitSourceSourceVariant1Provider.Bitbucket => "bitbucket",
                AutoSDKShared803d328dcef47295GitSourceSourceVariant1Provider.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared803d328dcef47295GitSourceSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => AutoSDKShared803d328dcef47295GitSourceSourceVariant1Provider.Bitbucket,
                "github" => AutoSDKShared803d328dcef47295GitSourceSourceVariant1Provider.Github,
                _ => null,
            };
        }
    }
}