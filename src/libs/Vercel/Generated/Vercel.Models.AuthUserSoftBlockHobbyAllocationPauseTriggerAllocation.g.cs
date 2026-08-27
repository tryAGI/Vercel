
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metered allocation whose included amount was fully consumed.
    /// </summary>
    public enum AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation
    {
        /// <summary>
        ///
        /// </summary>
        AnalyticsUsage,
        /// <summary>
        ///
        /// </summary>
        Artifacts,
        /// <summary>
        ///
        /// </summary>
        Bandwidth,
        /// <summary>
        ///
        /// </summary>
        BlobDataTransfer,
        /// <summary>
        ///
        /// </summary>
        BlobTotalAdvancedRequests,
        /// <summary>
        ///
        /// </summary>
        BlobTotalAvgSizeInBytes,
        /// <summary>
        ///
        /// </summary>
        BlobTotalGetResponseObjectSizeInBytes,
        /// <summary>
        ///
        /// </summary>
        BlobTotalSimpleRequests,
        /// <summary>
        ///
        /// </summary>
        ConnectDataTransfer,
        /// <summary>
        ///
        /// </summary>
        DataCacheRead,
        /// <summary>
        ///
        /// </summary>
        DataCacheWrite,
        /// <summary>
        ///
        /// </summary>
        EdgeConfigRead,
        /// <summary>
        ///
        /// </summary>
        EdgeConfigWrite,
        /// <summary>
        ///
        /// </summary>
        EdgeFunctionExecutionUnits,
        /// <summary>
        ///
        /// </summary>
        EdgeMiddlewareInvocations,
        /// <summary>
        ///
        /// </summary>
        EdgeRequest,
        /// <summary>
        ///
        /// </summary>
        EdgeRequestAdditionalCpuDuration,
        /// <summary>
        ///
        /// </summary>
        ElasticConcurrencyBuildSlots,
        /// <summary>
        ///
        /// </summary>
        FastDataTransfer,
        /// <summary>
        ///
        /// </summary>
        FastOriginTransfer,
        /// <summary>
        ///
        /// </summary>
        FluidCpuDuration,
        /// <summary>
        ///
        /// </summary>
        FluidDuration,
        /// <summary>
        ///
        /// </summary>
        FunctionDuration,
        /// <summary>
        ///
        /// </summary>
        FunctionInvocation,
        /// <summary>
        ///
        /// </summary>
        ImageOptimizationCacheRead,
        /// <summary>
        ///
        /// </summary>
        ImageOptimizationCacheWrite,
        /// <summary>
        ///
        /// </summary>
        ImageOptimizationTransformation,
        /// <summary>
        ///
        /// </summary>
        LogDrainsVolume,
        /// <summary>
        ///
        /// </summary>
        MonitoringMetric,
        /// <summary>
        ///
        /// </summary>
        ObservabilityEvent,
        /// <summary>
        ///
        /// </summary>
        OnDemandConcurrencyMinutes,
        /// <summary>
        ///
        /// </summary>
        RuntimeCacheRead,
        /// <summary>
        ///
        /// </summary>
        RuntimeCacheWrite,
        /// <summary>
        ///
        /// </summary>
        ServerlessFunctionExecution,
        /// <summary>
        ///
        /// </summary>
        SourceImages,
        /// <summary>
        ///
        /// </summary>
        WafOwaspExcessBytes,
        /// <summary>
        ///
        /// </summary>
        WafOwaspRequests,
        /// <summary>
        ///
        /// </summary>
        WafRateLimitRequest,
        /// <summary>
        ///
        /// </summary>
        WebAnalyticsEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthUserSoftBlockHobbyAllocationPauseTriggerAllocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation value)
        {
            return value switch
            {
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.AnalyticsUsage => "analyticsUsage",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.Artifacts => "artifacts",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.Bandwidth => "bandwidth",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.BlobDataTransfer => "blobDataTransfer",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.ConnectDataTransfer => "connectDataTransfer",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.DataCacheRead => "dataCacheRead",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.DataCacheWrite => "dataCacheWrite",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.EdgeConfigRead => "edgeConfigRead",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.EdgeConfigWrite => "edgeConfigWrite",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.EdgeRequest => "edgeRequest",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.FastDataTransfer => "fastDataTransfer",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.FastOriginTransfer => "fastOriginTransfer",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.FluidCpuDuration => "fluidCpuDuration",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.FluidDuration => "fluidDuration",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.FunctionDuration => "functionDuration",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.FunctionInvocation => "functionInvocation",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.ImageOptimizationTransformation => "imageOptimizationTransformation",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.LogDrainsVolume => "logDrainsVolume",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.MonitoringMetric => "monitoringMetric",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.ObservabilityEvent => "observabilityEvent",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.RuntimeCacheRead => "runtimeCacheRead",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.RuntimeCacheWrite => "runtimeCacheWrite",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.ServerlessFunctionExecution => "serverlessFunctionExecution",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.SourceImages => "sourceImages",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.WafOwaspRequests => "wafOwaspRequests",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.WafRateLimitRequest => "wafRateLimitRequest",
                AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.AnalyticsUsage,
                "artifacts" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.Artifacts,
                "bandwidth" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.Bandwidth,
                "blobDataTransfer" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.BlobDataTransfer,
                "blobTotalAdvancedRequests" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.BlobTotalSimpleRequests,
                "connectDataTransfer" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.ConnectDataTransfer,
                "dataCacheRead" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.DataCacheRead,
                "dataCacheWrite" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.DataCacheWrite,
                "edgeConfigRead" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.EdgeConfigRead,
                "edgeConfigWrite" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.EdgeMiddlewareInvocations,
                "edgeRequest" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.FastDataTransfer,
                "fastOriginTransfer" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.FastOriginTransfer,
                "fluidCpuDuration" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.FluidCpuDuration,
                "fluidDuration" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.FluidDuration,
                "functionDuration" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.FunctionDuration,
                "functionInvocation" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.FunctionInvocation,
                "imageOptimizationCacheRead" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.ImageOptimizationTransformation,
                "logDrainsVolume" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.LogDrainsVolume,
                "monitoringMetric" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.MonitoringMetric,
                "observabilityEvent" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.RuntimeCacheRead,
                "runtimeCacheWrite" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.RuntimeCacheWrite,
                "serverlessFunctionExecution" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.ServerlessFunctionExecution,
                "sourceImages" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.SourceImages,
                "wafOwaspExcessBytes" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.WafOwaspExcessBytes,
                "wafOwaspRequests" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.WafOwaspRequests,
                "wafRateLimitRequest" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.WafRateLimitRequest,
                "webAnalyticsEvent" => AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}