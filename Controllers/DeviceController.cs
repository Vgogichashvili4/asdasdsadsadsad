using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.DeviceService;
using webApi1.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _DeviceService;

        public DeviceController(IDeviceService DeviceService)
        {
            _DeviceService = DeviceService;
        }

        [Route("GetDevices")]
        [HttpGet]
        public async Task<IActionResult> GetAllDevices()
        {
            var result = await _DeviceService.GetAllDevices();
            return Ok(result);
        }



        [Route("GetOrders")]
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var result = await _DeviceService.GetAllOrders();
            return Ok(result);
        }

        [Route("GetOrderHistory")]
        [HttpGet]
        public async Task<IActionResult> GetOrderHistory()
        {
            var result = await _DeviceService.GetOrderHistory();
            return Ok(result);
        }

        [Route("GetListenerInfo")]
        [HttpGet]
        public async Task<IActionResult> GetListenerInfo()
        {
            var result = await _DeviceService.GetListenerInfo();
            return Ok(result);
        }

        [Route("AddDevice")]
        [HttpPost]
        public async Task<IActionResult> AddDevice(DeviceModel device)
        {
            var result = await _DeviceService.AddDevice(device);
            return Ok(result);
        }

        [Route("AddOrder")]
        [HttpPost]
        public async Task<IActionResult> AddOrder(OrderModel order)
        {
            var result = await _DeviceService.AddOrder(order);
            return Ok(result);
        }

        [Route("OrderHistory")]
        [HttpPost]
        public async Task<IActionResult> AddOrderHistory(OrderHistory order)
        {
            var result = await _DeviceService.AddOrderHistory(order);
            return Ok(result);
        }

        [Route("AddListenerModel")]
        [HttpPost]
        public async Task<IActionResult> AddListenerModel(ListenerModel order)
        {
            var result = await _DeviceService.AddListenerModel(order);
            return Ok(result);
        }
    }
}