﻿// <copyright file="ISingletonService.cs" company="TanvirArjel">
// Copyright (c) TanvirArjel. All rights reserved.
// </copyright>

namespace AspNetCore.DependencyInjection.ServiceRegistration.Interfaces
{
    /// <summary>
    /// The services implemented this interface will automatically be registered with singleton life time in
    /// ASP.NET Core Dependency Injection Container.
    /// </summary>
    public interface ISingletonService
    {
        // This is marker interface
    }
}