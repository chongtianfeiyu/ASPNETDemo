using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Person:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Person
	{
		public Person()
		{}
		#region Model
		private int _businessentityid;
		private string _persontype;
		private bool _namestyle= false;
		private string _title;
		private string _firstname;
		private string _middlename;
		private string _lastname;
		private string _suffix;
		private int _emailpromotion=0;
		private xml _additionalcontactinfo;
		private xml _demographics;
		private Guid _rowguid;
		private DateTime _modifieddate= DateTime.Now;
		/// <summary>
		/// Primary key for Person records.
		/// </summary>
		public int BusinessEntityID
		{
			set{ _businessentityid=value;}
			get{return _businessentityid;}
		}
		/// <summary>
		/// Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact
		/// </summary>
		public string PersonType
		{
			set{ _persontype=value;}
			get{return _persontype;}
		}
		/// <summary>
		/// 0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.
		/// </summary>
		public bool NameStyle
		{
			set{ _namestyle=value;}
			get{return _namestyle;}
		}
		/// <summary>
		/// A courtesy title. For example, Mr. or Ms.
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// First name of the person.
		/// </summary>
		public string FirstName
		{
			set{ _firstname=value;}
			get{return _firstname;}
		}
		/// <summary>
		/// Middle name or middle initial of the person.
		/// </summary>
		public string MiddleName
		{
			set{ _middlename=value;}
			get{return _middlename;}
		}
		/// <summary>
		/// Last name of the person.
		/// </summary>
		public string LastName
		{
			set{ _lastname=value;}
			get{return _lastname;}
		}
		/// <summary>
		/// Surname suffix. For example, Sr. or Jr.
		/// </summary>
		public string Suffix
		{
			set{ _suffix=value;}
			get{return _suffix;}
		}
		/// <summary>
		/// 0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. 
		/// </summary>
		public int EmailPromotion
		{
			set{ _emailpromotion=value;}
			get{return _emailpromotion;}
		}
		/// <summary>
		/// Additional contact information about the person stored in xml format. 
		/// </summary>
		public xml AdditionalContactInfo
		{
			set{ _additionalcontactinfo=value;}
			get{return _additionalcontactinfo;}
		}
		/// <summary>
		/// Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.
		/// </summary>
		public xml Demographics
		{
			set{ _demographics=value;}
			get{return _demographics;}
		}
		/// <summary>
		/// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
		/// </summary>
		public Guid rowguid
		{
			set{ _rowguid=value;}
			get{return _rowguid;}
		}
		/// <summary>
		/// Date and time the record was last updated.
		/// </summary>
		public DateTime ModifiedDate
		{
			set{ _modifieddate=value;}
			get{return _modifieddate;}
		}
		#endregion Model

	}
}

