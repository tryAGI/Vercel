
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Kind
    {
        /// <summary>
        ///
        /// </summary>
        Turborepo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Kind value)
        {
            return value switch
            {
                AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Kind.Turborepo => "turborepo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Kind? ToEnum(string value)
        {
            return value switch
            {
                "turborepo" => AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant4Kind.Turborepo,
                _ => null,
            };
        }
    }
}