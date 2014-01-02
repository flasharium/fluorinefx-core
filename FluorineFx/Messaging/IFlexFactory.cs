/*
	FluorineFx open source library 
	Copyright (C) 2007 Zoltan Csibi, zoltan@TheSilentGroup.com, FluorineFx.com 
	
	This library is free software; you can redistribute it and/or
	modify it under the terms of the GNU Lesser General Public
	License as published by the Free Software Foundation; either
	version 2.1 of the License, or (at your option) any later version.
	
	This library is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
	Lesser General Public License for more details.
	
	You should have received a copy of the GNU Lesser General Public
	License along with this library; if not, write to the Free Software
	Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
*/
using System;
using System.Collections;
using FluorineFx.Messaging.Config;

namespace FluorineFx.Messaging
{
	/// <summary>
	/// The IFlexFactory interface is implemented by factory components that provide object instances.
	/// </summary>
	public interface IFlexFactory
	{
		/// <summary>
		/// This method is called when the definition of an instance that this factory looks up is initialized. 
		/// </summary>
		/// <param name="id">The Destination identity.</param>
		/// <param name="properties">Configuration properties.</param>
        /// <returns>A FactoryInstance instance.</returns>
		FactoryInstance CreateFactoryInstance(string id, DestinationProperties properties);
		/// <summary>
		/// This method is called by the default implementation of FactoryInstance.Lookup.
		/// </summary>
        /// <param name="factoryInstance">FactoryInstance used to retrieve the object instance.</param>
        /// <returns>The Object instance to use for the given operation for the current destination.</returns>
		object Lookup(FactoryInstance factoryInstance);
	}
}
