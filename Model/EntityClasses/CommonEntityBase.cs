﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.2.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections;
using SqlExpressNovember;

namespace SqlExpressNovember.EntityClasses
{
	/// <summary>Class which is the common base class for all generated entity classes.</summary>
	/// <remarks>As all non-subtype entity classes derive from this class, use a partial class of this class to implement code which is shared among all generated entity classes</remarks>
	[DataContract(IsReference = true)]
	[Serializable]
	public abstract partial class CommonEntityBase
	{
		#region Class Extensibility Methods
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();
		#endregion
	
		/// <summary>Initializes a new instance of the <see cref="CommonEntityBase"/> class.</summary>
		protected CommonEntityBase() : base()
		{
			OnCreated();
		}
		
	}
}  