
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The Vercel region in which to create the sandbox.<br/>
    /// Default Value: [iad1, sfo1, cle1, cdg1]<br/>
    /// Example: iad1
    /// </summary>
    public enum CreateSandboxesV3RequestRegion
    {
        /// <summary>
        /// 
        /// </summary>
        Cdg1,
        /// <summary>
        /// 
        /// </summary>
        Cle1,
        /// <summary>
        /// 
        /// </summary>
        Iad1,
        /// <summary>
        /// 
        /// </summary>
        Sfo1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSandboxesV3RequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesV3RequestRegion value)
        {
            return value switch
            {
                CreateSandboxesV3RequestRegion.Cdg1 => "cdg1",
                CreateSandboxesV3RequestRegion.Cle1 => "cle1",
                CreateSandboxesV3RequestRegion.Iad1 => "iad1",
                CreateSandboxesV3RequestRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesV3RequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => CreateSandboxesV3RequestRegion.Cdg1,
                "cle1" => CreateSandboxesV3RequestRegion.Cle1,
                "iad1" => CreateSandboxesV3RequestRegion.Iad1,
                "sfo1" => CreateSandboxesV3RequestRegion.Sfo1,
                _ => null,
            };
        }
    }
}