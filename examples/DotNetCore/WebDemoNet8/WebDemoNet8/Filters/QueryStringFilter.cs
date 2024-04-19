using Microsoft.FeatureManagement;

namespace WebDemoNet8.Filters
{
    [FilterAlias("QueryStringFilter")]
    public class QueryStringFilter : IFeatureFilter
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public QueryStringFilter(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Task<bool> EvaluateAsync(FeatureFilterEvaluationContext context)
        {
            var settings = context.Parameters.Get<QueryFilterSettings>();

            bool? isEnabled = _httpContextAccessor?.HttpContext?.Request?.Query?.ContainsKey(settings.QueryStringFieldName);

            return (isEnabled != null) ? Task.FromResult(isEnabled.Value) : Task.FromResult(false);
        }
    }
}
