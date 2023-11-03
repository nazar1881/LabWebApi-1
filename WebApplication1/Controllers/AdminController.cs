﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Roles = "Admin")]
[Route("api/[controller]")]
[ApiController]
public class AdminController : ControllerBase
{
    public AdminController()
    {

    }
    [HttpGet]
    public async Task<IActionResult> Admin()
    {
        string result = "It's Admin";
        return Ok(result);
    }
}