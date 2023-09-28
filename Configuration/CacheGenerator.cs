using Microsoft.Extensions.Caching.Memory;

namespace Ecommerce.Configuration
{
	public class CacheGenerator
	{

		private readonly MemoryCache _memoryCache;
		public CacheGenerator(MemoryCache memoryCache)
		{
			_memoryCache = memoryCache;
		}
	}
}
