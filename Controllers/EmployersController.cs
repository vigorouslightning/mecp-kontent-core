using System.Threading.Tasks;
using mecp_kontent_core.Models;
using Kentico.Kontent.Delivery;
using Kentico.Kontent.Delivery.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mecp_kontent_core.Controllers
{
    public class EmployersController : BaseController<HomeController>
    {
        public EmployersController(IDeliveryClient deliveryClient, ILogger<HomeController> logger) : base(deliveryClient, logger)
        {
            
        }

        public async Task<ViewResult> Index()
        {
            IDeliveryClient client = DeliveryClientBuilder
                .WithProjectId("<ProjectID>")
                .Build();

            var response = await client.GetItemAsync<Homepage>(
                "employers",
                new DepthParameter(3)
            );

            return View(response.Item);
        }
    }
}
