
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseInternalRouteVariant2MitigateAction
    {
        /// <summary>
        /// 
        /// </summary>
        BlockLegalCwc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseInternalRouteVariant2MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseInternalRouteVariant2MitigateAction value)
        {
            return value switch
            {
                CreateProjectResponseInternalRouteVariant2MitigateAction.BlockLegalCwc => "block_legal_cwc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseInternalRouteVariant2MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "block_legal_cwc" => CreateProjectResponseInternalRouteVariant2MitigateAction.BlockLegalCwc,
                _ => null,
            };
        }
    }
}