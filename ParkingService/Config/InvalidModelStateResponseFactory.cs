using Microsoft.AspNetCore.Mvc;
using ParkingService.Controllers.Resources;
using System.Linq;

namespace ParkingService.Config
{
    public static class InvalidModelStateResponseFactory
    {
        public static IActionResult ProduceErrorResponse(ActionContext context)
        {
            var errors = context.ModelState
                                .SelectMany(m => m.Value.Errors)
                                .Select(m => m.ErrorMessage)
                                .ToList();

            var response = new ErrorResource(messages: errors);
            return new BadRequestObjectResult(response);
        }
    }
}