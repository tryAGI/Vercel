
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede7e7c058d3e19656InternalRouteVariant2MitigateAction
    {
        /// <summary>
        ///
        /// </summary>
        BlockLegalCwc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharede7e7c058d3e19656InternalRouteVariant2MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede7e7c058d3e19656InternalRouteVariant2MitigateAction value)
        {
            return value switch
            {
                AutoSDKSharede7e7c058d3e19656InternalRouteVariant2MitigateAction.BlockLegalCwc => "block_legal_cwc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede7e7c058d3e19656InternalRouteVariant2MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "block_legal_cwc" => AutoSDKSharede7e7c058d3e19656InternalRouteVariant2MitigateAction.BlockLegalCwc,
                _ => null,
            };
        }
    }
}