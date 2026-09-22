
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The result of the microfrontends config upload during deployment creation / build. Only set for default app deployments. The config upload is attempted during deployment create, and then again during the build. If the config is not in the root directory, or the deployment is prebuilt, the config cannot be uploaded during deployment create. The upload during deployment build finds the config even if it's not in the root directory, as it has access to all files. Uploading the config during create is ideal, as then all child deployments are guaranteed to have access to the default app deployment config even if the default app has not yet started building. If the config is not uploaded, the child app will show as building until the config has been uploaded during the default app build. - `success` - The config was uploaded successfully, either when the deployment was created or during the build. - `waiting_on_build` - The config could not be uploaded during deployment create, will be attempted again during the build. - `no_config` - No config was found. Only set once the build has not found the config in any of the deployment's files. - `undefined` - Legacy deployments, or there was an error uploading the config during deployment create.
    /// </summary>
    public enum AutoSDKShared238fc1521601aa81MfeConfigUploadState
    {
        /// <summary>
        ///
        /// </summary>
        NoConfig,
        /// <summary>
        ///
        /// </summary>
        Success,
        /// <summary>
        ///
        /// </summary>
        WaitingOnBuild,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared238fc1521601aa81MfeConfigUploadStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared238fc1521601aa81MfeConfigUploadState value)
        {
            return value switch
            {
                AutoSDKShared238fc1521601aa81MfeConfigUploadState.NoConfig => "no_config",
                AutoSDKShared238fc1521601aa81MfeConfigUploadState.Success => "success",
                AutoSDKShared238fc1521601aa81MfeConfigUploadState.WaitingOnBuild => "waiting_on_build",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared238fc1521601aa81MfeConfigUploadState? ToEnum(string value)
        {
            return value switch
            {
                "no_config" => AutoSDKShared238fc1521601aa81MfeConfigUploadState.NoConfig,
                "success" => AutoSDKShared238fc1521601aa81MfeConfigUploadState.Success,
                "waiting_on_build" => AutoSDKShared238fc1521601aa81MfeConfigUploadState.WaitingOnBuild,
                _ => null,
            };
        }
    }
}