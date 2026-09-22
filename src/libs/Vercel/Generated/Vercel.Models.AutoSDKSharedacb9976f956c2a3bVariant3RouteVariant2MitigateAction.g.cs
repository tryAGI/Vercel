
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedacb9976f956c2a3bVariant3RouteVariant2MitigateAction
    {
        /// <summary>
        ///
        /// </summary>
        BlockLegalCwc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedacb9976f956c2a3bVariant3RouteVariant2MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedacb9976f956c2a3bVariant3RouteVariant2MitigateAction value)
        {
            return value switch
            {
                AutoSDKSharedacb9976f956c2a3bVariant3RouteVariant2MitigateAction.BlockLegalCwc => "block_legal_cwc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedacb9976f956c2a3bVariant3RouteVariant2MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "block_legal_cwc" => AutoSDKSharedacb9976f956c2a3bVariant3RouteVariant2MitigateAction.BlockLegalCwc,
                _ => null,
            };
        }
    }
}