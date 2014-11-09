using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Person
	/// </summary>
	public partial class Person:IPerson
	{
		public Person()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Person model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Person(");
			strSql.Append("BusinessEntityID,PersonType,NameStyle,Title,FirstName,MiddleName,LastName,Suffix,EmailPromotion,AdditionalContactInfo,Demographics,rowguid,ModifiedDate)");
			strSql.Append(" values (");
			strSql.Append("@BusinessEntityID,@PersonType,@NameStyle,@Title,@FirstName,@MiddleName,@LastName,@Suffix,@EmailPromotion,@AdditionalContactInfo,@Demographics,@rowguid,@ModifiedDate)");
			SqlParameter[] parameters = {
					new SqlParameter("@BusinessEntityID", SqlDbType.Int,4),
					new SqlParameter("@PersonType", SqlDbType.NChar,2),
					new SqlParameter("@NameStyle", SqlDbType.Bit,1),
					new SqlParameter("@Title", SqlDbType.NVarChar,8),
					new SqlParameter("@FirstName", SqlDbType.NVarChar,50),
					new SqlParameter("@MiddleName", SqlDbType.NVarChar,50),
					new SqlParameter("@LastName", SqlDbType.NVarChar,50),
					new SqlParameter("@Suffix", SqlDbType.NVarChar,10),
					new SqlParameter("@EmailPromotion", SqlDbType.Int,4),
					new SqlParameter("@AdditionalContactInfo", SqlDbType.xml,-1),
					new SqlParameter("@Demographics", SqlDbType.xml,-1),
					new SqlParameter("@rowguid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ModifiedDate", SqlDbType.DateTime)};
			parameters[0].Value = model.BusinessEntityID;
			parameters[1].Value = model.PersonType;
			parameters[2].Value = model.NameStyle;
			parameters[3].Value = model.Title;
			parameters[4].Value = model.FirstName;
			parameters[5].Value = model.MiddleName;
			parameters[6].Value = model.LastName;
			parameters[7].Value = model.Suffix;
			parameters[8].Value = model.EmailPromotion;
			parameters[9].Value = model.AdditionalContactInfo;
			parameters[10].Value = model.Demographics;
			parameters[11].Value = Guid.NewGuid();
			parameters[12].Value = model.ModifiedDate;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.Person model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Person set ");
			strSql.Append("BusinessEntityID=@BusinessEntityID,");
			strSql.Append("PersonType=@PersonType,");
			strSql.Append("NameStyle=@NameStyle,");
			strSql.Append("Title=@Title,");
			strSql.Append("FirstName=@FirstName,");
			strSql.Append("MiddleName=@MiddleName,");
			strSql.Append("LastName=@LastName,");
			strSql.Append("Suffix=@Suffix,");
			strSql.Append("EmailPromotion=@EmailPromotion,");
			strSql.Append("AdditionalContactInfo=@AdditionalContactInfo,");
			strSql.Append("Demographics=@Demographics,");
			strSql.Append("rowguid=@rowguid,");
			strSql.Append("ModifiedDate=@ModifiedDate");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@BusinessEntityID", SqlDbType.Int,4),
					new SqlParameter("@PersonType", SqlDbType.NChar,2),
					new SqlParameter("@NameStyle", SqlDbType.Bit,1),
					new SqlParameter("@Title", SqlDbType.NVarChar,8),
					new SqlParameter("@FirstName", SqlDbType.NVarChar,50),
					new SqlParameter("@MiddleName", SqlDbType.NVarChar,50),
					new SqlParameter("@LastName", SqlDbType.NVarChar,50),
					new SqlParameter("@Suffix", SqlDbType.NVarChar,10),
					new SqlParameter("@EmailPromotion", SqlDbType.Int,4),
					new SqlParameter("@AdditionalContactInfo", SqlDbType.xml,-1),
					new SqlParameter("@Demographics", SqlDbType.xml,-1),
					new SqlParameter("@rowguid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ModifiedDate", SqlDbType.DateTime)};
			parameters[0].Value = model.BusinessEntityID;
			parameters[1].Value = model.PersonType;
			parameters[2].Value = model.NameStyle;
			parameters[3].Value = model.Title;
			parameters[4].Value = model.FirstName;
			parameters[5].Value = model.MiddleName;
			parameters[6].Value = model.LastName;
			parameters[7].Value = model.Suffix;
			parameters[8].Value = model.EmailPromotion;
			parameters[9].Value = model.AdditionalContactInfo;
			parameters[10].Value = model.Demographics;
			parameters[11].Value = model.rowguid;
			parameters[12].Value = model.ModifiedDate;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Person ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Person GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BusinessEntityID,PersonType,NameStyle,Title,FirstName,MiddleName,LastName,Suffix,EmailPromotion,AdditionalContactInfo,Demographics,rowguid,ModifiedDate from Person ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.Person model=new Maticsoft.Model.Person();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Person DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Person model=new Maticsoft.Model.Person();
			if (row != null)
			{
				if(row["BusinessEntityID"]!=null && row["BusinessEntityID"].ToString()!="")
				{
					model.BusinessEntityID=int.Parse(row["BusinessEntityID"].ToString());
				}
				if(row["PersonType"]!=null)
				{
					model.PersonType=row["PersonType"].ToString();
				}
				if(row["NameStyle"]!=null && row["NameStyle"].ToString()!="")
				{
					if((row["NameStyle"].ToString()=="1")||(row["NameStyle"].ToString().ToLower()=="true"))
					{
						model.NameStyle=true;
					}
					else
					{
						model.NameStyle=false;
					}
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["FirstName"]!=null)
				{
					model.FirstName=row["FirstName"].ToString();
				}
				if(row["MiddleName"]!=null)
				{
					model.MiddleName=row["MiddleName"].ToString();
				}
				if(row["LastName"]!=null)
				{
					model.LastName=row["LastName"].ToString();
				}
				if(row["Suffix"]!=null)
				{
					model.Suffix=row["Suffix"].ToString();
				}
				if(row["EmailPromotion"]!=null && row["EmailPromotion"].ToString()!="")
				{
					model.EmailPromotion=int.Parse(row["EmailPromotion"].ToString());
				}
					//model.AdditionalContactInfo=row["AdditionalContactInfo"].ToString();
					//model.Demographics=row["Demographics"].ToString();
				if(row["rowguid"]!=null && row["rowguid"].ToString()!="")
				{
					model.rowguid= new Guid(row["rowguid"].ToString());
				}
				if(row["ModifiedDate"]!=null && row["ModifiedDate"].ToString()!="")
				{
					model.ModifiedDate=DateTime.Parse(row["ModifiedDate"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select BusinessEntityID,PersonType,NameStyle,Title,FirstName,MiddleName,LastName,Suffix,EmailPromotion,AdditionalContactInfo,Demographics,rowguid,ModifiedDate ");
			strSql.Append(" FROM Person ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" BusinessEntityID,PersonType,NameStyle,Title,FirstName,MiddleName,LastName,Suffix,EmailPromotion,AdditionalContactInfo,Demographics,rowguid,ModifiedDate ");
			strSql.Append(" FROM Person ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Person ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from Person T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Person";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

