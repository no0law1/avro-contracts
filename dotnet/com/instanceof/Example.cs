// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.11.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace com.instanceof
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class Example : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"Example\",\"namespace\":\"com.instanceof\",\"fields\":[{\"name\":" +
				"\"name\",\"type\":\"string\"},{\"name\":\"age\",\"type\":\"int\"},{\"name\":\"email\",\"type\":\"stri" +
				"ng\"},{\"name\":\"address\",\"default\":null,\"type\":[\"null\",\"string\"]}]}");
		private string _name;
		private int _age;
		private string _email;
		private string _address;
		public virtual Schema Schema
		{
			get
			{
				return Example._SCHEMA;
			}
		}
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public int age
		{
			get
			{
				return this._age;
			}
			set
			{
				this._age = value;
			}
		}
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				this._email = value;
			}
		}
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.name;
			case 1: return this.age;
			case 2: return this.email;
			case 3: return this.address;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.name = (System.String)fieldValue; break;
			case 1: this.age = (System.Int32)fieldValue; break;
			case 2: this.email = (System.String)fieldValue; break;
			case 3: this.address = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
