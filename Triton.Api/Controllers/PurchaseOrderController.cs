using Microsoft.AspNetCore.Mvc;
using Triton.Api.Business;
using Triton.Api.Contracts;

namespace Triton.Api.Service.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PurchaseOrderController(ILogger<PurchaseOrderController> logger, IPurchaseOrderManager purchaseOrderManager) : ControllerBase
    {
     
        [HttpPost(Name ="CreatePurchaseOrder")]
        public async Task<PurchaseOrder?> CreatePurchaseOrder()
        {
            logger.LogInformation("Purchase Order create started!");
            PurchaseOrder? po = await purchaseOrderManager.CreatePurchaseOrder();
            if (po == null)
            {
                logger.LogInformation("Purchase Order create ended!");
                return po;
            }
            else
            {
                logger.LogError("Purchase Order create failed!");
                return null;
            }
        }
    }
}
