using Database;

namespace WebShop.Repositories
{
	public class ItemRepository
	{

		private Context _dbContext;

		public ItemRepository()
		{
			_dbContext = new Context();
		}


	}
}
