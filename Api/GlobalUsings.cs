﻿global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore;
global using System.Text;
global using System.ComponentModel.DataAnnotations;
global using Microsoft.AspNetCore.Authorization;
global using System.Security.Claims;
global using Microsoft.Extensions.Options;
global using Microsoft.OpenApi.Models;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using MediatR;
global using Api;
global using SharedKernel.Models.Request.Identity;
global using SharedKernel.Models.Response.Identity;
global using Application.Commands.Items;
global using SharedKernel;
global using SharedKernel.Models.Request.Items;
global using SharedKernel.Models.Response.Items;
global using SharedKernel.Models.Response.Search;
global using Application;
global using Infrastructure;
global using Infrastructure.Ef;
global using Infrastructure.Configuration;
global using SharedKernel.Settings;
global using Service;
global using Application.Queries.Items;
global using Application.Commands.User;
global using SharedKernel.Models.Request.Search;
global using Application.Queries.Search;
global using Application.Commands.Identity;
global using Application.Queries.Identity;
global using Application.Queries.User;
global using NLog.Extensions.Logging;