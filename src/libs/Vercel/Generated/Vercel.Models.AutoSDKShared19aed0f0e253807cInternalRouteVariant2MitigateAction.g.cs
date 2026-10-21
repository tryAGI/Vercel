
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared19aed0f0e253807cInternalRouteVariant2MitigateAction
    {
        /// <summary>
        ///
        /// </summary>
        BlockLegalCwc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared19aed0f0e253807cInternalRouteVariant2MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared19aed0f0e253807cInternalRouteVariant2MitigateAction value)
        {
            return value switch
            {
                AutoSDKShared19aed0f0e253807cInternalRouteVariant2MitigateAction.BlockLegalCwc => "block_legal_cwc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared19aed0f0e253807cInternalRouteVariant2MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "block_legal_cwc" => AutoSDKShared19aed0f0e253807cInternalRouteVariant2MitigateAction.BlockLegalCwc,
                _ => null,
            };
        }
    }
}