﻿using System.Security.Claims;

namespace Core;

partial class XExtensions
{
    public static string GetEmail(this ClaimsPrincipal @this)
        => @this?.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;

    public static string GetId(this ClaimsPrincipal @this)
        => @this?.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

    public static IEnumerable<string> GetRoles(this ClaimsPrincipal @this)
    {
        return @this?.Claims.Where(x => x.Type == ClaimTypes.Role)
            .SelectMany(x => x.Value.OrEmpty().Split(',')).Trim();
    }

    public static string GetFirstIssuer(this ClaimsPrincipal @this)
        => @this?.Claims?.Select(x => x.Issuer).Trim().FirstOrDefault();
}