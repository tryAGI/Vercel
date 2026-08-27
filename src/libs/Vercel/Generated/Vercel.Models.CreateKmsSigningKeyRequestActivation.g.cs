
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the new key is activated automatically after its public key has propagated, or manually via the activate endpoint. Defaults to `automatic`.
    /// </summary>
    public enum CreateKmsSigningKeyRequestActivation
    {
        /// <summary>
        ///
        /// </summary>
        Automatic,
        /// <summary>
        ///
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKmsSigningKeyRequestActivationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKmsSigningKeyRequestActivation value)
        {
            return value switch
            {
                CreateKmsSigningKeyRequestActivation.Automatic => "automatic",
                CreateKmsSigningKeyRequestActivation.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKmsSigningKeyRequestActivation? ToEnum(string value)
        {
            return value switch
            {
                "automatic" => CreateKmsSigningKeyRequestActivation.Automatic,
                "manual" => CreateKmsSigningKeyRequestActivation.Manual,
                _ => null,
            };
        }
    }
}