
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseAbuseBlockHistoryItemVariant3RouteVariant2MitigateAction
    {
        /// <summary>
        /// 
        /// </summary>
        BlockLegalCwc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseAbuseBlockHistoryItemVariant3RouteVariant2MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseAbuseBlockHistoryItemVariant3RouteVariant2MitigateAction value)
        {
            return value switch
            {
                UploadProjectAvatarResponseAbuseBlockHistoryItemVariant3RouteVariant2MitigateAction.BlockLegalCwc => "block_legal_cwc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseAbuseBlockHistoryItemVariant3RouteVariant2MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "block_legal_cwc" => UploadProjectAvatarResponseAbuseBlockHistoryItemVariant3RouteVariant2MitigateAction.BlockLegalCwc,
                _ => null,
            };
        }
    }
}