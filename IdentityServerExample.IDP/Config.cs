﻿using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace IdentityServerExample.IDP
{
	public static class Config
	{
		public static List<TestUser> GetUsers()
		{
			return new List<TestUser>
			{
				new TestUser
				{
					SubjectId = Guid.NewGuid().ToString(),
					Username = "Frank",
					Password = "password",

					Claims = new List<Claim>
					{
						new Claim("given_name", "Frank"),
						new Claim("family_name", "Underwood")
					}
				},
				new TestUser
				{
					SubjectId = Guid.NewGuid().ToString(),
					Username = "Claire",
					Password = "password",

					Claims = new List<Claim>
					{
						new Claim("given_name", "Claire"),
						new Claim("family_name", "Underwood")
					}
				}
			};
		}

		public static IEnumerable<IdentityResource> GetIdentityResources()
		{
			return new List<IdentityResource>
			{
				new IdentityResources.OpenId(),
				new IdentityResources.Profile()
			};
		}

		public static IEnumerable<Client> GetClients()
		{
			return new List<Client>();
		}
	}
}
