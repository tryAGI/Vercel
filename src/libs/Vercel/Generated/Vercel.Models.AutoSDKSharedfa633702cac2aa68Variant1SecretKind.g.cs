
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa633702cac2aa68Variant1SecretKind
    {
        /// <summary>
        ///
        /// </summary>
        IntegrationSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfa633702cac2aa68Variant1SecretKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa633702cac2aa68Variant1SecretKind value)
        {
            return value switch
            {
                AutoSDKSharedfa633702cac2aa68Variant1SecretKind.IntegrationSecret => "INTEGRATION_SECRET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa633702cac2aa68Variant1SecretKind? ToEnum(string value)
        {
            return value switch
            {
                "INTEGRATION_SECRET" => AutoSDKSharedfa633702cac2aa68Variant1SecretKind.IntegrationSecret,
                _ => null,
            };
        }
    }
}