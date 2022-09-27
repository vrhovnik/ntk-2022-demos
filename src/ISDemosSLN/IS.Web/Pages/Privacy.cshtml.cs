﻿using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IS.Web.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> logger;

    public PrivacyModel(ILogger<PrivacyModel> logger) => this.logger = logger;

    public void OnGet() => logger.LogInformation("Privacy page loaded at {DateLoaded}", DateTime.Now);
}