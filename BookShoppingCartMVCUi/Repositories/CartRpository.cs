using Microsoft.AspNetCore.Identity;

namespace BookShoppingCartMVCUi.Repositories
{
    public class CartRpository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartRpository(ApplicationDbContext context, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        
        //public async Task<bool> AddToCart(int bookId, int qty)
        //{
            //String userId = GetUserId();
            //if(string.IsNullOrEmpty(userId))
            //{
            //    return false;
            //}
            //var cart = await GetCart(userId);
            //if(cart == null)
            //{
            //    cart = new ShoppingCart
            //    {
            //        UserId = userId
            //    }
            //}
            //return true;
        //}

        private async Task<ShoppingCart> GetCart(string userId)
        {
            var cart = await _context.ShoppingCarts.FirstOrDefault(x => x.UserId == userId);
            return cart;
        }

        //Summary
        //Getting the current logged in Users Id using the context manager
        //Summary
        private string GetUserId()
        {
            var user = _httpContextAccessor.HttpContext.User;
            var userId = _userManager.GetUserId(user);
            return userId;
        }
    }
}
