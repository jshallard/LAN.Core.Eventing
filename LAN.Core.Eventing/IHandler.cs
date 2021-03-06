﻿using System;
using System.Diagnostics.Contracts;
using System.Security.Principal;

namespace LAN.Core.Eventing
{
	[ContractClass(typeof(ContractHandler))]
	public interface IHandler
	{
		Type GetRequestType();
		void Invoke(RequestBase req, IPrincipal principal);
		bool IsAuthorized(RequestBase req, IPrincipal principal);
	}

	[ContractClassFor(typeof(IHandler))]
	abstract class ContractHandler : IHandler
	{
		Type IHandler.GetRequestType()
		{
			Contract.Ensures(Contract.Result<Type>() != null);
			throw new NotImplementedException();
		}

		void IHandler.Invoke(RequestBase req, IPrincipal principal)
		{
			Contract.Requires(req != null);
			Contract.Requires(principal != null);
			throw new NotImplementedException();
		}


		bool IHandler.IsAuthorized(RequestBase req, IPrincipal principal)
		{
			Contract.Requires(req != null);
			Contract.Requires(principal != null);
			throw new NotImplementedException();
		}
	}
}