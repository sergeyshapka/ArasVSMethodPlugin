﻿//------------------------------------------------------------------------------
// <copyright file="IMethodOpener.cs" company="Aras Corporation">
//     © 2017-2019 Aras Corporation. All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Aras.VS.MethodPlugin.OpenMethodInVS
{
	public interface IMethodOpener
	{
		void OpenMethodFromAras(string openRequestString);
	}
}
