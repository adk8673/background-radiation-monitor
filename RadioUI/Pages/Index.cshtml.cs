using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RadioUI.Services.Interfaces;

namespace RadioUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IInfluxDbService _influxDbService;

        public IndexModel(ILogger<IndexModel> logger, IInfluxDbService influxDbService)
        {
            _logger = logger;
            _influxDbService = influxDbService;
        }

        public void OnGet()
        {

        }

        public async Task<JsonResult> OnGetCurrentRadiationValues()
        {
            var results = _influxDbService.QueryAsync(async query =>
            {

            });
        }
    }
}
