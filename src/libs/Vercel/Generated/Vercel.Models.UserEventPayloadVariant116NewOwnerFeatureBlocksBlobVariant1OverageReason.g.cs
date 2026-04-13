
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason
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
    public static class UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.Artifacts => "artifacts",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.Bandwidth => "bandwidth",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidDuration => "fluidDuration",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionDuration => "functionDuration",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.SourceImages => "sourceImages",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.Artifacts,
                "bandwidth" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidDuration,
                "functionDuration" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1OverageReason.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}