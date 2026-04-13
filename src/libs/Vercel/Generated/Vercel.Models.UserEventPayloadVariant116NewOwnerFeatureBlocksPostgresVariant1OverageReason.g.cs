
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason
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
    public static class UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.Artifacts => "artifacts",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.Bandwidth => "bandwidth",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidDuration => "fluidDuration",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionDuration => "functionDuration",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.SourceImages => "sourceImages",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.Artifacts,
                "bandwidth" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidDuration,
                "functionDuration" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1OverageReason.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}