﻿using eShopSolution.ViewModels.System.Utilities.Slides;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public class SlideApiClient : BaseApiClient, ISlideApiClient
    {

        public SlideApiClient(IHttpClientFactory httpClientFactory,
                IHttpContextAccessor httpContextAccessor,
                IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {

        }

        public async Task<List<SlideViewModel>> GetAll()
        {
            return await GetListAsync<SlideViewModel>("/api/slides");
        }
    }
}
