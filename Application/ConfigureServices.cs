﻿using Application.Common.Behaviours;
using FluentValidation;
using MediatR;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection;


public static class ConfigureServices
{
	public static IServiceCollection AddApplicationServices(this IServiceCollection services)
	{
		services.AddMediatR(_ => _.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
		services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
		services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
		services.AddAutoMapper(Assembly.GetExecutingAssembly());
		services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

		return services;
	}
}


