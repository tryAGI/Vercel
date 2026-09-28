
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd60af9eb328d9316Schema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd60af9eb328d9316SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd60af9eb328d9316Schema value)
        {
            return value switch
            {
                AutoSDKSharedd60af9eb328d9316Schema.ExperimentalServices => "experimentalServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd60af9eb328d9316Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServices" => AutoSDKSharedd60af9eb328d9316Schema.ExperimentalServices,
                _ => null,
            };
        }
    }
}