﻿namespace Api.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : BaseController
    {
        [HttpGet]
        public async Task<IEnumerable<ItemListingResponseModel>> Mine()
        {
            

            return null;

        }
    }
}
