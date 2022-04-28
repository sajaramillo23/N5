
using Nest;
using System;
using System.Threading.Tasks;
using System.Linq;
using N5.Application.Abstractions;

namespace N5.ElasticSearch
{
    public class ElasticSearchService<T> where T : SearchResult
    {
        private readonly IElasticClient _elasticClient;

        public ElasticSearchService(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }
        public async Task<T> Get(int id)
        {
            var response = await _elasticClient.SearchAsync<T>(s => s.Index(typeof(T).Name.ToLower()
                ).Query(q => q.Match(m => m.Field(f=>f.Name).Query(id.ToString()))));
            return response?.Documents?.FirstOrDefault();

        }

        public async Task<string> Post(T instance)
        {
            var response = await _elasticClient.IndexAsync<T>(instance, s => s.Index(typeof(T).Name.ToLower()));
            return response.Id;

        }

    }
}
