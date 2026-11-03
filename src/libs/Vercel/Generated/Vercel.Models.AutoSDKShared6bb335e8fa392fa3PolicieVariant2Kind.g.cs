
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bb335e8fa392fa3PolicieVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        ConnexGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6bb335e8fa392fa3PolicieVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bb335e8fa392fa3PolicieVariant2Kind value)
        {
            return value switch
            {
                AutoSDKShared6bb335e8fa392fa3PolicieVariant2Kind.ConnexGrant => "connex-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bb335e8fa392fa3PolicieVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "connex-grant" => AutoSDKShared6bb335e8fa392fa3PolicieVariant2Kind.ConnexGrant,
                _ => null,
            };
        }
    }
}