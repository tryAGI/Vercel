
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Deployment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2Kind value)
        {
            return value switch
            {
                AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2Kind.Deployment => "deployment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "deployment" => AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2Kind.Deployment,
                _ => null,
            };
        }
    }
}